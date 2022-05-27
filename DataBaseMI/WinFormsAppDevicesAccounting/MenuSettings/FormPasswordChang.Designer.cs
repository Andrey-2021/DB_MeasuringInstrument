namespace WinFormsAppDevicesAccounting
{
    partial class FormPasswordChang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasswordChang));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Login = new System.Windows.Forms.TextBox();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1Save = new System.Windows.Forms.Button();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.textBox3CopyPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label3Topic = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1Login, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2Password, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox3CopyPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3Topic, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 172);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // textBox1Login
            // 
            this.textBox1Login.Location = new System.Drawing.Point(153, 38);
            this.textBox1Login.Name = "textBox1Login";
            this.textBox1Login.Size = new System.Drawing.Size(226, 23);
            this.textBox1Login.TabIndex = 7;
            // 
            // textBox2Password
            // 
            this.textBox2Password.Location = new System.Drawing.Point(153, 67);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.PasswordChar = '*';
            this.textBox2Password.Size = new System.Drawing.Size(226, 23);
            this.textBox2Password.TabIndex = 8;
            this.textBox2Password.UseSystemPasswordChar = true;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 125);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(399, 44);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // button1Save
            // 
            this.button1Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1Save.Image = ((System.Drawing.Image)(resources.GetObject("button1Save.Image")));
            this.button1Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Save.Location = new System.Drawing.Point(42, 18);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(115, 23);
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
            this.button2Cancel.Location = new System.Drawing.Point(241, 18);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(115, 23);
            this.button2Cancel.TabIndex = 6;
            this.button2Cancel.Text = "Закрыть";
            this.button2Cancel.UseVisualStyleBackColor = true;
            this.button2Cancel.Click += new System.EventHandler(this.button2Cancel_Click);
            // 
            // textBox3CopyPassword
            // 
            this.textBox3CopyPassword.Location = new System.Drawing.Point(153, 96);
            this.textBox3CopyPassword.Name = "textBox3CopyPassword";
            this.textBox3CopyPassword.PasswordChar = '*';
            this.textBox3CopyPassword.Size = new System.Drawing.Size(226, 23);
            this.textBox3CopyPassword.TabIndex = 10;
            this.textBox3CopyPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Повторить пароль:";
            // 
            // label3Topic
            // 
            this.label3Topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3Topic.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3Topic, 2);
            this.label3Topic.Location = new System.Drawing.Point(135, 10);
            this.label3Topic.Margin = new System.Windows.Forms.Padding(10);
            this.label3Topic.Name = "label3Topic";
            this.label3Topic.Size = new System.Drawing.Size(135, 15);
            this.label3Topic.TabIndex = 4;
            this.label3Topic.Text = "Введите новые данные:";
            // 
            // FormPasswordChang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 172);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormPasswordChang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Смена пароля";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3Topic;
        private TextBox textBox1Login;
        private TextBox textBox2Password;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1Save;
        private Button button2Cancel;
        private TextBox textBox3CopyPassword;
        private Label label3;
    }
}