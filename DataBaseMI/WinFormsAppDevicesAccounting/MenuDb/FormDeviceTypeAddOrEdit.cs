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

namespace WinFormsAppDevicesAccounting.Windows
{
    public partial class FormDeviceTypeAddOrEdit :
        BaseViewShowErrorAndWarning, IDeviceTypeAddOrEditView
    {
        DeviceType _data = null!;

        public event EventHandler<DeviceType>? SavingNewData;

        public FormDeviceTypeAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }

        public void PrintData(DeviceType? data, string message)
        {
            label3Topic.Text = message;

            if (data == null)
                throw new NullReferenceException("Для вывода на экран нет данных");

            _data = data;
            textBox1TypeName.Text = _data.TypeName;
        }

        void OnSaveNewData()
        {
            _data.TypeName = textBox1TypeName.Text;
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
