using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces.Common
{
 /// <summary>
 /// Базовый интерфейс для всех Окон (WindowsForm), в которых редактируются старые
 /// или вводятся новые данные для записи в БД
 /// </summary>
 /// <typeparam name="T"></typeparam>
    public interface IDbBaseViewForAddOrEdit<T>:IView
    {
        /// <summary>
        /// Событие. Сохранить новые данные
        /// </summary>
        public event EventHandler<T> SavingNewData;

        /// <summary>
        /// Показать данные на форме (экране)
        /// </summary>
        /// <param name="data"></param>
        public virtual void PrintData(T? data, string message)
        {
        }
    }
}
