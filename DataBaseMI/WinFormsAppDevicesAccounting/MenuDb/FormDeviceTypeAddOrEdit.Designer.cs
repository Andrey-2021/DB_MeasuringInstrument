namespace WinFormsAppDevicesAccounting.Windows
{
    partial class FormDeviceTypeAddOrEdit
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
            this.textBox1TypeName = new System.Windows.Forms.TextBox();
            this.label3Topic = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1Save = new System.Windows.Forms.Button();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1TypeName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3Topic, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 155);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // textBox1TypeName
            // 
            this.textBox1TypeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1TypeName.Location = new System.Drawing.Point(173, 38);
            this.textBox1TypeName.Name = "textBox1TypeName";
            this.textBox1TypeName.Size = new System.Drawing.Size(315, 23);
            this.textBox1TypeName.TabIndex = 2;
            // 
            // label3Topic
            // 
            this.label3Topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3Topic.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3Topic, 3);
            this.label3Topic.Location = new System.Drawing.Point(162, 10);
            this.label3Topic.Margin = new System.Windows.Forms.Padding(10);
            this.label3Topic.Name = "label3Topic";
            this.label3Topic.Size = new System.Drawing.Size(234, 15);
            this.label3Topic.TabIndex = 4;
            this.label3Topic.Text = "Ввод данных об учасках/подразделениях";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(153, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(153, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "*";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(173, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(212, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "- поля обязательные для заполнения";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1Save, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2Cancel, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(553, 29);
            this.tableLayoutPanel2.TabIndex = 33;
            // 
            // button1Save
            // 
            this.button1Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1Save.Image = global::WinFormsAppDevicesAccounting.Properties.Resources.save;
            this.button1Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Save.Location = new System.Drawing.Point(84, 3);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(108, 23);
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
            this.button2Cancel.Location = new System.Drawing.Point(360, 3);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(108, 23);
            this.button2Cancel.TabIndex = 6;
            this.button2Cancel.Text = "Закрыть";
            this.button2Cancel.UseVisualStyleBackColor = true;
            this.button2Cancel.Click += new System.EventHandler(this.button2Cancel_Click);
            // 
            // FormDeviceTypeAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 155);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(550, 180);
            this.Name = "FormDeviceTypeAddOrEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тип СИ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox textBox1TypeName;
        private Label label3Topic;
        private Button button1Save;
        private Button button2Cancel;
        private Label label11;
        private Label label2;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel2;
    }
}