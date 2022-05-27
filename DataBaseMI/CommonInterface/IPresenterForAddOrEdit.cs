using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterface
{
    /// <summary>
    /// Интерфейс базового класса для работы с окнами ввода новых данных или редактирования данных выбранного объекта
    /// </summary>
    public interface IPresenterForAddOrEdit<T>
    {
        /// <summary>
        /// Выполнить
        /// </summary>
        T? Run();
    }
}
