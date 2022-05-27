using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс Формы для редактирования настроек соединения с сервером БД
    /// </summary>
    public interface IServerSettingsView : IView
    {
        /// <summary>
        /// Событие. Проверить доступность Сервера БД
        /// </summary>
        public event EventHandler<string?>? ServerConnectionChecking;

        /// <summary>
        /// Событие. Проверить наличие БД
        /// </summary>
        public event EventHandler<(string? serverName, string? dBName)>? DBEnableChecking;

        /// <summary>
        /// Сохранить новые настройки подключения к серверу БД
        /// </summary>
        public event EventHandler<(string? serverName, string? dBName)>? SavingNewSettings;

        /// <summary>
        /// Создать новую БД
        /// </summary>
        public event EventHandler<(string? serverName, string? dBName)>? CreatingNewDb;

        /// <summary>
        /// Вывод данных
        /// </summary>
        public void PrintData(string? currentServerName, string? currentDbName);
    }
}
