using CommonClassLibrary;
using ViewInterfaces;


namespace WinFormsAppDevicesAccounting.Windows
{
    /// <summary>
    /// Окно, в котором выводится информация о текущем состоянии СИ
    /// </summary>
    public partial class FormDeviceState : BaseViewForDbForms, IDeviceStateView
    {
        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<DeviceState>? Deleting;
        public event EventHandler<DeviceState>? Editing;

        public FormDeviceState()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;
        }


        //public void PrintData(List<DeviceState> list)
        //{
        //    dataGridView1Data.DataSource = list;
        //}
        public void PrintData(List<DeviceState> list, DeviceState? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<DeviceState>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }


        private void button2AddNew_Click(object sender, EventArgs e)
        {
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<DeviceState>(dataGridView1Data);

            if (data != null) OnEditing<DeviceState>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<DeviceState>(dataGridView1Data);

            if (data != null) OnDeleting<DeviceState>(this, Deleting, data);
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
