using CommonClassLibrary;
using ConteinerLibrary;
using RepositoryInterfaces;
using System.Drawing;
using ViewInterfaces;
using ViewInterfaces.Common;

namespace Presenters
{

    public class MeasuringInstrumentAddOrEditPresenter
    : BasePresenterForAddOrEdit<MeasuringInstrument>
    {
        Photo? photo;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="view">View, с которым будет работать пользователь</param>
        /// <param name="repositiry">БД</param>
        /// <param name="operation">Выполняемая операция</param>
        /// <param name="data">Данные, которые будем изменять, или null,если будем вводить новые данные</param>
        public MeasuringInstrumentAddOrEditPresenter(
                    IDbBaseViewForAddOrEdit<MeasuringInstrument> view,
                    IRepository repositiry,
                    EnumOperation operation,
                    MeasuringInstrument? data
           ) : base(view, repositiry, operation, data)
        {
            ((IMeasuringInstrumentAddOrEditView)_view).SelectingPicture += SelectPicture;
        }


        /// <summary>
        /// Загрузка картинки из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        /// <exception cref="NullReferenceException"></exception>
        void SelectPicture(Object sender, EventArgs eventArgs)
        {

            var saveClass = Conteiner.GetInstance().GetClassInstance<ISelectFile>();
            if (saveClass == null) throw new NullReferenceException("Нет класса , реализующего интерфейс " + nameof(ISelectFile));


            Image? image = saveClass.LoadFileFromDisk();
            if (image == null)
            {
                photo = null;
            }
            else
            {
                photo = new Photo();
                photo.Image = image;
                ((IMeasuringInstrumentAddOrEditView)_view).TakePhoto(photo);
            }
        }


        protected override async void TransmissionDtatInView()
        {
            //User? obj = null;
            //string message;

            //if (_operation == EnumOperation.Edit)
            //{
            //    message = "Редактирование данных";

            //    //todo убрать if, он тут лишний.И тогда Избавиться от Предупреждения
            //    if (_data != null) obj = (User)_data.Clone();
            //}
            //else
            //{
            //    message = "Ввод новых данных";
            //    //obj = new User();
            //    _data = new User();
            //    //obj = (T?)Activator.CreateInstance(typeof(T));
            //}

            //todo надо переделать чтобы получал IQuarable из репозитория

            bool rezult = false;

            try
            {
                var message = ConfigeAddOrEdit();

                var departments = _repositiry.ReadFromDbAsync<Department>();
                await departments;

                var calibrationPeriod = _repositiry.ReadFromDbAsync<CalibrationPeriod>();
                await calibrationPeriod;

                var manufacturer = _repositiry.ReadFromDbAsync<Manufacturer>();
                await manufacturer;

                var deviceType = _repositiry.ReadFromDbAsync<DeviceType>();
                await deviceType;

                var measurementUnit = _repositiry.ReadFromDbAsync<MeasurementUnit>();
                await measurementUnit;

                var deviceState = _repositiry.ReadFromDbAsync<DeviceState>();
                await deviceState;



                //_view.PrintData(_data, message);
                ((IMeasuringInstrumentAddOrEditView)_view).PrintData(_data, message,
                    departments.Result,
                    calibrationPeriod.Result,
                    manufacturer.Result,
                    deviceType.Result,
                    measurementUnit.Result,
                    deviceState.Result
                    );
                //((IUserAddOrEditView)_view).PrintData(_data, message, null);

                rezult = true;
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
                rezult = false;
            }

            // return rezult;
        }
    }
}
