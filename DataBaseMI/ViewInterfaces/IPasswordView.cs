using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс формы аутентификации входящего пользователя по введённым логину и паролю
    /// </summary>
    public interface IPasswordView : IView
    {
        /// <summary>
        /// Событие. Проверить логин и пароль входящего пользователя
        /// </summary>
        public event EventHandler<(string? login, string? password)>? CheckingLogin;
    }
}
