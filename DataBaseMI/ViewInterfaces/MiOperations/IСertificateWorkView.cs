using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    public interface IСertificateWorkView : IView, IDbBaseView<Сertificate>
    {
        /// <summary>
        /// Показать шапку формы, содержащую информацию о СИ
        /// </summary>
        /// <param name="measuringInstrument">СИ, о котором выводим информацию</param>
        public void ShowHead(MeasuringInstrument measuringInstrument);
    }
}
