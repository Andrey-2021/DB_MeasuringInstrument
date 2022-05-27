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
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting
{
    public partial class FormCalibrationAddOrEdit: BaseViewShowErrorAndWarning, ICalibrationAddOrEditView
    {
        Calibration _data = null!;

        public event EventHandler<Calibration>? SavingNewData;

        public FormCalibrationAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;

            dateTimePicker1Now.MinDate = new DateTime(1900, 01, 01); //минимальная дата, которую можно выбрать
            dateTimePicker1Now.MaxDate = DateTime.Today.AddDays(1); //наибольшая дата, которую можно выбрать

            //dateTimePicker2Next.MinDate = new DateTime(1900, 01, 01); //минимальная дата, которую можно выбрать
        }



        public void PrintData(Calibration? data, string message, List<Calibrator>? calibrators)
        {
            label3Topic.Text = message;

            if (data == null)
            {
                throw new NullReferenceException("Для вывода на экран нет данных");
            }

            _data = data;

            textBox3Rezult.Text = _data.Rezult;
            dateTimePicker1Now.Value = _data.Date;

            if (_data.NextCalibrationDate == null)
            {
                checkBox1NextCalibration.Checked = true;
                dateTimePicker2Next.Enabled = false;
                //dateTimePicker2Next.Value = DateTime.Today;
            }
            else
            {
                checkBox1NextCalibration.Checked = false;
                dateTimePicker2Next.Value = (DateTime)_data.NextCalibrationDate;
            }

            //todo добавить - что делать если нет списка Calibrators

            comboBox1Calibrator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1Calibrator.DisplayMember = nameof(Calibrator.Surname);// "Name";
            comboBox1Calibrator.ValueMember = nameof(Calibrator.Id); // "Id";
            comboBox1Calibrator.DataSource = calibrators;
            if (comboBox1Calibrator.Items.Count > 0) comboBox1Calibrator.SelectedIndex = 0;



            //todo !!! добавить выбор нужного Department при редактировании данных!!!
            //сделать двы столбца в comboBox
            int n = comboBox1Calibrator.Items.IndexOf(data.Calibrator);
            if (n >= 0) comboBox1Calibrator.SelectedIndex = n; ;

            //todo Доделать
            //comboBox1Department
        }
        void OnSaveNewData()
        {
            _data.Rezult= textBox3Rezult.Text;
            _data.Date=dateTimePicker1Now.Value;

            if (checkBox1NextCalibration.Checked == false)
                _data.NextCalibrationDate = dateTimePicker2Next.Value;
            else
                _data.NextCalibrationDate = null;


            Object selectedItem = comboBox1Calibrator.SelectedItem;
            Calibrator? dp = selectedItem as Calibrator;
            _data.Calibrator = dp;
            if (dp != null) _data.CalibratorId = dp.Id;
            
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1NextCalibration_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1NextCalibration.Checked == true)
                dateTimePicker2Next.Enabled = false;
            else 
                dateTimePicker2Next.Enabled = true; ;
        }
    }
}
