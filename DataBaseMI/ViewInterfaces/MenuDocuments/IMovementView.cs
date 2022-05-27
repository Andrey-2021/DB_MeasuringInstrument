using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces.Documents
{

    /// <summary>
    /// Интерфейс окна, в котором выбирается СИ, для которого будет сохранёна (создана) на диске "Накладная на внутреннее перемещение"
    /// </summary>
    public interface IMovementView : IFindMIView, IView
    {
        /// <summary>
        /// Поиск Накладных на перемещение для выбранного СИ
        /// </summary>
        public event EventHandler<MeasuringInstrument>? FindingMovment;


        /// <summary>
        /// Создание Накладной на перемещение СИ
        /// </summary>
        public event EventHandler<Moving>? SavingMovingInDocxFile;

        /// <summary>
        /// Показать (вывести на экран) накладные на перемещение
        /// </summary>
        /// <param name="list"></param>
        public void PrintMovmentData(List<Moving> list);
    }
}
