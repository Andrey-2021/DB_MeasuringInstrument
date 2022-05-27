using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces.Documents
{
    /// <summary>
    /// Интерфейс окна, в котором выбирается СИ, для которого будет сохранён (создан) на диске "Паспорт СИ"
    /// </summary>
    public interface IPasportsView : IFindMIView, IView
    {
        /// <summary>
        /// Создание Паспорта СИ
        /// </summary>
        public event Action<MeasuringInstrument, EnumPasportVersion>? SavingPasportInDocxFile;
    }
}
