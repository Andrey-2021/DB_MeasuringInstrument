using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс для окна в котором выводится все зарегистрированные пользователи
    /// </summary>
    public interface IUserView : IView, IDbBaseView<User>
    {
        public event EventHandler<FindUserDTO>? RefreshingAllUsers;
    }
}
