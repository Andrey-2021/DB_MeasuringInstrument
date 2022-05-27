using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Кто инициатор закрытия окна
    /// </summary>
    public enum EnumWhoClosingWindow
    {
        /// <summary>
        /// Само окно закрывает себя
        /// </summary>
        window,

        /// <summary>
        /// Окно закрывает presenter
        /// </summary>
        presener,

        /// <summary>
        /// пусто
        /// </summary>
        empty
    }
}
