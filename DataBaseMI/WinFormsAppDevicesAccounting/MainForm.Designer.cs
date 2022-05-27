namespace WinFormsAppDevicesAccounting
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MeasuringInstrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CalibrationPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MeasurementUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допустимыеСостояниеСИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalibratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManualToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsuitabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrationReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeAdminLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1UserHead = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2User = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3DbHead = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4dB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DBToolStripMenuItem,
            this.ManualToolStripMenuItem1,
            this.DocumentsToolStripMenuItem,
            this.UsersToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DBToolStripMenuItem
            // 
            this.DBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MeasuringInstrumentToolStripMenuItem,
            this.toolStripSeparator1,
            this.CalibrationPeriodToolStripMenuItem,
            this.DeviceTypeToolStripMenuItem,
            this.ManufacturerToolStripMenuItem,
            this.MeasurementUnitToolStripMenuItem,
            this.DepartmentToolStripMenuItem,
            this.допустимыеСостояниеСИToolStripMenuItem,
            this.CalibratorToolStripMenuItem});
            this.DBToolStripMenuItem.Name = "DBToolStripMenuItem";
            this.DBToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.DBToolStripMenuItem.Text = "База данных СИ";
            // 
            // MeasuringInstrumentToolStripMenuItem
            // 
            this.MeasuringInstrumentToolStripMenuItem.Name = "MeasuringInstrumentToolStripMenuItem";
            this.MeasuringInstrumentToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.MeasuringInstrumentToolStripMenuItem.Text = "БД Средств Измерения";
            this.MeasuringInstrumentToolStripMenuItem.Click += new System.EventHandler(this.MeasuringInstrumentToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // CalibrationPeriodToolStripMenuItem
            // 
            this.CalibrationPeriodToolStripMenuItem.Name = "CalibrationPeriodToolStripMenuItem";
            this.CalibrationPeriodToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.CalibrationPeriodToolStripMenuItem.Text = "Периодичность калибровки СИ";
            this.CalibrationPeriodToolStripMenuItem.Click += new System.EventHandler(this.CalibrationPeriodToolStripMenuItem_Click);
            // 
            // DeviceTypeToolStripMenuItem
            // 
            this.DeviceTypeToolStripMenuItem.Name = "DeviceTypeToolStripMenuItem";
            this.DeviceTypeToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.DeviceTypeToolStripMenuItem.Text = "Тип СИ";
            this.DeviceTypeToolStripMenuItem.Click += new System.EventHandler(this.DeviceTypeToolStripMenuItem_Click);
            // 
            // ManufacturerToolStripMenuItem
            // 
            this.ManufacturerToolStripMenuItem.Name = "ManufacturerToolStripMenuItem";
            this.ManufacturerToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.ManufacturerToolStripMenuItem.Text = "Завод изготовитель";
            this.ManufacturerToolStripMenuItem.Click += new System.EventHandler(this.ManufacturerToolStripMenuItem_Click);
            // 
            // MeasurementUnitToolStripMenuItem
            // 
            this.MeasurementUnitToolStripMenuItem.Name = "MeasurementUnitToolStripMenuItem";
            this.MeasurementUnitToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.MeasurementUnitToolStripMenuItem.Text = "Единицы измерения";
            this.MeasurementUnitToolStripMenuItem.Click += new System.EventHandler(this.MeasurementUnitToolStripMenuItem_Click);
            // 
            // DepartmentToolStripMenuItem
            // 
            this.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem";
            this.DepartmentToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.DepartmentToolStripMenuItem.Text = "Подразделения";
            this.DepartmentToolStripMenuItem.Click += new System.EventHandler(this.DepartmentToolStripMenuItem_Click);
            // 
            // допустимыеСостояниеСИToolStripMenuItem
            // 
            this.допустимыеСостояниеСИToolStripMenuItem.Name = "допустимыеСостояниеСИToolStripMenuItem";
            this.допустимыеСостояниеСИToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.допустимыеСостояниеСИToolStripMenuItem.Text = "Допустимые состояние СИ";
            this.допустимыеСостояниеСИToolStripMenuItem.Click += new System.EventHandler(this.допустимыеСостояниеСИToolStripMenuItem_Click);
            // 
            // CalibratorToolStripMenuItem
            // 
            this.CalibratorToolStripMenuItem.Name = "CalibratorToolStripMenuItem";
            this.CalibratorToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.CalibratorToolStripMenuItem.Text = "Поверитель";
            this.CalibratorToolStripMenuItem.Click += new System.EventHandler(this.CalibratorToolStripMenuItem_Click);
            // 
            // ManualToolStripMenuItem1
            // 
            this.ManualToolStripMenuItem1.Name = "ManualToolStripMenuItem1";
            this.ManualToolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.ManualToolStripMenuItem1.Text = "Справочник";
            this.ManualToolStripMenuItem1.Click += new System.EventHandler(this.ManualToolStripMenuItem1_Click_1);
            // 
            // DocumentsToolStripMenuItem
            // 
            this.DocumentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasportToolStripMenuItem,
            this.unsuitabilityToolStripMenuItem,
            this.calibrationReportsToolStripMenuItem,
            this.movementToolStripMenuItem,
            this.summariesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem";
            this.DocumentsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.DocumentsToolStripMenuItem.Text = "Документы";
            // 
            // PasportToolStripMenuItem
            // 
            this.PasportToolStripMenuItem.Name = "PasportToolStripMenuItem";
            this.PasportToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.PasportToolStripMenuItem.Text = "Паспорт";
            this.PasportToolStripMenuItem.Click += new System.EventHandler(this.PasportToolStripMenuItem_Click);
            // 
            // unsuitabilityToolStripMenuItem
            // 
            this.unsuitabilityToolStripMenuItem.Name = "unsuitabilityToolStripMenuItem";
            this.unsuitabilityToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.unsuitabilityToolStripMenuItem.Text = "Извещения о непригодности";
            this.unsuitabilityToolStripMenuItem.Click += new System.EventHandler(this.unsuitabilityToolStripMenuItem_Click);
            // 
            // calibrationReportsToolStripMenuItem
            // 
            this.calibrationReportsToolStripMenuItem.Name = "calibrationReportsToolStripMenuItem";
            this.calibrationReportsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.calibrationReportsToolStripMenuItem.Text = "Свидетельства о поверке";
            this.calibrationReportsToolStripMenuItem.Click += new System.EventHandler(this.calibrationReportsToolStripMenuItem_Click);
            // 
            // movementToolStripMenuItem
            // 
            this.movementToolStripMenuItem.Name = "movementToolStripMenuItem";
            this.movementToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.movementToolStripMenuItem.Text = "Накладные на перемещения";
            this.movementToolStripMenuItem.Click += new System.EventHandler(this.movementToolStripMenuItem_Click);
            // 
            // summariesToolStripMenuItem
            // 
            this.summariesToolStripMenuItem.Name = "summariesToolStripMenuItem";
            this.summariesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.summariesToolStripMenuItem.Text = "Сводки";
            this.summariesToolStripMenuItem.Click += new System.EventHandler(this.summariesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.reportsToolStripMenuItem.Text = "Отчёты";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.UsersToolStripMenuItem.Text = "Пользователи";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeAdminLoginToolStripMenuItem,
            this.ServerSettingsToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.SettingsToolStripMenuItem.Text = "Настройка";
            // 
            // ChangeAdminLoginToolStripMenuItem
            // 
            this.ChangeAdminLoginToolStripMenuItem.Name = "ChangeAdminLoginToolStripMenuItem";
            this.ChangeAdminLoginToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.ChangeAdminLoginToolStripMenuItem.Text = "Смена логина и пароля администратора";
            this.ChangeAdminLoginToolStripMenuItem.Click += new System.EventHandler(this.ChangeAdminLoginToolStripMenuItem_Click);
            // 
            // ServerSettingsToolStripMenuItem
            // 
            this.ServerSettingsToolStripMenuItem.Name = "ServerSettingsToolStripMenuItem";
            this.ServerSettingsToolStripMenuItem.Size = new System.Drawing.Size(299, 22);
            this.ServerSettingsToolStripMenuItem.Text = "Настройка сервера БД";
            this.ServerSettingsToolStripMenuItem.Click += new System.EventHandler(this.ServerSettingsToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpStripMenuItem,
            this.AboutProgramToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // HelpStripMenuItem
            // 
            this.HelpStripMenuItem.Name = "HelpStripMenuItem";
            this.HelpStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.HelpStripMenuItem.Text = "Помощь";
            this.HelpStripMenuItem.Click += new System.EventHandler(this.HelpStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1UserHead,
            this.toolStripStatusLabel2User,
            this.toolStripStatusLabel3DbHead,
            this.toolStripStatusLabel4dB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1UserHead
            // 
            this.toolStripStatusLabel1UserHead.Name = "toolStripStatusLabel1UserHead";
            this.toolStripStatusLabel1UserHead.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabel1UserHead.Text = "Пользователь:";
            // 
            // toolStripStatusLabel2User
            // 
            this.toolStripStatusLabel2User.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel2User.Name = "toolStripStatusLabel2User";
            this.toolStripStatusLabel2User.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel2User.Text = "User";
            // 
            // toolStripStatusLabel3DbHead
            // 
            this.toolStripStatusLabel3DbHead.Name = "toolStripStatusLabel3DbHead";
            this.toolStripStatusLabel3DbHead.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel3DbHead.Text = "БД:";
            // 
            // toolStripStatusLabel4dB
            // 
            this.toolStripStatusLabel4dB.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel4dB.Name = "toolStripStatusLabel4dB";
            this.toolStripStatusLabel4dB.Size = new System.Drawing.Size(21, 17);
            this.toolStripStatusLabel4dB.Text = "dB";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripSeparator4,
            this.toolStripButton10,
            this.toolStripButton17});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Средства измерения";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Справочник. \r\nВся информация по СИ";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.ToolTipText = "Распечатка паспорта на СИ\r\n\r\n";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "N";
            this.toolStripButton5.ToolTipText = "Распечатка извещения о непригодности СИ";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.ToolTipText = "Распечатка свидетельства о поверке\r\n";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.ToolTipText = "Распечатка накладной на перемещение\r\n";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.ToolTipText = "Распечатка сводки по СИ";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "toolStripButton9";
            this.toolStripButton9.ToolTipText = "Распечатка отчёта по СИ";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "toolStripButton10";
            this.toolStripButton10.ToolTipText = "Информация о программе";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "toolStripButton17";
            this.toolStripButton17.ToolTipText = "Помощь";
            this.toolStripButton17.Click += new System.EventHandler(this.toolStripButton17_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 400);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "БД СИ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem DBToolStripMenuItem;
        private ToolStripMenuItem DocumentsToolStripMenuItem;
        private ToolStripMenuItem UsersToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem HelpStripMenuItem;
        private ToolStripMenuItem AboutProgramToolStripMenuItem;
        private ToolStripMenuItem ManualToolStripMenuItem1;
        private ToolStripMenuItem MeasuringInstrumentToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem CalibrationPeriodToolStripMenuItem;
        private ToolStripMenuItem DeviceTypeToolStripMenuItem;
        private ToolStripMenuItem ManufacturerToolStripMenuItem;
        private ToolStripMenuItem MeasurementUnitToolStripMenuItem;
        private ToolStripMenuItem DepartmentToolStripMenuItem;
        private ToolStripMenuItem допустимыеСостояниеСИToolStripMenuItem;
        private ToolStripMenuItem CalibratorToolStripMenuItem;
        private ToolStripMenuItem PasportToolStripMenuItem;
        private ToolStripMenuItem unsuitabilityToolStripMenuItem;
        private ToolStripMenuItem calibrationReportsToolStripMenuItem;
        private ToolStripMenuItem movementToolStripMenuItem;
        private ToolStripMenuItem summariesToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem SettingsToolStripMenuItem;
        private ToolStripMenuItem ChangeAdminLoginToolStripMenuItem;
        private ToolStripMenuItem ServerSettingsToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1UserHead;
        private ToolStripStatusLabel toolStripStatusLabel2User;
        private ToolStripStatusLabel toolStripStatusLabel3DbHead;
        private ToolStripStatusLabel toolStripStatusLabel4dB;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton10;
        private ToolStripButton toolStripButton17;
    }
}