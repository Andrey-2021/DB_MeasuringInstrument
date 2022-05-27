using AuthenticationLib;
using CommonClassLibrary;
using CommonInterface;
using ConteinerLibrary;
using HelpAndAboutClassLibrary;
using HelpAndAboutModelInterface;
using Presenters;
using ServerConfiguration;
using ViewInterfaces;
using ViewInterfaces.Common;
using ViewInterfaces.Documents;
using WinFormsAppDevicesAccounting.Documents;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RegistreViewTypes();
            ApplicationConfiguration.Initialize();
            MainFormPresenter mainFormPresenter = new MainFormPresenter(Conteiner.GetInstance().GetFormInstance<IMainFormView>());
            mainFormPresenter.Run();
        }

        /// <summary>
        /// Регистрация типов в контейнере
        /// </summary>
        static void RegistreViewTypes()
        {
            //Окно аутентификации при запуске программы
            Conteiner.GetInstance().RegisterForm<IPasswordView, FormPassword>();

            //Меню База данных СИ
            Conteiner.GetInstance().RegisterForm<IMeasuringInstrumentView, FormMeasuringInstrument>();
            Conteiner.GetInstance().RegisterForm<IMeasuringInstrumentAddOrEditView, FormMeasuringInstrumentAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<IManufacturerView, FormManufacturer>();
            Conteiner.GetInstance().RegisterForm<Manufacturer, FormManufacturerAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<ICalibrationPeriodView, FormCalibrationPeriod>();
            Conteiner.GetInstance().RegisterForm<CalibrationPeriod, FormCalibrationPeriodAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<IMeasurementUnitView, FormMeasurementUnit>();
            Conteiner.GetInstance().RegisterForm<MeasurementUnit, FormMeasurementUnitAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<IDeparmentView, FormDeparment>();
            Conteiner.GetInstance().RegisterForm<Department, FormDepartmentAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<IDeviceTypeView, FormDeviceType>();
            Conteiner.GetInstance().RegisterForm<DeviceType, FormDeviceTypeAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<IDeviceStateView, FormDeviceState>();
            Conteiner.GetInstance().RegisterForm<DeviceState, FormDeviceStateAddOrEdit>();
            // работа со СИ
            Conteiner.GetInstance().RegisterForm<IMainFormView, MainForm>();

            Conteiner.GetInstance().RegisterForm<IСertificateWorkView, FormСertificateWork>();
            Conteiner.GetInstance().RegisterForm<IСertificateWorkAddOrEditView, FormСertificateWorkAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<IUnsuitabilityWorkView, FormUnsuitabilityWork>();
            Conteiner.GetInstance().RegisterForm<IUnsuitabilityWorkAddOrEditView, FormUnsuitabilityWorkAddOrEdit>();


            Conteiner.GetInstance().RegisterForm<ICalibrationView, FormCalibration>();
            Conteiner.GetInstance().RegisterForm<ICalibrationAddOrEditView, FormCalibrationAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<IRepairView, FormRepair>();
            Conteiner.GetInstance().RegisterForm<IRepairAddOrEditView, FormRepairAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<IMIMovingView, FormMIMoving>();
            Conteiner.GetInstance().RegisterForm<IMovingAddOrEditView, FormMovingAddOrEdit>();

            Conteiner.GetInstance().RegisterForm<ICalibratorView, FormCalibrator>();
            Conteiner.GetInstance().RegisterForm<Calibrator, FormCalibratorAddOrEdit>();

            //Меню Справочник  
            Conteiner.GetInstance().RegisterForm<IManualView, FormManual>();
            

            //Меню Документы
            Conteiner.GetInstance().RegisterForm<IСertificateView, FormСertificate>();
            Conteiner.GetInstance().RegisterForm<IMovementView, FormMovement>();
            Conteiner.GetInstance().RegisterForm<IPasportsView, FormPasports>();
            Conteiner.GetInstance().RegisterForm<IUnsuitabilityView, FormUnsuitability>();
            Conteiner.GetInstance().RegisterForm<IReportsView, FormReport>();
            Conteiner.GetInstance().RegisterForm<ISummariesView, FormSummaries>();

            //Меню Пользователи  
            Conteiner.GetInstance().RegisterForm<IUserView, FormUser>();
            Conteiner.GetInstance().RegisterForm<User, FormUserAddOrEdit>();

            //Меню Настройка
            Conteiner.GetInstance().RegisterForm<IPasswordChangeView, FormPasswordChang>();
            Conteiner.GetInstance().ClassRegister<IAdminAuthentication, AdminAuthentication>();//Смена логина и пароля администратора
            Conteiner.GetInstance().RegisterForm<IServerSettingsView, FormServerSettings>();
            Conteiner.GetInstance().ClassRegister<IServerConnectionSettings, ServerConnectionSettings>(); //Настройка сервера БД

            //Меню Справка
            Conteiner.GetInstance().RegisterForm<IHelpView, FormHelp>();
            Conteiner.GetInstance().ClassRegister<IHelpAndAboutModel, HelpAndAboutModel>();

            //другие классы
            Conteiner.GetInstance().ClassRegister<ISelectFile, SelectFileInDisk>();
            Conteiner.GetInstance().ClassRegister<IWaitWindow, WaitWindow>();
            AddOrEditPresenterRegistration.RegistrationInContainer(Conteiner.GetInstance());
        }
    }
}