using CommonClassLibrary;
using ViewInterfaces;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Окно, в котором выводится информация о произведённом ремонте СИ
    /// </summary>
    public partial class FormRepair : BaseViewForDbForms, IRepairView
    {
        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<Repair>? Deleting;
        public event EventHandler<Repair>? Editing;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormRepair()
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
                // или бросать исключение
            }
        }

        public void PrintData(List<Repair> list, Repair? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<Repair>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }

        private void button2AddNew_Click(object sender, EventArgs e)
        {
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Repair>(dataGridView1Data);
            if (data != null) OnEditing<Repair>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Repair>(dataGridView1Data);
            if (data != null) OnDeleting<Repair>(this, Deleting, data);
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
