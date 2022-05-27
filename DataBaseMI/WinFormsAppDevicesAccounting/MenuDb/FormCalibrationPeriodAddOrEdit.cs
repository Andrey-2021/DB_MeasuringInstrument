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

    /// <summary>
    /// Окно, в котором редактируются данные выбранного поверителя или вводятся данные о новом поверителе
    /// </summary>
    public partial class FormCalibrationPeriodAddOrEdit: BaseViewShowErrorAndWarning, ICalibrationPeriodAddOrEditView
    {
        CalibrationPeriod _data = null!;

        public event EventHandler<CalibrationPeriod>? SavingNewData;

        public FormCalibrationPeriodAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }


        public void PrintData(CalibrationPeriod? data, string message)
        {
            label3Topic.Text = message;

            if (data == null)
                throw new NullReferenceException("Для вывода на экран нет данных");

            _data = data;
            textBox1Period.Text = _data.Period;
        }


        void OnSaveNewData()
        {
            _data.Period = textBox1Period.Text;
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
