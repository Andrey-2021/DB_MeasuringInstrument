using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClassLibrary
{
    public class FindMeasuringInstrumentDTO
    {
        /// <summary>
        /// Наименованиеие прибора
        /// </summary>
        public string? DeviceName { get; set; } //(2)

        /// <summary>
        /// Заводской номер
        /// </summary>
        public string? ManufacturerNumber { get; set; }

        /// <summary>
        /// Инвентарный номер
        /// </summary>
        public string? InventoryNumber { get; set; }

        /// <summary>
        /// Условие отбора записей в БД
        /// </summary>
        public Func<MeasuringInstrument, bool> Predicate => 
            x => x.DeviceName.ToUpper().Contains(this.DeviceName.ToUpper()) == true
            && x.ManufacturerNumber.ToUpper().Contains(this.ManufacturerNumber.ToUpper()) == true
            && x.InventoryNumber.ToUpper().Contains(this.InventoryNumber.ToUpper()) == true;
    }
}
