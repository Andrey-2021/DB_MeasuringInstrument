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
    /// Интерфейс окна для ввода данных нового "Свидетельство о поверке"
    /// или редактирования старых данных у выбранного СИ
    /// </summary>
    public interface IСertificateWorkAddOrEditView : IView, IDbBaseViewForAddOrEdit<Сertificate>
    {
        // <summary>
        /// Показать данные на форме (экране)
        /// </summary>
        /// <param name="data">Свидетельство о поверке СИ</param>
        /// <param name="message">Сообщение в шапке окна</param>
        /// <param name="calibrator">Список поверителей</param>
        public void PrintData(Сertificate? data, string message, List<Calibrator>? calibrator);
    }
}
