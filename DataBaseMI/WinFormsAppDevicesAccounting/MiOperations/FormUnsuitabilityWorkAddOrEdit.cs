using CommonClassLibrary;
using ViewInterfaces;
using WinFormsAppDevicesAccounting.Windows;


namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Окно для ввода данных нового "извещения о непригодности СИ"
    /// или редактирования старых данных у выбранного СИ
    /// </summary>
    public partial class FormUnsuitabilityWorkAddOrEdit : BaseViewShowErrorAndWarning, IUnsuitabilityWorkAddOrEditView
    {
        Unsuitability _data = null!;
        public event EventHandler<Unsuitability>? SavingNewData;

        public FormUnsuitabilityWorkAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;

            dateTimePicker1Date.MinDate = new DateTime(1900, 01, 01); //минимальная дата, которую можно выбрать
            dateTimePicker1Date.MaxDate = DateTime.Today.AddDays(1); //наибольшая дата, которую можно выбрать
        }

        public void PrintData(Unsuitability? data, string message, List<Calibrator>? calibrators)
        {
            label3Topic.Text = message;

            if (data == null)
                throw new NullReferenceException("Для вывода на экран нет данных");

            _data = data;
            textBox1Number.Text = _data.Number;
            textBox2Info.Text = _data.Info;
            textBox3Document.Text = _data.Document;
            textBox4UnsuitabilityReasons.Text = _data.UnsuitabilityReasons;
            textBox5Job.Text = _data.Job;
            textBox6Director.Text = _data.Director;
            dateTimePicker1Date.Value = _data.Date;

            //todo добавить - что делать если нет списка Calibrators
            comboBox1Calibrator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1Calibrator.DisplayMember = nameof(Calibrator.Surname);// "Name";
            comboBox1Calibrator.ValueMember = nameof(Calibrator.Id); // "Id";
            comboBox1Calibrator.DataSource = calibrators;
            if (comboBox1Calibrator.Items.Count > 0) comboBox1Calibrator.SelectedIndex = 0;

            //todo сделать двы столбца в comboBox
            int n = comboBox1Calibrator.Items.IndexOf(data.Calibrator);
            if (n >= 0) comboBox1Calibrator.SelectedIndex = n; ;
        }
        void OnSaveNewData()
        {
            _data.Number = textBox1Number.Text;
            _data.Info = textBox2Info.Text;
            _data.Document = textBox3Document.Text;
            _data.UnsuitabilityReasons = textBox4UnsuitabilityReasons.Text;
            _data.Job = textBox5Job.Text;
            _data.Director = textBox6Director.Text;
            _data.Date = dateTimePicker1Date.Value;
            Object selectedItem = comboBox1Calibrator.SelectedItem;
            Calibrator? dp = selectedItem as Calibrator;
            _data.Calibrator = dp;
            if (dp != null) _data.CalibratorId = dp.Id;

            SavingNewData?.Invoke(this, _data);
        }

        private void button1Save_Click_1(object sender, EventArgs e)
        {
            OnSaveNewData();
        }

        private void button2Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
