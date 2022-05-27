using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocDTO
{
    /// <summary>
    /// Объект передачи данных для создания Накладной на перемещение СИ
    /// </summary>
    public class MovementDTO
    {
        /// <summary>
        /// Имя файла, в который сохраняем накладную на перемещение СИ
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// Свойство. Перемещение СИ
        /// </summary>
        public Moving? Moving { get; set; }

    }
}
