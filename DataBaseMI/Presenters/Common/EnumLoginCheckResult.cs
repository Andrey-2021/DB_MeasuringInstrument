using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Common
{
    /// <summary>
    /// Результат выполнения операции по проверке пользоватиля, администратора
    /// </summary>
    internal enum EnumLoginCheckResult
    {
        /// <summary>
        /// Не удалось проверить пользователя, есть ошибка/exception
        /// </summary>
        IСantСheckUser,

        /// <summary>
        /// Не удалось проверить администратора, есть ошибка/exception
        /// </summary>
        ICantCheckAdmin,

        /// <summary>
        /// Проверен, аутинтификация установленна. (Пользователь определён)
        /// </summary>
        СheckedSuccessfulResult,

        /// <summary>
        /// Проверены введённые логин ипароль, но аутинтификация не пройдена. (Такой пользватель не зарегистрирован)
        /// </summary>
        СheckedUnSuccessfulResult,

    }
}
