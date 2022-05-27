using CommonClassLibrary;
using CommonInterface;
using ConteinerLibrary;
using DbClassLibrary;
using Microsoft.EntityFrameworkCore;
using RepositoryInterfaces;
using System.Text;
using ViewInterfaces;
using ViewInterfaces.Common;

namespace Presenters
{
    /// <summary>
    /// Базовый класс для работы с окнами, в которых выводятся наборы 
    /// данных(Списки экземпляров объектов предметной области)
    /// </summary>
    /// <typeparam name="T">Тип класса предметной области</typeparam>
    public class BasePresenter<T> : IPresenter where T : class, ICloneable
    {
        protected IDbBaseView<T> _view;

        protected DbContextOptions? _dbOption;
        protected IRepository? _repositiry;
        //  IDbBaseViewForAddOrEdit<T> _viewForAddOrEdit;

        protected T? selectedObject = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        public BasePresenter(IDbBaseView<T> view, DbContextOptions? dbOption)
        //IRepository repositiry)
        //IDbBaseViewForAddOrEdit<T> viewForAddOrEdit)
        {
            _view = view;
            _view.RefreshAll += RefreshAllDatas;
            _view.Adding += AddNew;
            _view.Deleting += DelRecordInDB;
            _view.Editing += EditRecordInDB;
            _view.ClosingMyWindow += CloseViewWindow;
            // SubscribeOnDeleting();

            _dbOption = dbOption;
            //_repositiry = repositiry;

            // _viewForAddOrEdit = viewForAddOrEdit;
        }

        //public virtual void SubscribeOnDeleting()
        //{
        //    _view.Deleting += DelRecordInDB;
        //}

        public virtual void Run()
        {

            RefreshAllDatas(this, EventArgs.Empty);
            _view.ShowView();
            _repositiry?.Dispose();
        }


        public virtual async void RefreshAllDatas(object? sender, EventArgs args)
        {
            try
            {
                var context = new MyDbContext(_dbOption);
                if (selectedObject != null) context.Set<T>().Attach(selectedObject);

                _repositiry = context;
                var list = await _repositiry.ReadFromDbAsync<T>();
                _view.PrintData(list, selectedObject);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        /// <summary>
        /// Удалить запись из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data">Удаляемая запись</param>
        public async void DelRecordInDB(object? sender, T data)
        {

            //1. проверяем есть ли запись с СИ содержащая ссылку на удаляемый объект
            if (data is IMiDependence)
            {
                IMiDependence? main = data as IMiDependence;

                //((MyDbContext)_repositiry).MeasuringInstruments.Where(u => u.CompanyId == company.Id).Load();

                if (main!.MeasuringInstruments.Count > 0)
                {
                    //Коичество зависимых записей по которым выводим информацию
                    //выодим информацию только о 5 зависимых объектах
                    const int numberShowRecords = 5;
                    int numbeShowRecord = numberShowRecords;

                    if (main.MeasuringInstruments.Count < numberShowRecords) numbeShowRecord = main.MeasuringInstruments.Count;

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < numbeShowRecord; i++)
                    {
                        builder.Append("Инвентарный №: " + main.MeasuringInstruments[i].InventoryNumber + ", " + main.MeasuringInstruments[i].DeviceName);
                        if (i != numbeShowRecord - 1) builder.Append(Environment.NewLine);
                    }

                    if (numbeShowRecord < main.MeasuringInstruments.Count) builder.Append(Environment.NewLine + "...");

                    _view.ShowWarning("Запись не может быит удалена т.к. используется в СИ:"
                        + Environment.NewLine
                        + builder.ToString());
                    return;
                }
            }



            //2. удаляем объект

            var db = new MyDbContext(_dbOption);
            db.Find<T, MeasuringInstrument>(data);

            try
            {
                var rezult = await _repositiry.DeleteInDbAsync<T>(data);
                if (rezult) _view.ShowInfo("Данные удалены");
                selectedObject = null;
            }
            catch (AccessViolationException ex)
            {
                _view.ShowError(ex.Message);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }

            //обновить
            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);
        }


        /// <summary>
        /// Обработать в своём для этого типа AddOrEditPresenter-е 
        /// </summary>
        /// <returns>true- обраотано, false - не обработано</returns>
        bool WorkInMyPresenter(EnumOperation operation, T? data = null)
        {
            IDbBaseViewForAddOrEdit<T>? _viewForAddOrEdit = Conteiner.GetInstance().GetAddOrEditFormInstance<T>();

            //пробуем получить свой AddOrEditPresenter для этого типа
            var inctance = Conteiner.GetInstance().GetAddOrEditPresenterInstance<T>(_viewForAddOrEdit, _repositiry, operation, data);

            if (inctance != null) //если есть зарегистрированный свой presenter
            { //работаем с ним
                selectedObject = inctance.Run();
                return true;
            }
            return false;
        }


        public virtual void AddNew(object? sender, EventArgs args)
        {


            if (!WorkInMyPresenter(EnumOperation.AddNew)) //тогда используем презентер по умолчанию
            {
                IDbBaseViewForAddOrEdit<T> _viewForAddOrEdit =
                Conteiner.GetInstance().GetAddOrEditFormInstance<T>();

                var addOrEditPresenter = new BasePresenterForAddOrEdit<T>
                    (_viewForAddOrEdit, _repositiry, EnumOperation.AddNew, null);
                addOrEditPresenter.Run();
            }

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);
            //RefreshAllDatas(this, EventArgs.Empty);

        }






        /// <summary>
        /// Изменить запись в БД
        /// </summary>
        /// <param name="sender"></param>
        public virtual void EditRecordInDB(object? sender, T data)
        {

            if (!WorkInMyPresenter(EnumOperation.Edit, data)) //тогда используем презентер по умолчанию
            {
                IDbBaseViewForAddOrEdit<T> _viewForAddOrEdit =
                Conteiner.GetInstance().GetAddOrEditFormInstance<T>();

                var addOrEditPresenter = new BasePresenterForAddOrEdit<T>
                (_viewForAddOrEdit, _repositiry, EnumOperation.Edit, data);

                addOrEditPresenter.Run();
            }

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);

            //RefreshAllDatas(this, EventArgs.Empty);

            //_repositiry.EditRecord(data);
        }


        public void CloseViewWindow(object? sender, EventArgs args)
        {
            _view.CloseView();
        }
    }
}
