using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Поиск средств Измерения удовлетворяющих критериям поиска
    /// </summary>
    public interface IFindMIView
    {
        /// <summary>
        /// Получить данные о Средствах Измерения, удовлетворяющих условиям поиска
        /// </summary>
        public event EventHandler<FindMeasuringInstrumentDTO>? RefreshingAllMeasuringInstruments;

        /// <summary>
        /// Показать (вывести на экран) информацию о найденных Средствах Измерения
        /// </summary>
        /// <param name="list"></param>
        public void PrintData(List<MeasuringInstrument> list, MeasuringInstrument? entity = null);
    }
}
