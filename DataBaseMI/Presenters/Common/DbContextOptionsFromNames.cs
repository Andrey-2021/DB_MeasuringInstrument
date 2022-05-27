using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    /// <summary>
    /// Создать DbContextOptions
    /// </summary>
    internal class DbContextOptionsFromNames
    {
        /// <summary>
        /// Создать DbContextOptions для переданных названий сервера и БД
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serverName">Название сервера</param>
        /// <param name="dBName">Название БД</param>
        /// <returns>Созданный экземпляр DbContextOptions</returns>
        public static DbContextOptions<T> CreateDbContextOptions<T>((string? serverName, string? dBName)? data) where T : DbContext
        {
            string connectionString = "Server=" + data?.serverName + ";Database=" + data?.dBName + ";Trusted_Connection=true;";
            var optionsBuilder = new DbContextOptionsBuilder<T>();

            var options = optionsBuilder
                   .UseSqlServer(connectionString)
                   .Options;
            return options;
        }
    }
}
