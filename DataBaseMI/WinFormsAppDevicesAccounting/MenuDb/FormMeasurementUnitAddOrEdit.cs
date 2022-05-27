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
    public partial class FormMeasurementUnitAddOrEdit :
        BaseViewShowErrorAndWarning, IMeasurementUnitAddOrEditView
    {
        MeasurementUnit _data = null!;

        public event EventHandler<MeasurementUnit>? SavingNewData;

        public FormMeasurementUnitAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }


        public void PrintData(MeasurementUnit? data, string message)
        {
            label3Topic.Text = message;

            if (data == null)
                throw new NullReferenceException("Для вывода на экран нет данных");

            _data = data;
            textBox1Value.Text = _data.Value;
            
        }

        void OnSaveNewData()
        {
            _data.Value = textBox1Value.Text;
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
