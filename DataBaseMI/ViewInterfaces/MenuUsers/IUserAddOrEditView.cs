using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;
using CommonClassLibrary;


namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс Окна для ввода нового пользователя или редактирования данных выбранного пользователя
    /// </summary>
    public interface IUserAddOrEditView : IView, IDbBaseViewForAddOrEdit<User>
    {
        /// <summary>
        /// Вывести данные на экран
        /// </summary>
        /// <param name="data">Пользователь</param>
        /// <param name="message">Сообщение, выводимое в заголовок формы</param>
        /// <param name="departments">Список подразделенй (местоположений)</param>
        public void PrintData(User? data, string message, List<Department>? departments);
    }
}
