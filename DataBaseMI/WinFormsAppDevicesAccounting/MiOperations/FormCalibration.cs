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
    public partial class FormCalibration
        : BaseViewForDbForms, ICalibrationView
    {
        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<Calibration>? Deleting;
        public event EventHandler<Calibration>? Editing;

        public FormCalibration()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;
        }

        public void ShowHead(MeasuringInstrument measuringInstrument)
        {
            if (measuringInstrument is not null)
            {
                textBox1DeviceName.Text = measuringInstrument.DeviceName;
                textBox2ManufacturerNumber.Text = measuringInstrument.ManufacturerNumber;
                textBox3InventoryNumber.Text = measuringInstrument.InventoryNumber;
            }
            else
            {
                textBox1DeviceName.Text = "Нет данных";
                //todo или бросать исключение
            }

        }

               

        public void PrintData(List<Calibration> list, Calibration? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<Calibration>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }

        private void button2AddNew_Click(object sender, EventArgs e)
        {
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Calibration>(dataGridView1Data);

            if (data != null) OnEditing<Calibration>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Calibration>(dataGridView1Data);

            if (data != null) OnDeleting<Calibration>(this, Deleting, data);
        }

        private void button5Refresh_Click(object sender, EventArgs e)
        {
            OnRefreshAll(this, RefreshAll);
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
