using CommonClassLibrary;
using ViewInterfaces;

namespace WinFormsAppDevicesAccounting.Windows
{
    /// <summary>
    /// Окно, в котором выводится информация о поверителях
    /// </summary>
    public partial class FormCalibrator : BaseViewForDbForms, ICalibratorView
    {
        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<Calibrator>? Deleting;
        public event EventHandler<Calibrator>? Editing;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormCalibrator()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormUserAddOrEdit form = new FormUserAddOrEdit();
            form.ShowDialog();
        }

        public void PrintData(List<Calibrator> list, Calibrator? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<Calibrator>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }

        private void button2AddNew_Click(object sender, EventArgs e)
        {
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Calibrator>(dataGridView1Data);

            if (data != null) OnEditing<Calibrator>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<Calibrator>(dataGridView1Data);

            if (data != null) OnDeleting<Calibrator>(this, Deleting, data);
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
