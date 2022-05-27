namespace WinFormsAppDevicesAccounting.Windows
{
    partial class FormDepartmentAddOrEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.textBox2SubdevisionNumber = new System.Windows.Forms.TextBox();
            this.label3Topic = new System.Windows.Forms.Label();
            this.button1Save = new System.Windows.Forms.Button();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1Name, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2SubdevisionNumber, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3Topic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1Save, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button2Cancel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Код подразделения:";
            // 
            // textBox1Name
            // 
            this.textBox1Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1Name.Location = new System.Drawing.Point(336, 38);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(250, 23);
            this.textBox1Name.TabIndex = 2;
            // 
            // textBox2SubdevisionNumber
            // 
            this.textBox2SubdevisionNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2SubdevisionNumber.Location = new System.Drawing.Point(336, 67);
            this.textBox2SubdevisionNumber.Name = "textBox2SubdevisionNumber";
            this.textBox2SubdevisionNumber.Size = new System.Drawing.Size(250, 23);
            this.textBox2SubdevisionNumber.TabIndex = 3;
            // 
            // label3Topic
            // 
            this.label3Topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3Topic.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3Topic, 3);
            this.label3Topic.Location = new System.Drawing.Point(206, 10);
            this.label3Topic.Margin = new System.Windows.Forms.Padding(10);
            this.label3Topic.Name = "label3Topic";
            this.label3Topic.Size = new System.Drawing.Size(234, 15);
            this.label3Topic.TabIndex = 4;
            this.label3Topic.Text = "Ввод данных об учасках/подразделениях";
            // 
            // button1Save
            // 
            this.button1Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1Save.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.save;
            this.button1Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Save.Location = new System.Drawing.Point(98, 135);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(117, 23);
            this.button1Save.TabIndex = 5;
            this.button1Save.Text = "Сохранить";
            this.button1Save.UseVisualStyleBackColor = true;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // button2Cancel
            // 
            this.button2Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2Cancel.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.exit;
            this.button2Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2Cancel.Location = new System.Drawing.Point(431, 135);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(117, 23);
            this.button2Cancel.TabIndex = 6;
            this.button2Cancel.Text = "Закрыть";
            this.button2Cancel.UseVisualStyleBackColor = true;
            this.button2Cancel.Click += new System.EventHandler(this.button2Cancel_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(316, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(316, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(316, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "*";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(336, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(212, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "- поля обязательные для заполнения";
            // 
            // FormDepartmentAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "FormDepartmentAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Участок";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1Name;
        private TextBox textBox2SubdevisionNumber;
        private Label label3Topic;
        private Button button2Cancel;
        private Button button1Save;
        private Label label11;
        private Label label3;
        private Label label4;
        private Label label16;
    }
}