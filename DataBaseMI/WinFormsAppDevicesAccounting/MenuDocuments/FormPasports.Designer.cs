namespace WinFormsAppDevicesAccounting.Documents
{
    partial class FormPasports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasports));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1DeviceName = new System.Windows.Forms.TextBox();
            this.textBox2ManufacturerNumber = new System.Windows.Forms.TextBox();
            this.textBox3InventoryNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button10Refresh = new System.Windows.Forms.Button();
            this.button9Clear = new System.Windows.Forms.Button();
            this.dataGridView1Data = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1SaveVer1 = new System.Windows.Forms.Button();
            this.button2SaveVer2 = new System.Windows.Forms.Button();
            this.button1Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Data)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1Data, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1Exit, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 431);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox1DeviceName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2ManufacturerNumber, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox3InventoryNumber, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 142);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименованиеие прибора:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Заводской номер:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Инвентарный номер:";
            // 
            // textBox1DeviceName
            // 
            this.textBox1DeviceName.Location = new System.Drawing.Point(166, 23);
            this.textBox1DeviceName.Name = "textBox1DeviceName";
            this.textBox1DeviceName.Size = new System.Drawing.Size(209, 23);
            this.textBox1DeviceName.TabIndex = 4;
            // 
            // textBox2ManufacturerNumber
            // 
            this.textBox2ManufacturerNumber.Location = new System.Drawing.Point(166, 52);
            this.textBox2ManufacturerNumber.Name = "textBox2ManufacturerNumber";
            this.textBox2ManufacturerNumber.Size = new System.Drawing.Size(209, 23);
            this.textBox2ManufacturerNumber.TabIndex = 5;
            // 
            // textBox3InventoryNumber
            // 
            this.textBox3InventoryNumber.Location = new System.Drawing.Point(166, 81);
            this.textBox3InventoryNumber.Name = "textBox3InventoryNumber";
            this.textBox3InventoryNumber.Size = new System.Drawing.Size(209, 23);
            this.textBox3InventoryNumber.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label6, 2);
            this.label6.Location = new System.Drawing.Point(140, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Условия поиска:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button10Refresh, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button9Clear, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 110);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 29);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // button10Refresh
            // 
            this.button10Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10Refresh.Image = ((System.Drawing.Image)(resources.GetObject("button10Refresh.Image")));
            this.button10Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10Refresh.Location = new System.Drawing.Point(42, 3);
            this.button10Refresh.Name = "button10Refresh";
            this.button10Refresh.Size = new System.Drawing.Size(102, 23);
            this.button10Refresh.TabIndex = 11;
            this.button10Refresh.Text = "Найти";
            this.button10Refresh.UseVisualStyleBackColor = true;
            this.button10Refresh.Click += new System.EventHandler(this.button10Refresh_Click);
            // 
            // button9Clear
            // 
            this.button9Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9Clear.Image = ((System.Drawing.Image)(resources.GetObject("button9Clear.Image")));
            this.button9Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9Clear.Location = new System.Drawing.Point(228, 3);
            this.button9Clear.Name = "button9Clear";
            this.button9Clear.Size = new System.Drawing.Size(102, 23);
            this.button9Clear.TabIndex = 12;
            this.button9Clear.Text = "Очистить";
            this.button9Clear.UseVisualStyleBackColor = true;
            this.button9Clear.Click += new System.EventHandler(this.button9Clear_Click);
            // 
            // dataGridView1Data
            // 
            this.dataGridView1Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1Data.Location = new System.Drawing.Point(3, 206);
            this.dataGridView1Data.Name = "dataGridView1Data";
            this.dataGridView1Data.RowTemplate.Height = 25;
            this.dataGridView1Data.Size = new System.Drawing.Size(628, 193);
            this.dataGridView1Data.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1SaveVer1);
            this.flowLayoutPanel1.Controls.Add(this.button2SaveVer2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(657, 206);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 193);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1SaveVer1
            // 
            this.button1SaveVer1.Image = ((System.Drawing.Image)(resources.GetObject("button1SaveVer1.Image")));
            this.button1SaveVer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1SaveVer1.Location = new System.Drawing.Point(3, 3);
            this.button1SaveVer1.Name = "button1SaveVer1";
            this.button1SaveVer1.Size = new System.Drawing.Size(102, 43);
            this.button1SaveVer1.TabIndex = 12;
            this.button1SaveVer1.Text = "Документ (Форма 1)";
            this.button1SaveVer1.UseVisualStyleBackColor = true;
            this.button1SaveVer1.Click += new System.EventHandler(this.button1SaveVer1_Click);
            // 
            // button2SaveVer2
            // 
            this.button2SaveVer2.Image = ((System.Drawing.Image)(resources.GetObject("button2SaveVer2.Image")));
            this.button2SaveVer2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2SaveVer2.Location = new System.Drawing.Point(3, 52);
            this.button2SaveVer2.Name = "button2SaveVer2";
            this.button2SaveVer2.Size = new System.Drawing.Size(102, 42);
            this.button2SaveVer2.TabIndex = 13;
            this.button2SaveVer2.Text = "Документ (Форма 2)";
            this.button2SaveVer2.UseVisualStyleBackColor = true;
            this.button2SaveVer2.Click += new System.EventHandler(this.button2SaveVer2_Click);
            // 
            // button1Exit
            // 
            this.button1Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Exit.Image = ((System.Drawing.Image)(resources.GetObject("button1Exit.Image")));
            this.button1Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Exit.Location = new System.Drawing.Point(657, 405);
            this.button1Exit.Name = "button1Exit";
            this.button1Exit.Size = new System.Drawing.Size(114, 23);
            this.button1Exit.TabIndex = 5;
            this.button1Exit.Text = "Закрыть";
            this.button1Exit.UseVisualStyleBackColor = true;
            this.button1Exit.Click += new System.EventHandler(this.button1Exit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Паспорта СИ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Результаты поиска:";
            // 
            // FormPasports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(700, 470);
            this.Name = "FormPasports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Паспорта СИ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Data)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1Data;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1Exit;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1DeviceName;
        private TextBox textBox2ManufacturerNumber;
        private TextBox textBox3InventoryNumber;
        private Label label5;
        private Label label6;
        private Button button10Refresh;
        private Button button1SaveVer1;
        private Button button2SaveVer2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button9Clear;
    }
}