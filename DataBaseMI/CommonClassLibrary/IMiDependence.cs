using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClassLibrary
{

    /// <summary>
    /// Интерфейс показывает, что класс MeasuringInstrument (СИ) зависит от этой класса
    /// </summary>
    //Используется при удалении объекта.
    //Если от экземпляра удаляемого объекта зависит СИ в БД, т.е. на этот экземляр есть ссылка в какой-то записи СИ
    //программа не даст удалить экземпляр
    public interface IMiDependence
    {
        /// <summary>
        /// навигационное свойство
        /// </summary>
        public List<MeasuringInstrument> MeasuringInstruments { get; set; }
    }
}
