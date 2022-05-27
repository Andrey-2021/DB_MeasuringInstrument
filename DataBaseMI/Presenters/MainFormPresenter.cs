using CommonClassLibrary;
using CommonInterface;
using ConteinerLibrary;
using DbClassLibrary;
using HelpAndAboutModelInterface;
using Microsoft.EntityFrameworkCore;
using Presenters.Common;
using ViewInterfaces;
using ViewInterfaces.Documents;

namespace Presenters
{
    /// <summary>
    /// Presenter главного окна
    /// </summary>
    public class MainFormPresenter : IPresenter
    {
        private readonly IMainFormView _view; //View этого Presenter

        /// <summary>
        /// Вошедший пользователь
        /// </summary>
        private User? loggedUser = null;

        /// <summary>
        /// DbContextOptions (настройки) для подключения к БД
        /// </summary>
        DbContextOptions? dbOption;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainFormPresenter(IMainFormView? view)
        {
            if (view == null)
            {
                throw new ArgumentNullException("Отсутствует View");
            }
            _view = view;
            //меню БД
            _view.ShowMeasuringInstrument += ShowMeasuringInstrument; //БД Средств Измерения
            _view.ShowCalibrationPeriod += ShowCalibrationPeriod;   //Периодичность калибровки приборов
            _view.ShowDeviceType += ShowDeviceType;                 //Тип СИ
            _view.ShowManufacturer += ShowManufacturer;             //Завод изготовитель
            _view.ShowMeasurementUnit += ShowMeasurementUnit;       //Единица измерения
            _view.ShowDepartment += ShowDepartment;                 //Подразделение
            _view.ShowDeviceState += ShowDeviceState;               //Допустимые состояние СИ
            _view.ShowCalibrators += ShowCalibrators;               //Поверитель
            //меню Справочник
            _view.ShowManual += ShowManual;
            //меню Документы
            _view.ShowPasports += ShowPasports;             //паспорт
            _view.ShowUnsuitability += ShowUnsuitability;   //Извещения о непригодности
            _view.ShowСertificate += ShowСertificate;       //Свидетельства о поверке
            _view.ShowMovement += ShowMovement;             //Накладные на перемещения
            _view.ShowSummaries += ShowSummaries;           //Сводки
            _view.ShowReports += ShowReports;               //Отчёты
            //Меню пользователи
            _view.ShowUsers += ShowUsers;
            //Меню Настройка
            _view.ChangingAdminLogin += ChangAdminLogin;
            _view.ChangingServerSettings += ChangServerSettings;
            //меню Справка
            _view.ShowHelp += ShowHelp;
            _view.ShowAboutProgram += ShowAboutProgram;

            SetDbContextOptions();
        }

        public void Run()
        {

            if (EnterPassword())
            {
                ShowInfoAboutUser();
                _view.ShowView();
            }

            //_view.ShowView();
        }

        /// <summary>
        /// устновка DbContextOptions
        /// </summary>
        /// <exception cref="NullReferenceException"></exception>
        void SetDbContextOptions()
        {
            var serverConnectionSettings = Conteiner.GetInstance().GetClassInstance<IServerConnectionSettings>();
            if (serverConnectionSettings == null) throw new NullReferenceException("Отсутствует зарегистрированный класс для " + nameof(IServerConnectionSettings));

            try
            {
                dbOption = serverConnectionSettings.GetDbContextOptionsBuilder<MyDbContext>();
                var names = serverConnectionSettings.GetSettings();
                ShowInfoAboutDb(names);
                _view.ActivateDbWorkMenu();
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
                dbOption = DbContextOptionsFromNames.CreateDbContextOptions<MyDbContext>(null);
                ShowInfoAboutDb(null);
                _view.BlockWorkDbMenu();
            }
        }

        /// <summary>
        /// Вывод информайии о вошедшем пользователе
        /// </summary>
        void ShowInfoAboutUser()
        {
            if (loggedUser == null) _view.ShowInfoAboutUser("");
            _view.ShowInfoAboutUser(loggedUser?.Surname + loggedUser?.Name);
        }

        /// <summary>
        /// Вывод информации о БД с которой работаем
        /// </summary>
        void ShowInfoAboutDb((string? serverName, string? databaseName)? info)
        {
            var serverConnectionSettings = Conteiner.GetInstance().GetClassInstance<IServerConnectionSettings>();
            _view.ShowInfoAboutDB(info?.serverName + ":" + info?.databaseName);
        }

        /// <summary>
        /// Показать окно с аутентификацией
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="InvalidDataException"></exception>
        private bool EnterPassword()
        {
            var view = Conteiner.GetInstance().GetFormInstance<IPasswordView>(); //Запрашиваем View из контейнера
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IPasswordView));

            var dbContext = new MyDbContext(dbOption);
            AuthenticationPresenter passwordPresenter = new AuthenticationPresenter(view, dbContext); //Создаём Presenter
            passwordPresenter.Run(); //Передаём управление в Presenter
            
            loggedUser = passwordPresenter.LoggedUser;

            switch (passwordPresenter.Login)
            {
                case EnumAuthenticationResult.admin:
                    return true;
                case EnumAuthenticationResult.user:
                    _view.CloseMenu();
                    return true;
                case EnumAuthenticationResult.off:
                    return false;
                default:
                    throw new InvalidDataException("Неизвестный результат: " + passwordPresenter.Login.ToString());
            }
        }

        /// <summary>
        /// Показать БД
        /// </summary>
        private void ShowMeasuringInstrument(Object? obj, EventArgs args)
        {
            var view = Conteiner.GetInstance().GetFormInstance<IMeasuringInstrumentView>(); //Запрашиваем View из контейнера
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IMeasuringInstrumentView));

            MeasuringInstrumentPresenter userPresenter = new MeasuringInstrumentPresenter(view, dbOption); //Создаём Presenter
            userPresenter.Run();//Передаём управление в Presenter
        }

        /// <summary>
        /// Поверители/Калибровщики
        /// </summary>
        private void ShowCalibrators(Object? obj, EventArgs args)
        {
            TransferControlToPresenter<ICalibratorView, Calibrator>();
        }

        #region Меню База данных СИ
        /// <summary>
        /// Показать Периоды калибровки
        /// </summary>
        private void ShowCalibrationPeriod(Object? obj, EventArgs args)
        {
            TransferControlToPresenter<ICalibrationPeriodView, CalibrationPeriod>();
        }

        /// <summary>
        /// Показать  Типы СИ
        /// </summary>
        private void ShowDeviceType(Object? obj, EventArgs args)
        {
            TransferControlToPresenter<IDeviceTypeView, DeviceType>();
        }

        /// <summary>
        /// Показать Заводы изготовители
        /// </summary>
        private void ShowManufacturer(Object? obj, EventArgs args)
        {
            TransferControlToPresenter<IManufacturerView, Manufacturer>();
        }

        /// <summary>
        /// Показать Единицы измерения
        /// </summary>
        private void ShowMeasurementUnit(Object? obj, EventArgs args)
        {
            TransferControlToPresenter<IMeasurementUnitView, MeasurementUnit>();
        }

        /// <summary>
        /// Показать Подразделения/Местоположения
        /// </summary>
        private void ShowDepartment(Object? obj, EventArgs args)
        {
            TransferControlToPresenter<IDeparmentView, Department>();
        }


        /// <summary>
        /// Показать Список допустимых состояний СИ
        /// </summary>
        private void ShowDeviceState(Object? obj, EventArgs args)
        {
            TransferControlToPresenter<IDeviceStateView, DeviceState>();
        }

        #endregion

        #region Меню Справочник  
        /// <summary>
        /// Показать информацию о СИ
        /// </summary>
        private void ShowManual(Object? obj, EventArgs args)
        {
            var dbContext = new MyDbContext(dbOption);
            ManualPresenter userPresenter =new ManualPresenter(Conteiner.GetInstance().GetFormInstance<IManualView>()!, dbContext);
            userPresenter.Run();
        }
        #endregion

        #region Меню Документы
        /// <summary>
        /// Показать паспорт
        /// </summary>
        private void ShowPasports(Object? obj, EventArgs args)
        {
            var dbContext = new MyDbContext(dbOption);
            PasportsPresenter pasportsPresenter =new PasportsPresenter(Conteiner.GetInstance().GetFormInstance<IPasportsView>(), dbContext);
            pasportsPresenter.Run();
        }

        /// <summary>
        /// Показать документы
        /// </summary>
        private void ShowСertificate(Object? obj, EventArgs args)
        {
            var dbContext = new MyDbContext(dbOption);
            СertificatePresenter calibrationReportsPresenter =new СertificatePresenter(Conteiner.GetInstance().GetFormInstance<IСertificateView>(), dbContext);
            calibrationReportsPresenter.Run();
        }

        /// <summary>
        /// Показать документы
        /// </summary>
        private void ShowUnsuitability(Object? obj, EventArgs args)
        {
            var dbContext = new MyDbContext(dbOption);
            UnsuitabilityPresenter unsuitabilityPresenter =new UnsuitabilityPresenter(Conteiner.GetInstance().GetFormInstance<IUnsuitabilityView>(), dbContext);
            unsuitabilityPresenter.Run();
        }

        /// <summary>
        /// Показать документы
        /// </summary>
        private void ShowMovement(Object? obj, EventArgs args)
        {
            var dbContext = new MyDbContext(dbOption);
            MovementPresenter movementPresenter =new MovementPresenter(Conteiner.GetInstance().GetFormInstance<IMovementView>(), dbContext);
            movementPresenter.Run();
        }

        /// <summary>
        /// Показать документы
        /// </summary>
        private void ShowSummaries(Object? obj, EventArgs args)
        {
            var dbContext = new MyDbContext(dbOption);
            //SummariesPresenter summariesPresenter =new SummariesPresenter(Conteiner.GetInstance().GetFormInstance<ISummariesView>(), dbOption);
            //summariesPresenter.Run();

            ReportsPresenter reportsPresenter = new ReportsPresenter(Conteiner.GetInstance().GetFormInstance<ISummariesView>(), dbOption);
            reportsPresenter.Run();

        }

        /// <summary>
        /// Показать документы
        /// </summary>
        private void ShowReports(Object? obj, EventArgs args)
        {
            var dbContext = new MyDbContext(dbOption);
            ReportsPresenter reportsPresenter =new ReportsPresenter(Conteiner.GetInstance().GetFormInstance<IReportsView>(), dbOption);
            reportsPresenter.Run();
        }
        #endregion

        #region Меню Пользователи  
        /// <summary>
        /// Пользователи
        /// </summary>
        private void ShowUsers(Object? obj, EventArgs args)
        {
            UserPresenter presenter = new UserPresenter(Conteiner.GetInstance().GetFormInstance<IUserView>(), dbOption);
            presenter.Run();
        }
        #endregion

        #region Меню Настройка 
        
        /// <summary>
        /// Смена логина и пароля администратора
        /// </summary>
        private void ChangAdminLogin(Object? obj, EventArgs args)
        {
            var view = Conteiner.GetInstance().GetFormInstance<IPasswordChangeView>();
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IPasswordChangeView));

            var adminAuthentication = Conteiner.GetInstance().GetClassInstance<IAdminAuthentication>();
            if (adminAuthentication == null) throw new NullReferenceException("Отсутствует класс выполняющий аутинтификацию администратора, реальзующий " + nameof(IAdminAuthentication));

            PasswordChangePresenter changePassword = new PasswordChangePresenter(view, adminAuthentication);
            changePassword.Run();
        }

        /// <summary>
        /// Поменять настройки подключения к серверу
        /// </summary>
        private void ChangServerSettings(Object? obj, EventArgs args)
        {
            var view = Conteiner.GetInstance().GetFormInstance<IServerSettingsView>();
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IServerSettingsView));

            var serverConnectionSettings = Conteiner.GetInstance().GetClassInstance<IServerConnectionSettings>();
            if (serverConnectionSettings == null) throw new NullReferenceException("Отсутствует зарегистрированный класс для" + nameof(IServerConnectionSettings));

            ServerSettingsPresenter serverSettings = new ServerSettingsPresenter(view, serverConnectionSettings);
            serverSettings.Run();
            SetDbContextOptions();
        }
        #endregion

        #region Меню Справка 
        /// <summary>
        /// Помощь
        /// </summary>
        private void ShowHelp(Object? obj, EventArgs args)
        {
            var view = Conteiner.GetInstance().GetFormInstance<IHelpView>();
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IHelpView));

            var model = Conteiner.GetInstance().GetClassInstance<IHelpAndAboutModel>(WorkMode.help);
            if (model == null) throw new NullReferenceException("Отсутствует зарегистророванный класс, реализующий " + nameof(IHelpAndAboutModel) + " интерфейс");

            HelpPresenter helpPresenter = new HelpPresenter(view, model, WorkMode.help);
            helpPresenter.Run();
        }

        /// <summary>
        /// О программе
        /// </summary>
        private void ShowAboutProgram(Object? obj, EventArgs args)
        {
            var view = Conteiner.GetInstance().GetFormInstance<IHelpView>();
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IHelpView));

            var model = Conteiner.GetInstance().GetClassInstance<IHelpAndAboutModel>(WorkMode.about);
            if (model == null) throw new NullReferenceException("Отсутствует зарегистророванный класс, реализующий " + nameof(IHelpAndAboutModel) + " интерфейс");

            HelpPresenter helpPresenter = new HelpPresenter(view, model, WorkMode.about);
            helpPresenter.Run();
        }
        #endregion

        /// <summary>
        /// Передать управление другому Presenter-у
        /// </summary>
        /// <typeparam name="V">View</typeparam>
        /// <typeparam name="T">тип класса с которым работаем</typeparam>
        void TransferControlToPresenter<V, T>()
               where V : IDbBaseView<T>
               where T : class, ICloneable
        {
            var view = Conteiner.GetInstance().GetFormInstance<V>(); //Создать View
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(V));
            var presenter = new BasePresenter<T>(view, dbOption); //Создаём Presener
            presenter.Run(); //Передаём управление в Presenter
        }
    }
}