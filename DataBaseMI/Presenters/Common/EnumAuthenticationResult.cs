using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Common
{
    /// <summary>
    /// Результат аутентификации пользователя
    /// </summary>
    public enum EnumAuthenticationResult
    {
        /// <summary>
        /// Администратор
        /// </summary>
        admin,

        /// <summary>
        /// Пользователь
        /// </summary>
        user,

        /// <summary>
        /// Не определён
        /// </summary>
        off
    }
}
