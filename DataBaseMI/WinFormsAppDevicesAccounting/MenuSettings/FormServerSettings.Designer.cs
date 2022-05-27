namespace WinFormsAppDevicesAccounting
{
    partial class FormServerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServerSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1ServerName = new System.Windows.Forms.TextBox();
            this.textBox2DbName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1Save = new System.Windows.Forms.Button();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.label3Topic = new System.Windows.Forms.Label();
            this.button3CheckServerConnection = new System.Windows.Forms.Button();
            this.button4CheckDbEnable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4CurrentServerName = new System.Windows.Forms.TextBox();
            this.textBox5CurrentDbName = new System.Windows.Forms.TextBox();
            this.button5CreateDb = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox1ServerName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox2DbName, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3Topic, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button3CheckServerConnection, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button4CheckDbEnable, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox4CurrentServerName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5CurrentDbName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5CreateDb, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 305);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес сервера:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название БД:";
            // 
            // textBox1ServerName
            // 
            this.textBox1ServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1ServerName.Location = new System.Drawing.Point(153, 141);
            this.textBox1ServerName.Name = "textBox1ServerName";
            this.textBox1ServerName.Size = new System.Drawing.Size(212, 23);
            this.textBox1ServerName.TabIndex = 7;
            this.textBox1ServerName.Text = "KOMP2021";
            // 
            // textBox2DbName
            // 
            this.textBox2DbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2DbName.Location = new System.Drawing.Point(153, 170);
            this.textBox2DbName.Name = "textBox2DbName";
            this.textBox2DbName.Size = new System.Drawing.Size(212, 23);
            this.textBox2DbName.TabIndex = 8;
            this.textBox2DbName.Text = "DbMeasuringDevices";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 21);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1Save, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2Cancel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 248);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(562, 54);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // button1Save
            // 
            this.button1Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1Save.Image = ((System.Drawing.Image)(resources.GetObject("button1Save.Image")));
            this.button1Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Save.Location = new System.Drawing.Point(87, 28);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(107, 23);
            this.button1Save.TabIndex = 5;
            this.button1Save.Text = "Сохранить";
            this.button1Save.UseVisualStyleBackColor = true;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // button2Cancel
            // 
            this.button2Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2Cancel.Image = ((System.Drawing.Image)(resources.GetObject("button2Cancel.Image")));
            this.button2Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2Cancel.Location = new System.Drawing.Point(368, 28);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(107, 23);
            this.button2Cancel.TabIndex = 6;
            this.button2Cancel.Text = "Закрыть";
            this.button2Cancel.UseVisualStyleBackColor = true;
            this.button2Cancel.Click += new System.EventHandler(this.button2Cancel_Click);
            // 
            // label3Topic
            // 
            this.label3Topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3Topic.AutoSize = true;
            this.label3Topic.Location = new System.Drawing.Point(191, 113);
            this.label3Topic.Margin = new System.Windows.Forms.Padding(10);
            this.label3Topic.Name = "label3Topic";
            this.label3Topic.Size = new System.Drawing.Size(135, 15);
            this.label3Topic.TabIndex = 4;
            this.label3Topic.Text = "Введите новые данные:";
            // 
            // button3CheckServerConnection
            // 
            this.button3CheckServerConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3CheckServerConnection.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.refresh;
            this.button3CheckServerConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3CheckServerConnection.Location = new System.Drawing.Point(382, 141);
            this.button3CheckServerConnection.Name = "button3CheckServerConnection";
            this.button3CheckServerConnection.Size = new System.Drawing.Size(172, 23);
            this.button3CheckServerConnection.TabIndex = 12;
            this.button3CheckServerConnection.Text = "ping";
            this.button3CheckServerConnection.UseVisualStyleBackColor = true;
            this.button3CheckServerConnection.Click += new System.EventHandler(this.button3CheckServerConnection_Click);
            // 
            // button4CheckDbEnable
            // 
            this.button4CheckDbEnable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4CheckDbEnable.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.find2;
            this.button4CheckDbEnable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4CheckDbEnable.Location = new System.Drawing.Point(381, 170);
            this.button4CheckDbEnable.Name = "button4CheckDbEnable";
            this.button4CheckDbEnable.Size = new System.Drawing.Size(173, 23);
            this.button4CheckDbEnable.TabIndex = 13;
            this.button4CheckDbEnable.Text = "Проверить наличие БД";
            this.button4CheckDbEnable.UseVisualStyleBackColor = true;
            this.button4CheckDbEnable.Click += new System.EventHandler(this.button4CheckDbEnable_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Текущие настройки:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Адрес сервера:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Название БД:";
            // 
            // textBox4CurrentServerName
            // 
            this.textBox4CurrentServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4CurrentServerName.Location = new System.Drawing.Point(153, 28);
            this.textBox4CurrentServerName.Name = "textBox4CurrentServerName";
            this.textBox4CurrentServerName.ReadOnly = true;
            this.textBox4CurrentServerName.Size = new System.Drawing.Size(212, 23);
            this.textBox4CurrentServerName.TabIndex = 17;
            // 
            // textBox5CurrentDbName
            // 
            this.textBox5CurrentDbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5CurrentDbName.Location = new System.Drawing.Point(153, 57);
            this.textBox5CurrentDbName.Name = "textBox5CurrentDbName";
            this.textBox5CurrentDbName.ReadOnly = true;
            this.textBox5CurrentDbName.Size = new System.Drawing.Size(212, 23);
            this.textBox5CurrentDbName.TabIndex = 18;
            // 
            // button5CreateDb
            // 
            this.button5CreateDb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5CreateDb.Image = ((System.Drawing.Image)(resources.GetObject("button5CreateDb.Image")));
            this.button5CreateDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5CreateDb.Location = new System.Drawing.Point(380, 199);
            this.button5CreateDb.Name = "button5CreateDb";
            this.button5CreateDb.Size = new System.Drawing.Size(176, 23);
            this.button5CreateDb.TabIndex = 19;
            this.button5CreateDb.Text = "Создать БД";
            this.button5CreateDb.UseVisualStyleBackColor = true;
            this.button5CreateDb.Click += new System.EventHandler(this.button5CreateDb_Click);
            // 
            // FormServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 305);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(485, 290);
            this.Name = "FormServerSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки доступа к серверу БД";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1ServerName;
        private TextBox textBox2DbName;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1Save;
        private Button button2Cancel;
        private Label label3Topic;
        private Button button3CheckServerConnection;
        private Button button4CheckDbEnable;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4CurrentServerName;
        private TextBox textBox5CurrentDbName;
        private Button button5CreateDb;
    }
}