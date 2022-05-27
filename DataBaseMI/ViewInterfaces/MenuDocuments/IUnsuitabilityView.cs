using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces.Documents
{
    /// <summary>
    /// Интерфейс окна, в котором выбирается СИ, для которого будет сохранёно (создано) на диске "Извещение о непригодности к применению"
    /// </summary>
    public interface IUnsuitabilityView : IFindMIView, IView
    {
        /// <summary>
        /// Поиск 'Извещений о непригодности' для выбранного СИ
        /// </summary>
        public event EventHandler<MeasuringInstrument>? FindingUnsuitability;


        /// <summary>
        /// Создание Накладной на перемещение СИ
        /// </summary>
        public event EventHandler<Unsuitability>? SavingUnsuitabilityInDocxFile;

        /// <summary>
        /// Показать (вывести на экран) 'Извещения о непригодности'
        /// </summary>
        /// <param name="list"></param>
        public void PrintUnsuitabilityData(List<Unsuitability> list);
    }
}
