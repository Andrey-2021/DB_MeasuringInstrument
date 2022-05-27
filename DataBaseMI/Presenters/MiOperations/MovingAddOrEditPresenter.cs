using CommonClassLibrary;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces;
using ViewInterfaces.Common;

namespace Presenters
{
    public class MovingAddOrEditPresenter: BasePresenterForAddOrEdit<Moving>
    {
        MeasuringInstrument _measuringInstrument;

        public MovingAddOrEditPresenter(
          IDbBaseViewForAddOrEdit<Moving> view,
          IRepository repositiry,
          EnumOperation operation,
          Moving? data,
            MeasuringInstrument measuringInstrument) : base(view, repositiry, operation, data)
        {
            _measuringInstrument = measuringInstrument;
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
                //var calibrators = _repositiry.ReadFromDbAsync<Calibrator>();
                //await calibrators;

                var departments = _repositiry.ReadFromDbAsync<Department>();
                await departments;
                
                var users = _repositiry.ReadFromDbAsync<User>();
                await users;

                var message = ConfigeAddOrEdit();
                //_view.PrintData(_data, message);

                ((IMovingAddOrEditView)_view).PrintData(_data, message,users.Result, departments.Result);
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


        protected override string ConfigeAddOrEdit()
        {
            string message;

            if (_operation == EnumOperation.Edit)
            {
                message = "Редактирование данных";

                //todo убрать if, он тут лишний.И тогда Избавиться от Предупреждения
                if (_data != null) objectСlone = (Moving)_data.Clone();
            }
            else
            {
                message = "Ввод новых данных";
                _data = new Moving(); //(T?)Activator.CreateInstance(typeof(T));
                _data.MeasuringInstrumentId = _measuringInstrument.Id;
                _data.MeasuringInstrument = _measuringInstrument;
                //_data.Date = DateTime.Now;
            }
            return message;
        }
    }

}
