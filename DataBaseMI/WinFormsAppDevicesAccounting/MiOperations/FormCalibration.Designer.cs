namespace WinFormsAppDevicesAccounting
{
    partial class FormCalibration
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
            this.tableLayoutPanel5RecordNumber = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3RecordNumber = new System.Windows.Forms.Label();
            this.dataGridView1Data = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2AddNew = new System.Windows.Forms.Button();
            this.button3Edit = new System.Windows.Forms.Button();
            this.button4Del = new System.Windows.Forms.Button();
            this.button5Refresh = new System.Windows.Forms.Button();
            this.button1Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1DeviceName = new System.Windows.Forms.TextBox();
            this.textBox2ManufacturerNumber = new System.Windows.Forms.TextBox();
            this.textBox3InventoryNumber = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5RecordNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Data)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5RecordNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1Data, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1Exit, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 411);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel5RecordNumber
            // 
            this.tableLayoutPanel5RecordNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel5RecordNumber.AutoSize = true;
            this.tableLayoutPanel5RecordNumber.ColumnCount = 2;
            this.tableLayoutPanel5RecordNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5RecordNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5RecordNumber.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5RecordNumber.Controls.Add(this.label3RecordNumber, 1, 0);
            this.tableLayoutPanel5RecordNumber.Location = new System.Drawing.Point(3, 389);
            this.tableLayoutPanel5RecordNumber.Name = "tableLayoutPanel5RecordNumber";
            this.tableLayoutPanel5RecordNumber.RowCount = 1;
            this.tableLayoutPanel5RecordNumber.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5RecordNumber.Size = new System.Drawing.Size(113, 15);
            this.tableLayoutPanel5RecordNumber.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Всего записей:";
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
            this.dataGridView1Data.Location = new System.Drawing.Point(3, 131);
            this.dataGridView1Data.Name = "dataGridView1Data";
            this.dataGridView1Data.RowTemplate.Height = 25;
            this.dataGridView1Data.Size = new System.Drawing.Size(628, 248);
            this.dataGridView1Data.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2AddNew);
            this.flowLayoutPanel1.Controls.Add(this.button3Edit);
            this.flowLayoutPanel1.Controls.Add(this.button4Del);
            this.flowLayoutPanel1.Controls.Add(this.button5Refresh);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(657, 131);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 248);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button2AddNew
            // 
            this.button2AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2AddNew.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.add;
            this.button2AddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2AddNew.Location = new System.Drawing.Point(3, 3);
            this.button2AddNew.Name = "button2AddNew";
            this.button2AddNew.Size = new System.Drawing.Size(111, 23);
            this.button2AddNew.TabIndex = 8;
            this.button2AddNew.Text = "Добавить";
            this.button2AddNew.UseVisualStyleBackColor = true;
            this.button2AddNew.Click += new System.EventHandler(this.button2AddNew_Click);
            // 
            // button3Edit
            // 
            this.button3Edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3Edit.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.pencil;
            this.button3Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3Edit.Location = new System.Drawing.Point(3, 32);
            this.button3Edit.Name = "button3Edit";
            this.button3Edit.Size = new System.Drawing.Size(111, 23);
            this.button3Edit.TabIndex = 9;
            this.button3Edit.Text = "Редактировать";
            this.button3Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3Edit.UseVisualStyleBackColor = true;
            this.button3Edit.Click += new System.EventHandler(this.button3Edit_Click);
            // 
            // button4Del
            // 
            this.button4Del.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4Del.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.delete;
            this.button4Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4Del.Location = new System.Drawing.Point(3, 61);
            this.button4Del.Name = "button4Del";
            this.button4Del.Size = new System.Drawing.Size(111, 23);
            this.button4Del.TabIndex = 10;
            this.button4Del.Text = "Удалить";
            this.button4Del.UseVisualStyleBackColor = true;
            this.button4Del.Click += new System.EventHandler(this.button4Del_Click);
            // 
            // button5Refresh
            // 
            this.button5Refresh.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.refresh;
            this.button5Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5Refresh.Location = new System.Drawing.Point(3, 90);
            this.button5Refresh.Name = "button5Refresh";
            this.button5Refresh.Size = new System.Drawing.Size(111, 23);
            this.button5Refresh.TabIndex = 11;
            this.button5Refresh.Text = "Обновить";
            this.button5Refresh.UseVisualStyleBackColor = true;
            this.button5Refresh.Click += new System.EventHandler(this.button5Refresh_Click);
            // 
            // button1Exit
            // 
            this.button1Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Exit.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.exit;
            this.button1Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Exit.Location = new System.Drawing.Point(657, 385);
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
            this.label2.Location = new System.Drawing.Point(271, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "калибровка СИ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox1DeviceName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2ManufacturerNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox3InventoryNumber, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 87);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименованиеие прибора:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Заводской номер:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Инвентарный номер:";
            // 
            // textBox1DeviceName
            // 
            this.textBox1DeviceName.Location = new System.Drawing.Point(166, 3);
            this.textBox1DeviceName.Name = "textBox1DeviceName";
            this.textBox1DeviceName.ReadOnly = true;
            this.textBox1DeviceName.Size = new System.Drawing.Size(209, 23);
            this.textBox1DeviceName.TabIndex = 4;
            // 
            // textBox2ManufacturerNumber
            // 
            this.textBox2ManufacturerNumber.Location = new System.Drawing.Point(166, 32);
            this.textBox2ManufacturerNumber.Name = "textBox2ManufacturerNumber";
            this.textBox2ManufacturerNumber.ReadOnly = true;
            this.textBox2ManufacturerNumber.Size = new System.Drawing.Size(209, 23);
            this.textBox2ManufacturerNumber.TabIndex = 5;
            // 
            // textBox3InventoryNumber
            // 
            this.textBox3InventoryNumber.Location = new System.Drawing.Point(166, 61);
            this.textBox3InventoryNumber.Name = "textBox3InventoryNumber";
            this.textBox3InventoryNumber.ReadOnly = true;
            this.textBox3InventoryNumber.Size = new System.Drawing.Size(209, 23);
            this.textBox3InventoryNumber.TabIndex = 6;
            // 
            // FormCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "FormCalibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Калибровка СИ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5RecordNumber.ResumeLayout(false);
            this.tableLayoutPanel5RecordNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Data)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1Data;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button2AddNew;
        private Button button3Edit;
        private Button button4Del;
        private Button button5Refresh;
        private Button button1Exit;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox1DeviceName;
        private TextBox textBox2ManufacturerNumber;
        private TextBox textBox3InventoryNumber;
        private TableLayoutPanel tableLayoutPanel5RecordNumber;
        private Label label5;
        private Label label3RecordNumber;
    }
}