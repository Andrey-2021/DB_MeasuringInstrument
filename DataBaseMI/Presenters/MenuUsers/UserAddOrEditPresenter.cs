using CommonClassLibrary;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;
using CommonInterface;
using ViewInterfaces;

namespace Presenters
{
    /// <summary>
    /// Presenter для окна ввода нового пользователя или редактирования данных выбранного пользователя
    /// </summary>
    public class UserAddOrEditPresenter: BasePresenterForAddOrEdit<User>
    {
        public UserAddOrEditPresenter(
           IDbBaseViewForAddOrEdit<User> view,
           IRepository repositiry,
           EnumOperation operation,
           User? data
           ):base (view, repositiry, operation, data)
        {

        }

        protected override async void TransmissionDtatInView()
        {
            //todo надо переделать чтобы получал IQuarable из репозитория
            bool rezult = false;

            try
            {
                var departments = _repositiry.ReadFromDbAsync<Department>();
                await departments;
                var message = ConfigeAddOrEdit();

                ((IUserAddOrEditView)_view).PrintData(_data, message, departments.Result);
                //((IUserAddOrEditView)_view).PrintData(_data, message, null);

                rezult = true;
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
                rezult= false;
            }
        }
    }
}
