namespace WinFormsAppDevicesAccounting.Documents
{
    partial class FormSummaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSummaries));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2quarter = new System.Windows.Forms.RadioButton();
            this.radioButton1year = new System.Windows.Forms.RadioButton();
            this.numericUpDown1Year = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2Quarter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1Exit = new System.Windows.Forms.Button();
            this.button1SaveVer1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Year)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown1Year, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox2Quarter, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 449);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Выберите создаваемую сводку:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2quarter);
            this.groupBox1.Controls.Add(this.radioButton1year);
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox1, 3);
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчётный период";
            // 
            // radioButton2quarter
            // 
            this.radioButton2quarter.AutoSize = true;
            this.radioButton2quarter.Location = new System.Drawing.Point(14, 47);
            this.radioButton2quarter.Name = "radioButton2quarter";
            this.radioButton2quarter.Size = new System.Drawing.Size(133, 19);
            this.radioButton2quarter.TabIndex = 1;
            this.radioButton2quarter.TabStop = true;
            this.radioButton2quarter.Text = "квартальная сводка";
            this.radioButton2quarter.UseVisualStyleBackColor = true;
            this.radioButton2quarter.CheckedChanged += new System.EventHandler(this.radioButton2quarter_CheckedChanged);
            // 
            // radioButton1year
            // 
            this.radioButton1year.AutoSize = true;
            this.radioButton1year.Location = new System.Drawing.Point(14, 22);
            this.radioButton1year.Name = "radioButton1year";
            this.radioButton1year.Size = new System.Drawing.Size(108, 19);
            this.radioButton1year.TabIndex = 0;
            this.radioButton1year.TabStop = true;
            this.radioButton1year.Text = "годовая сводка";
            this.radioButton1year.UseVisualStyleBackColor = true;
            this.radioButton1year.CheckedChanged += new System.EventHandler(this.radioButton1year_CheckedChanged);
            // 
            // numericUpDown1Year
            // 
            this.numericUpDown1Year.Location = new System.Drawing.Point(429, 38);
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
            this.numericUpDown1Year.Size = new System.Drawing.Size(185, 23);
            this.numericUpDown1Year.TabIndex = 44;
            this.numericUpDown1Year.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Год:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Квартал:";
            // 
            // comboBox2Quarter
            // 
            this.comboBox2Quarter.FormattingEnabled = true;
            this.comboBox2Quarter.Location = new System.Drawing.Point(429, 67);
            this.comboBox2Quarter.Name = "comboBox2Quarter";
            this.comboBox2Quarter.Size = new System.Drawing.Size(185, 23);
            this.comboBox2Quarter.TabIndex = 47;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel1, 4);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1Exit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1SaveVer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 417);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 29);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // button1Exit
            // 
            this.button1Exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1Exit.Image = ((System.Drawing.Image)(resources.GetObject("button1Exit.Image")));
            this.button1Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Exit.Location = new System.Drawing.Point(483, 3);
            this.button1Exit.Name = "button1Exit";
            this.button1Exit.Size = new System.Drawing.Size(142, 23);
            this.button1Exit.TabIndex = 51;
            this.button1Exit.Text = "Закрыть";
            this.button1Exit.UseVisualStyleBackColor = true;
            this.button1Exit.Click += new System.EventHandler(this.button1Exit_Click);
            // 
            // button1SaveVer1
            // 
            this.button1SaveVer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1SaveVer1.Image = ((System.Drawing.Image)(resources.GetObject("button1SaveVer1.Image")));
            this.button1SaveVer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1SaveVer1.Location = new System.Drawing.Point(120, 3);
            this.button1SaveVer1.Name = "button1SaveVer1";
            this.button1SaveVer1.Size = new System.Drawing.Size(129, 23);
            this.button1SaveVer1.TabIndex = 50;
            this.button1SaveVer1.Text = "Создать";
            this.button1SaveVer1.UseVisualStyleBackColor = true;
            this.button1SaveVer1.Click += new System.EventHandler(this.button1SaveVer1_Click);
            // 
            // textBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.textBox1, 3);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(13, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(729, 285);
            this.textBox1.TabIndex = 53;
            // 
            // FormSummaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 449);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "FormSummaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сводка по СИ";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Year)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton radioButton2quarter;
        private RadioButton radioButton1year;
        private NumericUpDown numericUpDown1Year;
        private Label label10;
        private Label label12;
        private ComboBox comboBox2Quarter;
        private Button button1SaveVer1;
        private Button button1Exit;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
    }
}