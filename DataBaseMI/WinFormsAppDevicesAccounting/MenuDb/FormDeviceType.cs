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
using CommonClassLibrary;

namespace WinFormsAppDevicesAccounting.Windows
{
    /// <summary>
    /// Окно, в котором выводится информация о типе СИ
    /// </summary>
    public partial class FormDeviceType : BaseViewForDbForms, IDeviceTypeView
    {
        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<DeviceType>? Deleting;
        public event EventHandler<DeviceType>? Editing;

        public FormDeviceType()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;
        }

        //public void PrintData(List<DeviceType> list)
        //{
        //    dataGridView1Data.DataSource = list;
        //}

        public void PrintData(List<DeviceType> list, DeviceType? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<DeviceType>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }


        private void button2AddNew_Click(object sender, EventArgs e)
        {
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<DeviceType>(dataGridView1Data);

            if (data != null) OnEditing<DeviceType>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<DeviceType>(dataGridView1Data);

            if (data != null) OnDeleting<DeviceType>(this, Deleting, data);
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
