using CommonClassLibrary;
using ViewInterfaces;

namespace WinFormsAppDevicesAccounting.Windows
{
    /// <summary>
    /// Окно для ввода нового пользователя или редактирования данных выбранного пользователя
    /// </summary>
    public partial class FormUserAddOrEdit :
        BaseViewShowErrorAndWarning, IUserAddOrEditView
    {
        User _data = null!;

        public event EventHandler<User>? SavingNewData;
        public FormUserAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }


        public void PrintData(User? data, string message, List<Department>? departments)
        {
            label3Topic.Text = message;

            if (data == null)
            {
                throw new NullReferenceException("Для вывода на экран нет данных");
            }

            _data = data;
            textBox1Surname.Text = _data.Surname;
            textBox2Name.Text = _data.Name;
            textBox3MiddleName.Text = _data.MiddleName;
            textBox4Login.Text = _data.Login;
            textBox5Password.Text = _data.Password;
            textBox6CopyPassword.Text = _data.Password; //_data.CopyPassword;

            //todo добавить - что делать если нет списка Department

            comboBox1Department.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1Department.DisplayMember = nameof(Department.Name);// "Name";
            comboBox1Department.ValueMember = nameof(Department.Id); // "Id";
            comboBox1Department.DataSource = departments;
            if (comboBox1Department.Items.Count > 0) comboBox1Department.SelectedIndex = 0;

            //todo !!! добавить выбор нужного Department при редактировании данных!!!
            //сделать двы столбца в comboBox
            int n = comboBox1Department.Items.IndexOf(data.Department);
            if (n >= 0) comboBox1Department.SelectedIndex = n; ;
        }

        void OnSaveNewData()
        {
            _data.Surname = textBox1Surname.Text;
            _data.Name = textBox2Name.Text;
            _data.MiddleName = textBox3MiddleName.Text;
            _data.Login = textBox4Login.Text;
            _data.Password = textBox5Password.Text;
            _data.CopyPassword = textBox6CopyPassword.Text;

            Object selectedItem = comboBox1Department.SelectedItem;
            Department? dp = selectedItem as Department;
            _data.Department = dp;
            if (dp != null) _data.DepartmentId = dp.Id;

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
