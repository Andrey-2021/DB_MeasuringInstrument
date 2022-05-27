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
    /// Окно, в котором выводится информация о местоположении/подразделении СИ
    /// </summary>
    public partial class FormDeparment: BaseViewForDbForms, IDeparmentView
    {
        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<Department>? Deleting;
        public event EventHandler<Department>? Editing;

        public FormDeparment()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;
        }



        //public void PrintData(List<Department> list)
        public void PrintData(List<Department> list, Department? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<Department>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }


        private void button2AddNew_Click(object sender, EventArgs e)
        {
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Department>(dataGridView1Data);

            if (data != null) OnEditing<Department>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Department>(dataGridView1Data);

            if (data != null) OnDeleting<Department>(this,Deleting, data);
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
