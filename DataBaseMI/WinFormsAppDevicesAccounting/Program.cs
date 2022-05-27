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
        /// ����������� ����� � ����������
        /// </summary>
        static void RegistreViewTypes()
        {
            //���� �������������� ��� ������� ���������
            Conteiner.GetInstance().RegisterForm<IPasswordView, FormPassword>();

            //���� ���� ������ ��
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
            // ������ �� ��
            Conteiner.GetInstance().RegisterForm<IMainFormView, MainForm>();

            Conteiner.GetInstance().RegisterForm<I�ertificateWorkView, Form�ertificateWork>();
            Conteiner.GetInstance().RegisterForm<I�ertificateWorkAddOrEditView, Form�ertificateWorkAddOrEdit>();

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

            //���� ����������  
            Conteiner.GetInstance().RegisterForm<IManualView, FormManual>();
            

            //���� ���������
            Conteiner.GetInstance().RegisterForm<I�ertificateView, Form�ertificate>();
            Conteiner.GetInstance().RegisterForm<IMovementView, FormMovement>();
            Conteiner.GetInstance().RegisterForm<IPasportsView, FormPasports>();
            Conteiner.GetInstance().RegisterForm<IUnsuitabilityView, FormUnsuitability>();
            Conteiner.GetInstance().RegisterForm<IReportsView, FormReport>();
            Conteiner.GetInstance().RegisterForm<ISummariesView, FormSummaries>();

            //���� ������������  
            Conteiner.GetInstance().RegisterForm<IUserView, FormUser>();
            Conteiner.GetInstance().RegisterForm<User, FormUserAddOrEdit>();

            //���� ���������
            Conteiner.GetInstance().RegisterForm<IPasswordChangeView, FormPasswordChang>();
            Conteiner.GetInstance().ClassRegister<IAdminAuthentication, AdminAuthentication>();//����� ������ � ������ ��������������
            Conteiner.GetInstance().RegisterForm<IServerSettingsView, FormServerSettings>();
            Conteiner.GetInstance().ClassRegister<IServerConnectionSettings, ServerConnectionSettings>(); //��������� ������� ��

            //���� �������
            Conteiner.GetInstance().RegisterForm<IHelpView, FormHelp>();
            Conteiner.GetInstance().ClassRegister<IHelpAndAboutModel, HelpAndAboutModel>();

            //������ ������
            Conteiner.GetInstance().ClassRegister<ISelectFile, SelectFileInDisk>();
            Conteiner.GetInstance().ClassRegister<IWaitWindow, WaitWindow>();
            AddOrEditPresenterRegistration.RegistrationInContainer(Conteiner.GetInstance());
        }
    }
}