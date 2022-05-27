using CommonClassLibrary;
using ViewInterfaces;

namespace WinFormsAppDevicesAccounting.Windows
{

    /// <summary>
    /// Окно "Периодичность калибровки прибора."
    /// </summary>
    public partial class FormCalibrationPeriod : BaseViewForDbForms, ICalibrationPeriodView
    {
        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<CalibrationPeriod>? Deleting;
        public event EventHandler<CalibrationPeriod>? Editing;

        public FormCalibrationPeriod()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;
        }

        public void PrintData(List<CalibrationPeriod> list, CalibrationPeriod? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity!=null) SelectRowInDataGrid<CalibrationPeriod>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }

        private void button2AddNew_Click(object sender, EventArgs e)
        {
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<CalibrationPeriod>(dataGridView1Data);
            if (data != null) OnEditing<CalibrationPeriod>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<CalibrationPeriod>(dataGridView1Data);
            if (data != null) OnDeleting<CalibrationPeriod>(this, Deleting, data);
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
