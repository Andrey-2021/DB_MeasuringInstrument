using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewInterfaces;
using ViewInterfaces.Common;

namespace WinFormsAppDevicesAccounting.Windows
{
    public partial class FormDepartmentAddOrEdit 
        : BaseViewShowErrorAndWarning, IDepartmentAddOrEditView
    {
        Department _data = null!;
        public event EventHandler<Department>? SavingNewData;

        public FormDepartmentAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }

        public void PrintData(Department? data, string message)
        {
            label3Topic.Text = message;

            if (data == null)
                throw new NullReferenceException("Для вывода на экран нет данных");

            _data = data;
            textBox1Name.Text = _data.Name;
            textBox2SubdevisionNumber.Text = _data.SubdevisionNumber;
        }

        void OnSaveNewData()
        {
            _data.Name = textBox1Name.Text;
            _data.SubdevisionNumber = textBox2SubdevisionNumber.Text;
            SavingNewData?.Invoke(this, _data);
        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            OnSaveNewData();
        }

        private void button2Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
