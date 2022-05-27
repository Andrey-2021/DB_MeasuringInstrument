using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс формы ввода нового логина и пароля администратора
    /// </summary>
    public interface IPasswordChangeView : IView
    {
        /// <summary>
        /// Событие. Сохранить новые пароль и логин администратора
        /// </summary>
        public event EventHandler<(string? login, string? password, string? passwordCopy)>? SavingNewPassword;
    }
}
