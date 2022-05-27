namespace ServerConfiguration
{
    /// <summary>
    /// Настройки подключения к БД
    /// </summary>
    [Serializable]
    public class ServerSettings
    {
        /// <summary>
        /// Название сервера
        /// </summary>
        public string? Server { get; set; }
        
        /// <summary>
        /// Название БД
        /// </summary>
        public string? Database { get; set; }

        /// <summary>
        /// Проверка подлинности
        /// </summary>
        public string? TrustedConnection { get; set; } = "True";

        /// <summary>
        /// Конструктор
        /// </summary>
        public ServerSettings()
        {

        }
    }
}