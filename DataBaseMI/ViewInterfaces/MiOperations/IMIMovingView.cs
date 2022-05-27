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
    /// Интерфейс окна, в котором выводится информация о перемещениях СИ
    /// </summary>
    public interface IMIMovingView : IView, IDbBaseView<Moving>
    {
        /// <summary>
        /// Показать шапку формы, содержащую информацию о СИ
        /// </summary>
        /// <param name="measuringInstrument">СИ, о котором выводим информацию</param>
        public void ShowHead(MeasuringInstrument measuringInstrument);
}
}
