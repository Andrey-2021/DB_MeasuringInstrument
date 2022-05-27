using CommonInterface;
using RepositoryInterfaces;
using System.ComponentModel.DataAnnotations;
using ViewInterfaces.Common;

namespace Presenters
{
    /// <summary>
    /// Базовый класс для работы с окнами ввода новых данных или редактирования данных выбранного объекта
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BasePresenterForAddOrEdit<T> : IPresenterForAddOrEdit<T>
        where T : class, ICloneable
    {
        protected IDbBaseViewForAddOrEdit<T> _view;
        protected IRepository _repositiry;
        protected EnumOperation _operation;
        protected T? _data;

        /// <summary>
        /// Клон объекта _data
        /// </summary>
        protected T? objectСlone = null;

        /// <summary>
        /// Флаг показывает что надо вернуть исходные значения для полей объекта (используется при редактировании данных)
        /// </summary>
        public bool isNecessaryReturnOldValues { get; set; } = false;

        /// <summary>
        /// Конструктор
        /// </summary>
        //public BasePresenterForAddOrEdit(
        //    IDbBaseViewForAddOrEdit<T> view,
        //    IRepository<T> repositiry,
        //    EnumOperation operation,
        //    T? data)

        public BasePresenterForAddOrEdit(
            IDbBaseViewForAddOrEdit<T> view,
            IRepository repositiry,
            EnumOperation operation,
            T? data
            )

        {
            if (operation == EnumOperation.Edit && data == null)
                throw new NullReferenceException("Нет данных для редактирования");

            _view = view;
            _view.SavingNewData += Save;
            _view.ClosingMyWindow += CloseViewWindow;

            _repositiry = repositiry;
            _data = data;
            _operation = operation;
        }


        public T? Run()
        {
            TransmissionDtatInView();
            _view.ShowView();
            return _data;// возврат созданного/отредактированного объекта для выделение его в DataGrid, чтобы было видно, что именно этот объект добавлен/отредактирован
        }



        protected virtual async void TransmissionDtatInView()
        {
            //string message;

            //if (_operation == EnumOperation.Edit)
            //{
            //    message = "Редактирование данных";

            //    //todo убрать if, он тут лишний.И тогда Избавиться от Предупреждения
            //    if(_data!=null) objectСlone = (T)_data.Clone();
            //}
            //else
            //{
            //    message = "Ввод новых данных";
            //    _data = (T?)Activator.CreateInstance(typeof(T));
            //    //obj =   new CalibrationPeriod();
            //}

            var message = ConfigeAddOrEdit();
            _view.PrintData(_data, message);
            //return true;
        }





        /// <summary>
        /// Настройка в зависимости от операции: 
        /// Создание нового объекта;
        /// Редактирование объекта.
        /// </summary>
        /// <returns></returns>
        protected virtual string ConfigeAddOrEdit()
        {
            string message;

            if (_operation == EnumOperation.Edit)
            {
                message = "Редактирование данных";
                objectСlone = _data?.Clone() as T;
            }
            else
            {
                message = "Ввод новых данных";
                _data = (T?)Activator.CreateInstance(typeof(T));
            }

            return message;
        }

        public async void Save(object? sender, T data)
        {
            if (_operation == EnumOperation.Edit
                && data.Equals(objectСlone)) //Если данные после ввода не изменились
            {//ничего не делам=не сохраняем в БД
                //Cancel(this, EventArgs.Empty);
                isNecessaryReturnOldValues = false;
                _view.CloseView();
                return;
            }

            //Валидация данных
            var results = new List<ValidationResult>();
            var context = new ValidationContext(data);

            if (!Validator.TryValidateObject(data, context, results, true))
            { //если ошибки при валидации
                string errorsList = "";
                foreach (var error in results)
                {
                    errorsList += error.ErrorMessage
                    + Environment.NewLine;
                }
                _view.ShowError(errorsList); //показываем ошибки валидации 
                isNecessaryReturnOldValues = true;
                return;
            }
            else //если валидация прошла успешно
            {
                try
                {
                    if (_operation == EnumOperation.AddNew)
                    {
                        //int i = Thread.CurrentThread.ManagedThreadId;
                        //Debug.WriteLine(i);

                        await _repositiry.AddToDbAsync<T>(data);
                        _view.ShowInfo("Данные добавлены");

                        //i = Thread.CurrentThread.ManagedThreadId;
                        //Debug.WriteLine(i);

                    }
                    else
                    {
                        var rezult = await _repositiry.UpdateInDbAsync<T>(data);
                        if (rezult) _view.ShowInfo("Данные изменены");
                    }

                    //Cancel(this, EventArgs.Empty);
                    //_view.CloseView();

                    isNecessaryReturnOldValues = false;
                    CloseViewWindow(this, EventArgs.Empty);

                }
                catch (Exception e)
                {
                    _view.ShowWarning(e.Message);

                    //int i = Thread.CurrentThread.ManagedThreadId;
                    //Debug.WriteLine(i);
                    if (_operation == EnumOperation.Edit) isNecessaryReturnOldValues = true;
                }
            }
        }



        public void CloseViewWindow(object? sender, EventArgs args)
        {
            //if (_operation == EnumOperation.Edit
            //   && !_data.Equals(objectСlone)) //Если данные изменились

            if (_operation == EnumOperation.Edit && isNecessaryReturnOldValues)
            {
                //т.е. когда данные изменили, но записать их БД не удалось
                //и пользователь закрыват окно
                _repositiry.UnChanged(_data); //возвращаем исходные данные
            }
            _view.CloseView();
        }
    }
}
