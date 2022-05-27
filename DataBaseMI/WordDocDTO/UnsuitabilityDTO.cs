using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocDTO
{
    /// <summary>
    /// Объект передачи данных для создания 'Извещение о непригодности к применению'
    /// </summary>
    public class UnsuitabilityDTO
    {
        /// <summary>
        /// Имя файла, в который сохраняем 'Извещение о непригодности к применению'
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// Свойство. Извещение о непригодности к применению
        /// </summary>
        public Unsuitability? Unsuitability { get; set; }

    }
}
