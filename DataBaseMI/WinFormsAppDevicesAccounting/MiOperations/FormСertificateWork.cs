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
    public partial class FormСertificateWork //: Form //СertificateWorkPresenter
        : BaseViewForDbForms, IСertificateWorkView
    {
        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<Сertificate>? Deleting;
        public event EventHandler<Сertificate>? Editing;


        public FormСertificateWork()
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



        public void PrintData(List<Сertificate> list, Сertificate? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<Сertificate>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }

        private void button2AddNew_Click(object sender, EventArgs e)
        {
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Сertificate>(dataGridView1Data);

            if (data != null) OnEditing<Сertificate>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Сertificate>(dataGridView1Data);

            if (data != null) OnDeleting<Сertificate>(this, Deleting, data);
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
