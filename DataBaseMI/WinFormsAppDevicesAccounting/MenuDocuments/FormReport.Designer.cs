namespace WinFormsAppDevicesAccounting
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4week = new System.Windows.Forms.RadioButton();
            this.radioButton3month = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5week = new System.Windows.Forms.Label();
            this.textBox4Year = new System.Windows.Forms.TextBox();
            this.textBox5Month = new System.Windows.Forms.TextBox();
            this.textBox6Week = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1SaveVer1 = new System.Windows.Forms.Button();
            this.button1Exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.monthCalendar1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(808, 476);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Заводской номер:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButton4week);
            this.groupBox1.Controls.Add(this.radioButton3month);
            this.groupBox1.Location = new System.Drawing.Point(60, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 77);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчётный период";
            // 
            // radioButton4week
            // 
            this.radioButton4week.AutoSize = true;
            this.radioButton4week.Location = new System.Drawing.Point(14, 47);
            this.radioButton4week.Name = "radioButton4week";
            this.radioButton4week.Size = new System.Drawing.Size(119, 19);
            this.radioButton4week.TabIndex = 3;
            this.radioButton4week.TabStop = true;
            this.radioButton4week.Text = "недельный отчёт";
            this.radioButton4week.UseVisualStyleBackColor = true;
            this.radioButton4week.CheckedChanged += new System.EventHandler(this.radioButton4week_CheckedChanged);
            // 
            // radioButton3month
            // 
            this.radioButton3month.AutoSize = true;
            this.radioButton3month.Location = new System.Drawing.Point(14, 22);
            this.radioButton3month.Name = "radioButton3month";
            this.radioButton3month.Size = new System.Drawing.Size(115, 19);
            this.radioButton3month.TabIndex = 2;
            this.radioButton3month.TabStop = true;
            this.radioButton3month.Text = "месячный отчёт";
            this.radioButton3month.UseVisualStyleBackColor = true;
            this.radioButton3month.CheckedChanged += new System.EventHandler(this.radioButton3month_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar1.Location = new System.Drawing.Point(319, 44);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.tableLayoutPanel2.SetRowSpan(this.monthCalendar1, 2);
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5week, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox4Year, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5Month, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox6Week, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 121);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 122);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(93, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отчётный период:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Год:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Месяц:";
            // 
            // label5week
            // 
            this.label5week.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5week.AutoSize = true;
            this.label5week.Location = new System.Drawing.Point(20, 100);
            this.label5week.Name = "label5week";
            this.label5week.Size = new System.Drawing.Size(74, 15);
            this.label5week.TabIndex = 3;
            this.label5week.Text = "Дни недели:";
            // 
            // textBox4Year
            // 
            this.textBox4Year.Location = new System.Drawing.Point(100, 38);
            this.textBox4Year.Name = "textBox4Year";
            this.textBox4Year.ReadOnly = true;
            this.textBox4Year.Size = new System.Drawing.Size(163, 23);
            this.textBox4Year.TabIndex = 4;
            // 
            // textBox5Month
            // 
            this.textBox5Month.Location = new System.Drawing.Point(100, 67);
            this.textBox5Month.Name = "textBox5Month";
            this.textBox5Month.ReadOnly = true;
            this.textBox5Month.Size = new System.Drawing.Size(163, 23);
            this.textBox5Month.TabIndex = 5;
            // 
            // textBox6Week
            // 
            this.textBox6Week.Location = new System.Drawing.Point(100, 96);
            this.textBox6Week.Name = "textBox6Week";
            this.textBox6Week.ReadOnly = true;
            this.textBox6Week.Size = new System.Drawing.Size(163, 23);
            this.textBox6Week.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1Exit, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1SaveVer1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 429);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(782, 44);
            this.tableLayoutPanel3.TabIndex = 54;
            // 
            // button1SaveVer1
            // 
            this.button1SaveVer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1SaveVer1.AutoSize = true;
            this.button1SaveVer1.Image = ((System.Drawing.Image)(resources.GetObject("button1SaveVer1.Image")));
            this.button1SaveVer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1SaveVer1.Location = new System.Drawing.Point(145, 9);
            this.button1SaveVer1.Name = "button1SaveVer1";
            this.button1SaveVer1.Size = new System.Drawing.Size(101, 25);
            this.button1SaveVer1.TabIndex = 50;
            this.button1SaveVer1.Text = "Создать";
            this.button1SaveVer1.UseVisualStyleBackColor = true;
            this.button1SaveVer1.Click += new System.EventHandler(this.button1SaveVer1_Click);
            // 
            // button1Exit
            // 
            this.button1Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1Exit.Image = ((System.Drawing.Image)(resources.GetObject("button1Exit.Image")));
            this.button1Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Exit.Location = new System.Drawing.Point(536, 9);
            this.button1Exit.Name = "button1Exit";
            this.button1Exit.Size = new System.Drawing.Size(101, 25);
            this.button1Exit.TabIndex = 51;
            this.button1Exit.Text = "Закрыть";
            this.button1Exit.UseVisualStyleBackColor = true;
            this.button1Exit.Click += new System.EventHandler(this.button1Exit_Click);
            // 
            // textBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(13, 249);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(782, 174);
            this.textBox1.TabIndex = 12;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 476);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отчёты по СИ";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton radioButton4week;
        private RadioButton radioButton3month;
        private Button button1SaveVer1;
        private Button button1Exit;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5week;
        private TextBox textBox4Year;
        private TextBox textBox5Month;
        private TextBox textBox6Week;
        private TableLayoutPanel tableLayoutPanel3;
    }
}