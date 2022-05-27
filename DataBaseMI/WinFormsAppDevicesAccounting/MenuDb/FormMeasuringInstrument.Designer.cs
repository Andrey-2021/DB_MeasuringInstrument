namespace WinFormsAppDevicesAccounting.Windows
{
    partial class FormMeasuringInstrument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeasuringInstrument));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button10Refresh = new System.Windows.Forms.Button();
            this.button9Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1DeviceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2ManufacturerNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3InventoryNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4DeviceType = new System.Windows.Forms.ComboBox();
            this.comboBox1Department = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1Now = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2Next = new System.Windows.Forms.DateTimePicker();
            this.comboBox6DeviceState = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox3Month = new System.Windows.Forms.ComboBox();
            this.checkBox3Month = new System.Windows.Forms.CheckBox();
            this.checkBox2Year = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1Year = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel5RecordNumber = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3RecordNumber = new System.Windows.Forms.Label();
            this.dataGridView1Data = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button10Certificate = new System.Windows.Forms.Button();
            this.button9Unsuitability = new System.Windows.Forms.Button();
            this.button8Moving = new System.Windows.Forms.Button();
            this.button7Repair = new System.Windows.Forms.Button();
            this.button6Calibration = new System.Windows.Forms.Button();
            this.button5Refresh = new System.Windows.Forms.Button();
            this.button4Del = new System.Windows.Forms.Button();
            this.button3Edit = new System.Windows.Forms.Button();
            this.button2AddNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Year)).BeginInit();
            this.tableLayoutPanel5RecordNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Data)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5RecordNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1Data, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1Exit, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 552);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1DeviceName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2ManufacturerNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox3InventoryNumber, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBox4DeviceType, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1Department, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1Now, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker2Next, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox6DeviceState, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label14, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(768, 186);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 4);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button10Refresh, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button9Clear, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 154);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(772, 29);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // button10Refresh
            // 
            this.button10Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10Refresh.Image = ((System.Drawing.Image)(resources.GetObject("button10Refresh.Image")));
            this.button10Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10Refresh.Location = new System.Drawing.Point(142, 3);
            this.button10Refresh.Name = "button10Refresh";
            this.button10Refresh.Size = new System.Drawing.Size(102, 23);
            this.button10Refresh.TabIndex = 11;
            this.button10Refresh.Text = "Найти СИ";
            this.button10Refresh.UseVisualStyleBackColor = true;
            this.button10Refresh.Click += new System.EventHandler(this.button10Refresh_Click);
            // 
            // button9Clear
            // 
            this.button9Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9Clear.Image = ((System.Drawing.Image)(resources.GetObject("button9Clear.Image")));
            this.button9Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9Clear.Location = new System.Drawing.Point(528, 3);
            this.button9Clear.Name = "button9Clear";
            this.button9Clear.Size = new System.Drawing.Size(102, 23);
            this.button9Clear.TabIndex = 12;
            this.button9Clear.Text = "Очистить";
            this.button9Clear.UseVisualStyleBackColor = true;
            this.button9Clear.Click += new System.EventHandler(this.button9Clear_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Наименованиеие прибора:";
            // 
            // textBox1DeviceName
            // 
            this.textBox1DeviceName.Location = new System.Drawing.Point(166, 3);
            this.textBox1DeviceName.Name = "textBox1DeviceName";
            this.textBox1DeviceName.Size = new System.Drawing.Size(209, 23);
            this.textBox1DeviceName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Заводской номер:";
            // 
            // textBox2ManufacturerNumber
            // 
            this.textBox2ManufacturerNumber.Location = new System.Drawing.Point(166, 32);
            this.textBox2ManufacturerNumber.Name = "textBox2ManufacturerNumber";
            this.textBox2ManufacturerNumber.Size = new System.Drawing.Size(209, 23);
            this.textBox2ManufacturerNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Инвентарный номер:";
            // 
            // textBox3InventoryNumber
            // 
            this.textBox3InventoryNumber.Location = new System.Drawing.Point(166, 61);
            this.textBox3InventoryNumber.Name = "textBox3InventoryNumber";
            this.textBox3InventoryNumber.Size = new System.Drawing.Size(209, 23);
            this.textBox3InventoryNumber.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Тип СИ:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Отдел (Местоположение):";
            // 
            // comboBox4DeviceType
            // 
            this.comboBox4DeviceType.FormattingEnabled = true;
            this.comboBox4DeviceType.Location = new System.Drawing.Point(166, 125);
            this.comboBox4DeviceType.Name = "comboBox4DeviceType";
            this.comboBox4DeviceType.Size = new System.Drawing.Size(209, 23);
            this.comboBox4DeviceType.TabIndex = 34;
            // 
            // comboBox1Department
            // 
            this.comboBox1Department.FormattingEnabled = true;
            this.comboBox1Department.Location = new System.Drawing.Point(166, 90);
            this.comboBox1Department.Name = "comboBox1Department";
            this.comboBox1Department.Size = new System.Drawing.Size(209, 23);
            this.comboBox1Department.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Дата поверки/калибровки:";
            // 
            // dateTimePicker1Now
            // 
            this.dateTimePicker1Now.Checked = false;
            this.dateTimePicker1Now.Location = new System.Drawing.Point(551, 3);
            this.dateTimePicker1Now.Name = "dateTimePicker1Now";
            this.dateTimePicker1Now.ShowCheckBox = true;
            this.dateTimePicker1Now.Size = new System.Drawing.Size(208, 23);
            this.dateTimePicker1Now.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Дата следующей поверки:";
            // 
            // dateTimePicker2Next
            // 
            this.dateTimePicker2Next.Checked = false;
            this.dateTimePicker2Next.Location = new System.Drawing.Point(551, 32);
            this.dateTimePicker2Next.Name = "dateTimePicker2Next";
            this.dateTimePicker2Next.ShowCheckBox = true;
            this.dateTimePicker2Next.Size = new System.Drawing.Size(208, 23);
            this.dateTimePicker2Next.TabIndex = 38;
            // 
            // comboBox6DeviceState
            // 
            this.comboBox6DeviceState.FormattingEnabled = true;
            this.comboBox6DeviceState.Location = new System.Drawing.Point(551, 125);
            this.comboBox6DeviceState.Name = "comboBox6DeviceState";
            this.comboBox6DeviceState.Size = new System.Drawing.Size(209, 23);
            this.comboBox6DeviceState.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(408, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Текущее состояние СИ:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel6.Controls.Add(this.comboBox3Month, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.checkBox3Month, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.checkBox2Year, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.numericUpDown1Year, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(381, 61);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(394, 58);
            this.tableLayoutPanel6.TabIndex = 42;
            // 
            // comboBox3Month
            // 
            this.comboBox3Month.Enabled = false;
            this.comboBox3Month.FormattingEnabled = true;
            this.comboBox3Month.Location = new System.Drawing.Point(197, 32);
            this.comboBox3Month.Name = "comboBox3Month";
            this.comboBox3Month.Size = new System.Drawing.Size(181, 23);
            this.comboBox3Month.TabIndex = 40;
            // 
            // checkBox3Month
            // 
            this.checkBox3Month.AutoSize = true;
            this.checkBox3Month.Location = new System.Drawing.Point(172, 32);
            this.checkBox3Month.Name = "checkBox3Month";
            this.checkBox3Month.Size = new System.Drawing.Size(19, 19);
            this.checkBox3Month.TabIndex = 41;
            this.checkBox3Month.Text = "checkBox1";
            this.checkBox3Month.UseVisualStyleBackColor = true;
            this.checkBox3Month.CheckedChanged += new System.EventHandler(this.checkBox3Month_CheckedChanged);
            // 
            // checkBox2Year
            // 
            this.checkBox2Year.AutoSize = true;
            this.checkBox2Year.Location = new System.Drawing.Point(172, 3);
            this.checkBox2Year.Name = "checkBox2Year";
            this.checkBox2Year.Size = new System.Drawing.Size(19, 19);
            this.checkBox2Year.TabIndex = 42;
            this.checkBox2Year.Text = "checkBox2";
            this.checkBox2Year.UseVisualStyleBackColor = true;
            this.checkBox2Year.CheckedChanged += new System.EventHandler(this.checkBox2Year_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Поверенные в году:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "и месяце:";
            // 
            // numericUpDown1Year
            // 
            this.numericUpDown1Year.Location = new System.Drawing.Point(197, 3);
            this.numericUpDown1Year.Maximum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown1Year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown1Year.Name = "numericUpDown1Year";
            this.numericUpDown1Year.Size = new System.Drawing.Size(181, 23);
            this.numericUpDown1Year.TabIndex = 44;
            this.numericUpDown1Year.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // tableLayoutPanel5RecordNumber
            // 
            this.tableLayoutPanel5RecordNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel5RecordNumber.AutoSize = true;
            this.tableLayoutPanel5RecordNumber.ColumnCount = 2;
            this.tableLayoutPanel5RecordNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5RecordNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5RecordNumber.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5RecordNumber.Controls.Add(this.label3RecordNumber, 1, 0);
            this.tableLayoutPanel5RecordNumber.Location = new System.Drawing.Point(3, 530);
            this.tableLayoutPanel5RecordNumber.Name = "tableLayoutPanel5RecordNumber";
            this.tableLayoutPanel5RecordNumber.RowCount = 1;
            this.tableLayoutPanel5RecordNumber.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5RecordNumber.Size = new System.Drawing.Size(113, 15);
            this.tableLayoutPanel5RecordNumber.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Всего записей:";
            // 
            // label3RecordNumber
            // 
            this.label3RecordNumber.AutoSize = true;
            this.label3RecordNumber.Location = new System.Drawing.Point(97, 0);
            this.label3RecordNumber.Name = "label3RecordNumber";
            this.label3RecordNumber.Size = new System.Drawing.Size(13, 15);
            this.label3RecordNumber.TabIndex = 1;
            this.label3RecordNumber.Text = "0";
            // 
            // dataGridView1Data
            // 
            this.dataGridView1Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1Data.Location = new System.Drawing.Point(3, 220);
            this.dataGridView1Data.Name = "dataGridView1Data";
            this.dataGridView1Data.ReadOnly = true;
            this.dataGridView1Data.RowTemplate.Height = 25;
            this.dataGridView1Data.Size = new System.Drawing.Size(633, 300);
            this.dataGridView1Data.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "СИ";
            // 
            // button1Exit
            // 
            this.button1Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Exit.Image = ((System.Drawing.Image)(resources.GetObject("button1Exit.Image")));
            this.button1Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Exit.Location = new System.Drawing.Point(647, 526);
            this.button1Exit.Name = "button1Exit";
            this.button1Exit.Size = new System.Drawing.Size(124, 23);
            this.button1Exit.TabIndex = 5;
            this.button1Exit.Text = "Закрыть";
            this.button1Exit.UseVisualStyleBackColor = true;
            this.button1Exit.Click += new System.EventHandler(this.button1Exit_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.button10Certificate, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.button9Unsuitability, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.button8Moving, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.button7Repair, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.button6Calibration, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.button5Refresh, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.button4Del, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.button3Edit, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.button2AddNew, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(647, 220);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 9;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(124, 300);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // button10Certificate
            // 
            this.button10Certificate.AutoSize = true;
            this.button10Certificate.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10Certificate.Location = new System.Drawing.Point(3, 266);
            this.button10Certificate.Name = "button10Certificate";
            this.button10Certificate.Size = new System.Drawing.Size(118, 28);
            this.button10Certificate.TabIndex = 16;
            this.button10Certificate.Text = "Свидет. о поверке";
            this.button10Certificate.UseVisualStyleBackColor = true;
            this.button10Certificate.Click += new System.EventHandler(this.button10Certificate_Click);
            // 
            // button9Unsuitability
            // 
            this.button9Unsuitability.AutoSize = true;
            this.button9Unsuitability.Location = new System.Drawing.Point(3, 220);
            this.button9Unsuitability.Name = "button9Unsuitability";
            this.button9Unsuitability.Size = new System.Drawing.Size(118, 40);
            this.button9Unsuitability.TabIndex = 15;
            this.button9Unsuitability.Text = "Извещение о непригодности";
            this.button9Unsuitability.UseVisualStyleBackColor = true;
            this.button9Unsuitability.Click += new System.EventHandler(this.button9Unsuitability_Click);
            // 
            // button8Moving
            // 
            this.button8Moving.AutoSize = true;
            this.button8Moving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8Moving.Location = new System.Drawing.Point(3, 189);
            this.button8Moving.Name = "button8Moving";
            this.button8Moving.Size = new System.Drawing.Size(118, 25);
            this.button8Moving.TabIndex = 14;
            this.button8Moving.Text = "Перемещение";
            this.button8Moving.UseVisualStyleBackColor = true;
            this.button8Moving.Click += new System.EventHandler(this.button8Moving_Click);
            // 
            // button7Repair
            // 
            this.button7Repair.AutoSize = true;
            this.button7Repair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7Repair.Location = new System.Drawing.Point(3, 158);
            this.button7Repair.Name = "button7Repair";
            this.button7Repair.Size = new System.Drawing.Size(118, 25);
            this.button7Repair.TabIndex = 13;
            this.button7Repair.Text = "Ремонт";
            this.button7Repair.UseVisualStyleBackColor = true;
            this.button7Repair.Click += new System.EventHandler(this.button7Repair_Click);
            // 
            // button6Calibration
            // 
            this.button6Calibration.AutoSize = true;
            this.button6Calibration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6Calibration.Location = new System.Drawing.Point(3, 127);
            this.button6Calibration.Name = "button6Calibration";
            this.button6Calibration.Size = new System.Drawing.Size(118, 25);
            this.button6Calibration.TabIndex = 12;
            this.button6Calibration.Text = "Калибровка";
            this.button6Calibration.UseVisualStyleBackColor = true;
            this.button6Calibration.Click += new System.EventHandler(this.button6Calibration_Click);
            // 
            // button5Refresh
            // 
            this.button5Refresh.AutoSize = true;
            this.button5Refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5Refresh.Image = ((System.Drawing.Image)(resources.GetObject("button5Refresh.Image")));
            this.button5Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5Refresh.Location = new System.Drawing.Point(3, 96);
            this.button5Refresh.Name = "button5Refresh";
            this.button5Refresh.Size = new System.Drawing.Size(118, 25);
            this.button5Refresh.TabIndex = 11;
            this.button5Refresh.Text = "Обновить";
            this.button5Refresh.UseVisualStyleBackColor = true;
            this.button5Refresh.Click += new System.EventHandler(this.button5Refresh_Click);
            // 
            // button4Del
            // 
            this.button4Del.AutoSize = true;
            this.button4Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4Del.Image = ((System.Drawing.Image)(resources.GetObject("button4Del.Image")));
            this.button4Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4Del.Location = new System.Drawing.Point(3, 65);
            this.button4Del.Name = "button4Del";
            this.button4Del.Size = new System.Drawing.Size(118, 25);
            this.button4Del.TabIndex = 10;
            this.button4Del.Text = "Удалить";
            this.button4Del.UseVisualStyleBackColor = true;
            this.button4Del.Click += new System.EventHandler(this.button4Del_Click);
            // 
            // button3Edit
            // 
            this.button3Edit.AutoSize = true;
            this.button3Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3Edit.Image = ((System.Drawing.Image)(resources.GetObject("button3Edit.Image")));
            this.button3Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3Edit.Location = new System.Drawing.Point(3, 34);
            this.button3Edit.Name = "button3Edit";
            this.button3Edit.Size = new System.Drawing.Size(118, 25);
            this.button3Edit.TabIndex = 9;
            this.button3Edit.Text = "Редактировать";
            this.button3Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3Edit.UseVisualStyleBackColor = true;
            this.button3Edit.Click += new System.EventHandler(this.button3Edit_Click);
            // 
            // button2AddNew
            // 
            this.button2AddNew.AutoSize = true;
            this.button2AddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2AddNew.Image = ((System.Drawing.Image)(resources.GetObject("button2AddNew.Image")));
            this.button2AddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2AddNew.Location = new System.Drawing.Point(3, 3);
            this.button2AddNew.Name = "button2AddNew";
            this.button2AddNew.Size = new System.Drawing.Size(118, 25);
            this.button2AddNew.TabIndex = 8;
            this.button2AddNew.Text = "Добавить";
            this.button2AddNew.UseVisualStyleBackColor = true;
            this.button2AddNew.Click += new System.EventHandler(this.button2AddNew_Click);
            // 
            // FormMeasuringInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(600, 444);
            this.Name = "FormMeasuringInstrument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Средства измерения";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Year)).EndInit();
            this.tableLayoutPanel5RecordNumber.ResumeLayout(false);
            this.tableLayoutPanel5RecordNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Data)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1Data;
        private Button button2AddNew;
        private Button button3Edit;
        private Button button4Del;
        private Button button5Refresh;
        private Label label1;
        private Button button1Exit;
        private Button button6Calibration;
        private Button button7Repair;
        private Button button8Moving;
        private Button button9Unsuitability;
        private Button button10Certificate;
        private TableLayoutPanel tableLayoutPanel5RecordNumber;
        private Label label2;
        private Label label3RecordNumber;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1DeviceName;
        private TextBox textBox2ManufacturerNumber;
        private TextBox textBox3InventoryNumber;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button10Refresh;
        private Button button9Clear;
        private Label label8;
        private ComboBox comboBox1Department;
        private Label label14;
        private ComboBox comboBox6DeviceState;
        private Label label12;
        private ComboBox comboBox4DeviceType;
        private Label label7;
        private DateTimePicker dateTimePicker1Now;
        private Label label9;
        private DateTimePicker dateTimePicker2Next;
        private Label label10;
        private ComboBox comboBox3Month;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private CheckBox checkBox3Month;
        private CheckBox checkBox2Year;
        private Label label6;
        private NumericUpDown numericUpDown1Year;
    }
}