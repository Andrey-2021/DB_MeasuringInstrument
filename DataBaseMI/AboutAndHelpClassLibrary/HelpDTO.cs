using System;
using System.Collections.Generic;
using System.Text;

namespace HelpAndAboutClassLibrary
{
    /// <summary>
    /// Представляет структуру записи в Help.xml и About.xml файлах
    /// </summary>
    class HelpDTO
    {
        /// <summary>
        /// Название праграфа
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Текст параграфа
        /// </summary>
        public string? Text { get; set; }
    }
}
