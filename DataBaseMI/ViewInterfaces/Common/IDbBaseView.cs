using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    public interface IDbBaseView<T> :IView
        where T:class
    {
        /// <summary>
        /// Обновть данные (Получить обновлённые данные из БД )
        /// </summary>
        public event EventHandler? RefreshAll;

        /// <summary>
        /// Событие. Ввод нового
        /// </summary>
        public event EventHandler? Adding;

        /// <summary>
        /// Событие. Удаление
        /// </summary>
        public event EventHandler<T>? Deleting;

        /// <summary>
        /// Событие. Обновление
        /// </summary>
        public event EventHandler<T>? Editing;

        /// <summary>
        /// Показать (вывести на экран) Информацию
        /// </summary>
        /// <param name="list"></param>
        public void PrintData(List<T> list, T? entity = null);
        
    }
}
