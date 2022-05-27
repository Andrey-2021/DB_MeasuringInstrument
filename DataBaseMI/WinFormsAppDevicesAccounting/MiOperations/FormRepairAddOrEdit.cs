using CommonClassLibrary;
using ViewInterfaces;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Окно, в котором редактируются данные о выбранном произведённом ремонте или вводятся новые данные о произведённом ремонте СИ
    /// </summary>
    public partial class FormRepairAddOrEdit : BaseViewShowErrorAndWarning, IRepairAddOrEditView
    {
        Repair _data = null!;
        public event EventHandler<Repair>? SavingNewData;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormRepairAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
            dateTimePicker1Date.MinDate = new DateTime(1900, 01, 01); //минимальная дата, которую можно выбрать
            dateTimePicker1Date.MaxDate = DateTime.Today.AddDays(1); //наибольшая дата, которую можно выбрать
        }

        public void PrintData(Repair? data, string message)
        {
            label3Topic.Text = message;

            if (data == null)
                throw new NullReferenceException("Для вывода на экран нет данных");

            _data = data;
            dateTimePicker1Date.Value = _data.Date;
            textBox2Description.Text = _data.Description;
        }

        void OnSaveNewData()
        {
            _data.Date = dateTimePicker1Date.Value;
            _data.Description = textBox2Description.Text;
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
