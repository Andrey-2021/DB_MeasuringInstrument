using CommonInterface;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;

namespace ServerConfiguration
{
    /// <summary>
    /// Класс обеспечивает работу с настройками подключения к серверу БД.
    /// Настройки сохраняем в файле ServerConnectionSettings.xml
    /// </summary>
    public class ServerConnectionSettings: IServerConnectionSettings
    {
        /// <summary>
        /// Имя файла в котором храним настройки подключения к серверу
        /// </summary>
        private const string fileName = "ServerConnectionSettings.xml";

        /// <summary>
        /// Сохранить настройки подключения к скрверу БД
        /// </summary>
        /// <param name="server"></param>
        /// <param name="database"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public bool SaveSetting(string? server, string? database)
        {
            if (string.IsNullOrEmpty(server)) throw new ArgumentNullException("Нет название сервера");
            if (string.IsNullOrEmpty(database)) throw new ArgumentNullException("Нет названия БД");

            // объект для сериализации
            ServerSettings settings = new ServerSettings() { Server = server, Database = database };

            // передаем в конструктор тип класса ServerSettings
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ServerSettings));

            try
            {
                // получаем поток, куда будем записывать сериализованный объект
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, settings);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new IOException("При сохранении настроек подключения к БД в файл "+ fileName + " произошла ошибка: "+ex.Message);
            }
        }

        /// <summary>
        /// Прочитать настройки подключения к серверу БД
        /// </summary>
        /// <returns></returns>
        /// <exception cref="IOException"></exception>
        public (string? Server, string? Database) GetSettings()
        {
            const string message = "Нет данных о кинфигурации подключения к БД";
            //string connectionString;

            if (!File.Exists(fileName))
            {
                throw new IOException("Нет файла с настройками подключения к БД: "+ fileName
                                    + Environment.NewLine
                                    + "Работа с данными неовозможна."
                                    + Environment.NewLine
                                    + "Обратитесь в службу поддрежки ПО");
                //return (message, message);
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ServerSettings));


            try
            {
            // десериализуем объект
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                ServerSettings? settings = xmlSerializer.Deserialize(fs) as ServerSettings;
                if (settings == null)
                {
                    // throw new IOException("Нет данных о кинфигурации подключения к БД");
                    return (message, message);
                }
                return (settings.Server, settings.Database);
                //connectionString = "Server="+ settings.Server+";Database="+ settings.Database+ ";Trusted_Connection="+ settings.TrustedConnection + ";";
            }
            }
            catch (Exception ex)
            {
                throw new IOException("При чтении настроек подключения к БД из файла " + fileName + " произошла ошибка: " + ex.Message);
            }
        }


        /// <summary>
        /// Получить DbContextOptions для текущих настроек подключения к БД
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public  DbContextOptions<T> GetDbContextOptionsBuilder<T>() where T:DbContext
        {
            var data= GetSettings();

            string connectionString = "Server=" + data.Server + ";Database=" + data.Database + ";Trusted_Connection=true;";

            var optionsBuilder = new DbContextOptionsBuilder<T>();

            var options = optionsBuilder
                    .UseSqlServer(connectionString)
                    .Options;

            return options;

           // return CreatebContextOptionsFromNames<T>(data.Server, data.Database);
        }
    }
}
