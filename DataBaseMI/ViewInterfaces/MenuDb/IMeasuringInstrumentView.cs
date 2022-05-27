using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClassLibrary;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс окна, в котором выводится информация о средствах измерения (СИ)
    /// </summary>
    public interface IMeasuringInstrumentView : IView, IDbBaseView<MeasuringInstrument>
    {

        /// <summary>
        /// Событие. Калибровка
        /// </summary>
        public event EventHandler<MeasuringInstrument>? Calibrating;

        /// <summary>
        /// Событие. Ремонт
        /// </summary>
        public event EventHandler<MeasuringInstrument>? Repairing;

        /// <summary>
        /// Событие. Перемещение СИ
        /// </summary>
        public event EventHandler<MeasuringInstrument>? Moving;

        /// <summary>
        /// Событие. Свидетельство о поверке
        /// </summary>
        public event EventHandler<MeasuringInstrument>? Certificating;

        /// <summary>
        /// Событие. Извещениями о непригодности к применению
        /// </summary>
        public event EventHandler<MeasuringInstrument>? Unsuitable;


        /// <summary>
        /// Событие. Обновить таблицу со СИ учитывая фильир
        /// </summary>
        public event EventHandler<FilterMiDTO?>? RefreshingAllFilteringMI;

        /// <summary>
        /// Показать (вывести на экран) Информацию
        /// </summary>
        public void PrintData(List<MeasuringInstrument> list,
            List<Department>? departments,
            List<DeviceType>? deviceType,
            List<DeviceState>? deviceState,
            MeasuringInstrument? entity = null
            );
    }
}
