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
    public class CalibratorAddOrEditPresenter
    : BasePresenterForAddOrEdit<Calibrator>
    {
        public CalibratorAddOrEditPresenter(
           IDbBaseViewForAddOrEdit<Calibrator> view,
           IRepository repositiry,
           EnumOperation operation,
           Calibrator? data
           ) : base(view, repositiry, operation, data)
        {

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
                var departments = _repositiry.ReadFromDbAsync<Department>();

                await departments;

                var message = ConfigeAddOrEdit();
                //_view.PrintData(_data, message);

                ((ICalibratorAddOrEditView)_view).PrintData(_data, message, departments.Result);
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
