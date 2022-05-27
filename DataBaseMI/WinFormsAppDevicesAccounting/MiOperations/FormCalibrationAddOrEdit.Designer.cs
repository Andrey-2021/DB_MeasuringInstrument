namespace WinFormsAppDevicesAccounting
{
    partial class FormCalibrationAddOrEdit
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3Topic = new System.Windows.Forms.Label();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.button1Save = new System.Windows.Forms.Button();
            this.dateTimePicker1Now = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3Rezult = new System.Windows.Forms.TextBox();
            this.comboBox1Calibrator = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2Next = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1NextCalibration = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3Topic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2Cancel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button1Save, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1Now, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox3Rezult, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1Calibrator, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker2Next, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1NextCalibration, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 228);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label3Topic
            // 
            this.label3Topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3Topic.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3Topic, 2);
            this.label3Topic.Location = new System.Drawing.Point(225, 10);
            this.label3Topic.Margin = new System.Windows.Forms.Padding(10);
            this.label3Topic.Name = "label3Topic";
            this.label3Topic.Size = new System.Drawing.Size(211, 15);
            this.label3Topic.TabIndex = 4;
            this.label3Topic.Text = "Ввод данных о поверке (калибровке)";
            // 
            // button2Cancel
            // 
            this.button2Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2Cancel.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.exit;
            this.button2Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2Cancel.Location = new System.Drawing.Point(389, 202);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(111, 23);
            this.button2Cancel.TabIndex = 19;
            this.button2Cancel.Text = "Закрыть";
            this.button2Cancel.UseVisualStyleBackColor = true;
            this.button2Cancel.Click += new System.EventHandler(this.button2Cancel_Click);
            // 
            // button1Save
            // 
            this.button1Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1Save.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.save;
            this.button1Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Save.Location = new System.Drawing.Point(59, 202);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(111, 23);
            this.button1Save.TabIndex = 18;
            this.button1Save.Text = "Сохранить";
            this.button1Save.UseVisualStyleBackColor = true;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // dateTimePicker1Now
            // 
            this.dateTimePicker1Now.Location = new System.Drawing.Point(232, 38);
            this.dateTimePicker1Now.Name = "dateTimePicker1Now";
            this.dateTimePicker1Now.Size = new System.Drawing.Size(238, 23);
            this.dateTimePicker1Now.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата поверки/калибровки:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "результат калибровки:";
            // 
            // textBox3Rezult
            // 
            this.textBox3Rezult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3Rezult.Location = new System.Drawing.Point(232, 67);
            this.textBox3Rezult.Name = "textBox3Rezult";
            this.textBox3Rezult.Size = new System.Drawing.Size(404, 23);
            this.textBox3Rezult.TabIndex = 12;
            // 
            // comboBox1Calibrator
            // 
            this.comboBox1Calibrator.FormattingEnabled = true;
            this.comboBox1Calibrator.Location = new System.Drawing.Point(232, 150);
            this.comboBox1Calibrator.Name = "comboBox1Calibrator";
            this.comboBox1Calibrator.Size = new System.Drawing.Size(404, 23);
            this.comboBox1Calibrator.TabIndex = 17;
            // 
            // dateTimePicker2Next
            // 
            this.dateTimePicker2Next.Location = new System.Drawing.Point(232, 121);
            this.dateTimePicker2Next.Name = "dateTimePicker2Next";
            this.dateTimePicker2Next.Size = new System.Drawing.Size(238, 23);
            this.dateTimePicker2Next.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Поверитель:";
            // 
            // checkBox1NextCalibration
            // 
            this.checkBox1NextCalibration.AutoSize = true;
            this.checkBox1NextCalibration.Location = new System.Drawing.Point(232, 96);
            this.checkBox1NextCalibration.Name = "checkBox1NextCalibration";
            this.checkBox1NextCalibration.Size = new System.Drawing.Size(139, 19);
            this.checkBox1NextCalibration.TabIndex = 23;
            this.checkBox1NextCalibration.Text = "Больше не поверять";
            this.checkBox1NextCalibration.UseVisualStyleBackColor = true;
            this.checkBox1NextCalibration.CheckedChanged += new System.EventHandler(this.checkBox1NextCalibration_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Дата следующей поверки/калибровки:";
            // 
            // FormCalibrationAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 228);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "FormCalibrationAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Калибровка СИ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox3Rezult;
        private Label label4;
        private Label label2;
        private Label label3Topic;
        private Label label8;
        private ComboBox comboBox1Calibrator;
        private Button button2Cancel;
        private Button button1Save;
        private Label label3;
        private DateTimePicker dateTimePicker1Now;
        private DateTimePicker dateTimePicker2Next;
        private CheckBox checkBox1NextCalibration;
    }
}