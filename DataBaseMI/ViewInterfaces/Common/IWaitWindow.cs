using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{

    /// <summary>
    /// Интерфейс класса, выводящего форму с сообщением о необходимости подождать завершения операции
    /// </summary>
    public interface IWaitWindow
    {
        /// <summary>
        /// Закрыть окно
        /// </summary>
        public void CloseWindow();

        /// <summary>
        /// Отобразить
        /// </summary>
        public void Run(SynchronizationContext? SyncContext);

    }
}
