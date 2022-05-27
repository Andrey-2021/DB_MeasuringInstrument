using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterface
{
    /// <summary>
    /// Интерфейс класса обеспечивает работу с настройками подключения к серверу БД
    /// </summary>
    public interface IServerConnectionSettings
    {

        /// <summary>
        /// Сохранить настройки подключения к скрверу БД
        /// </summary>
        /// <param name="server"></param>
        /// <param name="database"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public  bool SaveSetting(string? server, string? database);

        /// <summary>
        /// Прочитать настройки подключения к серверу БД
        /// </summary>
        /// <returns></returns>
        /// <exception cref="IOException"></exception>
        public (string? Server, string? Database) GetSettings();

        /// <summary>
        /// Получить DbContextOptions для текущих настроек подключения к БД
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public DbContextOptions<T> GetDbContextOptionsBuilder<T>() where T : DbContext;
    }
}
