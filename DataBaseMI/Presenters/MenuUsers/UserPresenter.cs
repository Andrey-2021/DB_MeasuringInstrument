using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces;
using CommonInterface;
using RepositoryInterfaces;
using CommonClassLibrary;
using ViewInterfaces.Documents;
using ConteinerLibrary;
using ViewInterfaces.Common;
using WordDocDTO;
using WordDocClassLibraryOpenXml;
using Microsoft.EntityFrameworkCore;

namespace Presenters
{
    /// <summary>
    /// Класс UserPresenter - Presenter для окна Пользователи
    /// </summary>
    internal class UserPresenter : BasePresenter<User>, IPresenter
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public UserPresenter(IUserView view, DbContextOptions dbOption)
            : base(view, dbOption)
        {
            ((IUserView)_view).RefreshingAllUsers += RefreshAllDatas;
        }

       public async void RefreshAllDatas(object sender, FindUserDTO data)
        {
            try
            {
                //todo сделать свой метод чтения из БД  асинхронным
                var list = _repositiry.ReadFromDb<User>(data.Predicate);
                _view.PrintData(list);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }
    }
}
