namespace WinFormsAppDevicesAccounting.Windows
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1Sename = new System.Windows.Forms.TextBox();
            this.textBox2Name = new System.Windows.Forms.TextBox();
            this.textBox3Login = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button10Refresh = new System.Windows.Forms.Button();
            this.button9Clear = new System.Windows.Forms.Button();
            this.dataGridView1Data = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2AddNew = new System.Windows.Forms.Button();
            this.button3Edit = new System.Windows.Forms.Button();
            this.button4Del = new System.Windows.Forms.Button();
            this.button5Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel5RecordNumber = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3RecordNumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Data)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5RecordNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1Data, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1Exit, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5RecordNumber, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 396);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox1Sename, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox2Name, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox3Login, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(282, 142);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Имя:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Логин:";
            // 
            // textBox1Sename
            // 
            this.textBox1Sename.Location = new System.Drawing.Point(70, 23);
            this.textBox1Sename.Name = "textBox1Sename";
            this.textBox1Sename.Size = new System.Drawing.Size(209, 23);
            this.textBox1Sename.TabIndex = 4;
            // 
            // textBox2Name
            // 
            this.textBox2Name.Location = new System.Drawing.Point(70, 52);
            this.textBox2Name.Name = "textBox2Name";
            this.textBox2Name.Size = new System.Drawing.Size(209, 23);
            this.textBox2Name.TabIndex = 5;
            // 
            // textBox3Login
            // 
            this.textBox3Login.Location = new System.Drawing.Point(70, 81);
            this.textBox3Login.Name = "textBox3Login";
            this.textBox3Login.Size = new System.Drawing.Size(209, 23);
            this.textBox3Login.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label6, 2);
            this.label6.Location = new System.Drawing.Point(92, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Условия поиска:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button10Refresh, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button9Clear, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 110);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(276, 29);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // button10Refresh
            // 
            this.button10Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10Refresh.Image = ((System.Drawing.Image)(resources.GetObject("button10Refresh.Image")));
            this.button10Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10Refresh.Location = new System.Drawing.Point(19, 3);
            this.button10Refresh.Name = "button10Refresh";
            this.button10Refresh.Size = new System.Drawing.Size(100, 23);
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
            this.button9Clear.Location = new System.Drawing.Point(157, 3);
            this.button9Clear.Name = "button9Clear";
            this.button9Clear.Size = new System.Drawing.Size(100, 23);
            this.button9Clear.TabIndex = 12;
            this.button9Clear.Text = "Очистить";
            this.button9Clear.UseVisualStyleBackColor = true;
            this.button9Clear.Click += new System.EventHandler(this.button9Clear_Click);
            // 
            // dataGridView1Data
            // 
            this.dataGridView1Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1Data.Location = new System.Drawing.Point(3, 186);
            this.dataGridView1Data.Name = "dataGridView1Data";
            this.dataGridView1Data.ReadOnly = true;
            this.dataGridView1Data.RowTemplate.Height = 25;
            this.dataGridView1Data.Size = new System.Drawing.Size(638, 178);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(667, 186);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 178);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button2AddNew
            // 
            this.button2AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2AddNew.Image = ((System.Drawing.Image)(resources.GetObject("button2AddNew.Image")));
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
            this.button3Edit.Image = ((System.Drawing.Image)(resources.GetObject("button3Edit.Image")));
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
            this.button4Del.Image = ((System.Drawing.Image)(resources.GetObject("button4Del.Image")));
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
            this.button5Refresh.Image = ((System.Drawing.Image)(resources.GetObject("button5Refresh.Image")));
            this.button5Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5Refresh.Location = new System.Drawing.Point(3, 90);
            this.button5Refresh.Name = "button5Refresh";
            this.button5Refresh.Size = new System.Drawing.Size(111, 23);
            this.button5Refresh.TabIndex = 11;
            this.button5Refresh.Text = "Обновить";
            this.button5Refresh.UseVisualStyleBackColor = true;
            this.button5Refresh.Click += new System.EventHandler(this.button5Refresh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пользователи:";
            // 
            // button1Exit
            // 
            this.button1Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Exit.Image = ((System.Drawing.Image)(resources.GetObject("button1Exit.Image")));
            this.button1Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Exit.Location = new System.Drawing.Point(667, 370);
            this.button1Exit.Name = "button1Exit";
            this.button1Exit.Size = new System.Drawing.Size(114, 23);
            this.button1Exit.TabIndex = 5;
            this.button1Exit.Text = "Закрыть";
            this.button1Exit.UseVisualStyleBackColor = true;
            this.button1Exit.Click += new System.EventHandler(this.button1Exit_Click);
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
            this.tableLayoutPanel5RecordNumber.Location = new System.Drawing.Point(3, 374);
            this.tableLayoutPanel5RecordNumber.Name = "tableLayoutPanel5RecordNumber";
            this.tableLayoutPanel5RecordNumber.RowCount = 1;
            this.tableLayoutPanel5RecordNumber.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5RecordNumber.Size = new System.Drawing.Size(113, 15);
            this.tableLayoutPanel5RecordNumber.TabIndex = 6;
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
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пользователи";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Data)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5RecordNumber.ResumeLayout(false);
            this.tableLayoutPanel5RecordNumber.PerformLayout();
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
        private Label label1;
        private Button button1Exit;
        private TableLayoutPanel tableLayoutPanel5RecordNumber;
        private Label label2;
        private Label label3RecordNumber;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1Sename;
        private TextBox textBox2Name;
        private TextBox textBox3Login;
        private Label label6;
        private Button button10Refresh;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button9Clear;
    }
}