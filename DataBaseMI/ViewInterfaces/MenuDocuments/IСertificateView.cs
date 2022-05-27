using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces.Documents
{
    /// <summary>
    /// Интерфейс окна, в котором выбирается СИ, для которого будет сохранёна (создана) на диске "Свидетельство о поверке"
    /// </summary>
    public interface IСertificateView : IFindMIView, IView
    {/// <summary>
     /// Поиск свидетельств о поверке для выбранного СИ
     /// </summary>
        public event EventHandler<MeasuringInstrument>? FindingСertificate;


        /// <summary>
        /// Создание Свидетельство о поверке СИ
        /// </summary>
        //public event EventHandler<Сertificate>? SavingСertificateInDocxFile;
        public event Action<Сertificate, EnumСertificateVersion>? SavingСertificateInDocxFile;

        /// <summary>
        /// Показать (вывести на экран) Свидетельства о поверке
        /// </summary>
        /// <param name="list"></param>
        public void PrintСertificateData(List<Сertificate> list);
    }
}
