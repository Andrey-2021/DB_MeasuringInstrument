using AuthenticationLib;
using DbClassLibrary;
using ViewInterfaces;
using WinFormsAppDevicesAccounting.Windows;
using WordDocClassLibraryOpenXml;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Форма главного окна программы
    /// </summary>
    public partial class MainForm : BaseViewShowErrorAndWarning, IMainFormView
    {
        public event EventHandler ShowMeasuringInstrument;
        public event EventHandler ShowPasports;
        public event EventHandler ShowUnsuitability;
        public event EventHandler ShowСertificate;
        public event EventHandler ShowMovement;
        public event EventHandler ShowSummaries;
        public event EventHandler ShowReports;

        public event EventHandler ShowManual;

        //Меню Пользователи 
        public event EventHandler ShowUsers;
        // меню Настрйка
        public event EventHandler ChangingAdminLogin;
        public event EventHandler ChangingServerSettings;
        // меню Справка
        public event EventHandler ShowHelp;
        public event EventHandler ShowAboutProgram;
        
        public event EventHandler ShowCalibrationPeriod;
        public event EventHandler ShowDeviceType;
        public event EventHandler ShowManufacturer;
        public event EventHandler ShowMeasurementUnit;
        public event EventHandler ShowDepartment;
        public event EventHandler ShowDeviceState;
        public event EventHandler ShowCalibrators;

        public MainForm()
        {
            InitializeComponent();
        }

        public void ShowInfoAboutUser(string info)
        {
            toolStripStatusLabel2User.Text = info;
        }

        public void ShowInfoAboutDB(string info)
        {
            toolStripStatusLabel4dB.Text = info;
        }

        public void CloseMenu()
        {
            UsersToolStripMenuItem.Visible = false;
            SettingsToolStripMenuItem.Visible = false;
        }


        private void ManualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OnShowManual();
        }

        #region Меню База данных СИ - методы On...
        /// <summary>
        /// Показать БД
        /// </summary>
        private void OnShowDB()
        {
            ShowMeasuringInstrument?.Invoke(this, EventArgs.Empty);
        }

        private void OnShowCalibrationPeriod()
        {
            ShowCalibrationPeriod?.Invoke(this, EventArgs.Empty);
        }
        private void OnShowDeviceType()
        {
            ShowDeviceType?.Invoke(this, EventArgs.Empty);
        }
        private void OnShowManufacturer()
        {
            ShowManufacturer?.Invoke(this, EventArgs.Empty);
        }
        private void OnShowMeasurementUnit()
        {
            ShowMeasurementUnit?.Invoke(this, EventArgs.Empty);
        }
        private void OnShowDepartment()
        {
            ShowDepartment?.Invoke(this, EventArgs.Empty);
        }

        private void OnShowDeviceState()
        {
            ShowDeviceState?.Invoke(this, EventArgs.Empty);
        }

        private void OnShowCalibrators()
        {
            ShowCalibrators?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region Меню База данных СИ
        private void MeasuringInstrumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowDB();
        }

        private void CalibrationPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowCalibrationPeriod();
        }
        
        private void DeviceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowDeviceType();
        }

        private void ManufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowManufacturer();
        }

        private void MeasurementUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowMeasurementUnit();
        }

        private void DepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowDepartment();
        }

        private void допустимыеСостояниеСИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowDeviceState();
        }

        private void CalibratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowCalibrators();
        }

        #endregion

        #region Обработка Документы      
        /// <summary>
        /// Показать паспорт
        /// </summary>
        private void OnShowPasport()
        {
            ShowPasports?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Показать Извещения о непригодности
        /// </summary>
        private void OnShowUnsuitability()
        {
            ShowUnsuitability?.Invoke(this, EventArgs.Empty);
        }




        /// <summary>
        /// Показать Свидетельства о поверке
        /// </summary>
        private void OnShowCalibrationReports()
        {
            ShowСertificate?.Invoke(this, EventArgs.Empty);
        }




        /// <summary>
        /// Показать Накладные на перемещения
        /// </summary>
        private void OnShowMovement()
        {
            ShowMovement?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Показать сводки
        /// </summary>
        private void OnShowSummaries()
        {
            ShowSummaries?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Показать отчёты
        /// </summary>
        private void OnShowReports()
        {
            ShowReports?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Меню Справочник   
        /// <summary>
        /// Показать информацию
        /// </summary>
        private void OnShowManual()
        {
            ShowManual?.Invoke(this, EventArgs.Empty);
        }

        private void ManualToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OnShowManual();
        }
        #endregion

        #region Меню Документы
        private void PasportToolStripMenuItem_Click(object sender, EventArgs e)
        {//паспорта 
            OnShowPasport();
        }

        private void unsuitabilityToolStripMenuItem_Click(object sender, EventArgs e)
        { //Извещения о непригодности
            OnShowUnsuitability();
        }

        private void calibrationReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Свидетельства о поверке
            OnShowCalibrationReports();

        }

        private void movementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Накладные на перемещения
            OnShowMovement();
        }

        private void summariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Сводки
            OnShowSummaries();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Отчёты
            OnShowReports();

        }
        #endregion

        #region Меню Пользователи   

        /// <summary>
        /// Пользователи
        /// </summary>
        private void OnShowUsers()
        {
            ShowUsers?.Invoke(this, EventArgs.Empty);
        }
        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowUsers();
        }
        #endregion

        #region Меню Настройка   
        /// <summary>
        /// Смена логина и пароля администратора
        /// </summary>
        private void OnChangeAdminLogin()
        {
            ChangingAdminLogin?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Настройки Сервера БД
        /// </summary>
        private void OnServerSettings()
        {
            ChangingServerSettings?.Invoke(this, EventArgs.Empty);
        }


        private void ChangeAdminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {//Смена логина и пароля администратора
            OnChangeAdminLogin();
        }

        private void ServerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {//Настройка сервера БД
            OnServerSettings();
        }
        #endregion

        #region Меню Справка   
        /// <summary>
        /// Помощь
        /// </summary>
        private void OnShowHelp()
        {
            ShowHelp?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// О программе
        /// </summary>
        private void OnShowAboutProgram()
        {
            ShowAboutProgram?.Invoke(this, EventArgs.Empty);
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowAboutProgram();
        }

        private void HelpStripMenuItem_Click(object sender, EventArgs e)
        {
            OnShowHelp();
        }
        #endregion


        public void BlockWorkDbMenu()
        {
            DBToolStripMenuItem.Enabled = false;
            ManualToolStripMenuItem1.Enabled = false;
            DocumentsToolStripMenuItem.Enabled = false;
            UsersToolStripMenuItem.Enabled = false;
        }

        public void ActivateDbWorkMenu()
        {
            DBToolStripMenuItem.Enabled = true;
            ManualToolStripMenuItem1.Enabled = true;
            DocumentsToolStripMenuItem.Enabled = true;
            UsersToolStripMenuItem.Enabled = true;
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            OnShowHelp();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            OnShowAboutProgram();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            OnShowReports();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            OnShowSummaries();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            OnShowMovement();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            OnShowCalibrationReports();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            OnShowUnsuitability();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            OnShowPasport();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OnShowManual();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OnShowDB();
        }
    }
}