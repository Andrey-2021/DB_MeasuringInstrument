using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpAndAboutModelInterface
{
    /// <summary>
    /// Вариант использования (или "Помощь", или "О программе")
    /// </summary>
    public enum WorkMode
    {
        /// <summary>
        /// Работаем с данными для раздела Помощь
        /// </summary>
        help,

        /// <summary>
        /// Работаем с данными для раздела О программе
        /// </summary>
        about
    }
}
