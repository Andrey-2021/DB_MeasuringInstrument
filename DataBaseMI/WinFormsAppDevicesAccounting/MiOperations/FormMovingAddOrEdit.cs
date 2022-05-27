using CommonClassLibrary;
using ViewInterfaces;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting
{
    public partial class FormMovingAddOrEdit : BaseViewShowErrorAndWarning, IMovingAddOrEditView
    {
        Moving _data = null!;

        public event EventHandler<Moving>? SavingNewData;

        public FormMovingAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
            dateTimePicker1Date.MinDate = new DateTime(1900, 01, 01); //минимальная дата, которую можно выбрать
            dateTimePicker1Date.MaxDate = DateTime.Today.AddDays(1); //наибольшая дата, которую можно выбрать
        }


        public void ShowDepartments(ComboBox comboBox, Department? data, List<Department>? departments)
        {
            //todo добавить - что делать если нет списка Department
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DisplayMember = nameof(Department.Name);// "Name";
            comboBox.ValueMember = nameof(Department.Id); // "Id";
            comboBox.DataSource = departments;
            if (comboBox.Items.Count > 0) comboBox.SelectedIndex = 0;

            //todo !!! сделать двы столбца в comboBox

            if (data != null)
            {
                int n = comboBox.Items.IndexOf(data);
                if (n >= 0) comboBox.SelectedIndex = n; ;
            }
        }



        public void PrintData(Moving? data, string message,
            List<User>? users,
            List<Department>? departments)
        {
            label3Topic.Text = message;

            if (data == null)
                throw new NullReferenceException("Для вывода на экран нет данных");

            _data = data;

            dateTimePicker1Date.Value = _data.Date;
            ShowDepartments(comboBox1GiveDepartment, _data?.GiveDepartment, departments);
            ShowDepartments(comboBox2TakeDepartment, _data?.TakeDepartment, departments);

            textBox1GiveName.Text = _data?.GiveName;
            textBox2TakeName.Text = _data?.TakeName;
        }
        void OnSaveNewData()
        {
            _data.Date = dateTimePicker1Date.Value;

            Object selectedItem = comboBox1GiveDepartment.SelectedItem;
            Department? dp = selectedItem as Department;
            _data.GiveDepartment = dp;
            if (dp != null) _data.GiveDepartmentId = dp.Id;

            selectedItem = comboBox2TakeDepartment.SelectedItem;
            dp = selectedItem as Department;
            _data.TakeDepartment = dp;
            if (dp != null) _data.TakeDepartmentId = dp.Id;

            _data.GiveName = textBox1GiveName.Text;
            _data.TakeName = textBox2TakeName.Text;

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
