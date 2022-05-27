using CommonInterface;
using ConteinerLibrary;
using DbClassLibrary;
using Microsoft.EntityFrameworkCore;
using Presenters.Common;
using System.Net.NetworkInformation;
using ViewInterfaces;

namespace Presenters
{

    /// <summary>
    /// Presenter для окна настроек подключения к БД
    /// </summary>
    public class ServerSettingsPresenter : IPresenter
    {
        IServerSettingsView _view;

        /// <summary>
        /// Результат Аутентификации пользователя
        /// </summary>
        public EnumAuthenticationResult Login { get; private set; } = EnumAuthenticationResult.off;


        IServerConnectionSettings? _serverConnectionSettings;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="view"></param>
        /// <param name="repositiry"></param>
        public ServerSettingsPresenter(IServerSettingsView view, IServerConnectionSettings? serverConnectionSettings)
        {
            _serverConnectionSettings = serverConnectionSettings;

            _view = view;
            _view.ClosingMyWindow += CloseViewWindow;

            _view.ServerConnectionChecking += CheckServerConnection;
            _view.DBEnableChecking += CheckDb;
            _view.SavingNewSettings += SaveNewSetting;
            _view.CreatingNewDb += CreateNewDb;
        }

        public virtual void Run()
        {
            RefreshDatasInView();
            _view.ShowView();
        }


        /// <summary>
        /// Обновить данные в View
        /// </summary>
        void RefreshDatasInView()
        {
            try
            {
                var result = _serverConnectionSettings?.GetSettings();
                _view.PrintData(result?.Server, result?.Database);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }


        /// <summary>
        /// Проверка доступности сервера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="serverName">Адрес сервера</param>
        private void CheckServerConnection(Object? sender, string? serverName)
        {
            if (ServerPing(serverName, out string? answer))
                _view.ShowInfo(answer);
            else _view.ShowError(answer);
        }

        /// <summary>
        ///  ping адреса сервера
        /// </summary>
        /// <param name="serverName">Адрес сервера</param>
        /// <param name="answer">Ответ - сообщение, поясняющее результат операции ping</param>
        /// <returns>Результат проверки:
        /// true - сервер доступен,
        /// false - сервер не отвечает</returns>
        private bool ServerPing(string? serverName, out string? answer)
        {
            answer = null;

            if (string.IsNullOrEmpty(serverName))
            {
                answer = "Не задан адрес сервера!";
                return false;
            }

            Ping pingSender = new Ping();
            try
            {
                PingReply reply = pingSender.Send(serverName);

                switch (reply.Status)
                {
                    case IPStatus.Success:
                        answer = "Сервер доступен:"
                       + Environment.NewLine
                       + "Адрес: " + reply.Address.ToString()
                       + Environment.NewLine
                       + "Время на отправку и получения ответа (мс): " + reply.RoundtripTime;
                        return true;
                    case IPStatus.TimedOut:
                        answer = "Закончилось время ожидания ответа от сервера!"
                        + Environment.NewLine
                        + reply.Status;
                        return false;
                    default:

                        answer = "Сервер не доступен: "
                            + Environment.NewLine
                            + reply.Status;
                        return false;
                }
            }

            catch (PingException ex) when ((ex.InnerException as System.Net.Sockets.SocketException)!.ErrorCode == 11001)
            {
                answer = "Сервер не найден (узел не существует)!";
            }
            catch (PingException pe)
            {
                string innerMes = "";
                if (pe.InnerException != null) innerMes = pe.InnerException.Message;
                answer = "Ошибка при отправке сообщения: " + pe.Message + innerMes;
            }

            catch (Exception ex)
            {
                answer = "Ошибка при отправке сообщения: " + ex.Message;
            }

            return false;
        }

        /// <summary>
        /// Проверка наличия БД с таким названием на сервере
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private  async void CheckDb(Object? sender, (string? serverName, string? dBName) data)
        {
            if (!ServerPing(data.serverName, out string? answer))
            {
                _view.ShowError(answer);
                return;
            }
            var result =await CheckDbEnableWithWaitWindow(data);
            if (result) _view.ShowInfo("На сервере есть БД с таким названием");
            else _view.ShowInfo("Такой БД нет или она недоступна на текущий момент!");
        }

        /// <summary>
        /// Проверка налияия БД с заданным именем с выводом окна содержащим сообщение о необходимости подождать завершения операции
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Результат проверки наличия БД с заданным названием на сервере</returns>
        /// <exception cref="NullReferenceException"></exception>
        private async Task<bool> CheckDbEnableWithWaitWindow((string? serverName, string? dBName) data)
        {
            //пауза- время, которое мы даём на выполнение операции
            const int waitTime = 400;

            //время на которое показывется окно с предупреждением
            const int minDelayForShowWindows= 2000;

            var task = CheckIsDbEnableOnServerAsync(data); //запускаем проверку наличия БД с таким именем
            await Task.Delay(waitTime); //ждём, даём время на выполнение операции

            IWaitWindow? waitWindow=null;
            if (!task.IsCompleted) //если задача не завершена, т.е. waitTime  за мс не получен ответ от сервера
            {
                SynchronizationContext? sc= SynchronizationContext.Current; //получаем контекст текущего потока, для вывода в этом потоке окна с сообщением подождать

                waitWindow = Conteiner.GetInstance().GetClassInstance<IWaitWindow>();
                if (waitWindow == null) throw new NullReferenceException("Не получен экземпляр объекта " + nameof(IWaitWindow));
                var t= Task.Run(() => waitWindow.Run(sc));

                await Task.Delay(minDelayForShowWindows); //в любом случаи показываем окно в течении minDelayForShowWindows сек.
            }
            var result = await task;
            waitWindow?.CloseWindow();

            return result;
        }

        /// <summary>
        /// Проверка наличия БД с заданным именем на сервере
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Результат проверки:
        /// true - БД с заданным именем есть на сервере,
        /// false - БД с заданным именен нет на сервере</returns>
        private async Task<bool> CheckIsDbEnableOnServerAsync((string? serverName, string? dBName) data)
        {
            var options = DbContextOptionsFromNames.CreateDbContextOptions<MyDbContext>(data);

            using (var dbContext = new MyDbContext(options))
            {
                var task = dbContext.Database.CanConnectAsync();
                bool result = await task;
                if (result) return true;
                return false; ;
            }
        }

        /// <summary>
        /// Создать новую БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private async void CreateNewDb(Object? sender, (string? serverName, string? dBName) data)
        {
            if (!ServerPing(data.serverName, out string? answer))
            {
                _view.ShowError(answer);
                return;
            }

            var result =await CheckDbEnableWithWaitWindow(data);

            if (result)
            {
                if (!_view.ShowChoice("На сервере есть БД с таким названием!"
                    + Environment.NewLine
                    + " При создании новой БД все данные будут потеряны!"
                    + Environment.NewLine
                    + "Всё равно создать БД?"))
                    return;
            }

            var options = DbContextOptionsFromNames.CreateDbContextOptions<MyDbContext>(data);

            try
            {
                //ПЕРЕсоздать БД
                using (MyDbContext db = new MyDbContext(options))
                {
                    db.CreateNewDB();
                }

                //todo УДАЛИТЬ!!! заполняем БД исходными данными
                SaveInitializationDataInDB.SaveData(options);
                _view.ShowInfo("БД (" + data.serverName + ":" + data.dBName + ") создана");
            }
            catch (Exception ex)
            {
                string mes = "";
                if (ex.InnerException != null) mes = Environment.NewLine + "Внутреннее исключение: " + ex.InnerException.Message;

                _view.ShowError("При создании БД произошла ошибка:"
                    + Environment.NewLine
                    + ex.Message
                    + mes);
            }
        }

        /// <summary>
        /// Сохранить новые настройки подключения к серверу БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        private void SaveNewSetting(Object? sender, (string? serverName, string? dBName) data)
        {
            try
            {
                var result = _serverConnectionSettings?.SaveSetting(data.serverName, data.dBName);
                if (result == true) _view.ShowInfo("Настройки сохранены");
                RefreshDatasInView();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        /// <summary>
        /// Закрыть окно
        /// </summary>
        public void CloseViewWindow(object? sender, EventArgs args)
        {
            _view.CloseView();
        }
    }
}
