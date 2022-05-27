using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс окна для ввода данных нового "извещения о непригодности СИ"
    /// или редактирования старых данных у выбранного СИ
    /// </summary>
    public interface IUnsuitabilityWorkAddOrEditView : IView, IDbBaseViewForAddOrEdit<Unsuitability>
    {
        // <summary>
        /// Показать данные на форме (экране)
        /// </summary>
        /// <param name="data">Извещения о непригодности к применению СИ</param>
        /// <param name="message">Сообщение в шапке окна</param>
        /// <param name="calibrator">Список поверителей</param>
        public void PrintData(Unsuitability? data, string message, List<Calibrator>? calibrator);
    }
}
