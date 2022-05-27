using CommonClassLibrary;
using ViewInterfaces;

namespace WinFormsAppDevicesAccounting.Windows
{
    /// <summary>
    /// Окно в котором выводится все зарегистрированные пользователи
    /// </summary>
    public partial class FormUser : BaseViewForDbForms, IUserView
    {
        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<User>? Deleting;
        public event EventHandler<User>? Editing;

        public event EventHandler<FindUserDTO>? RefreshingAllUsers;

        public FormUser()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;
        }

        /// <summary>
        /// Вызов исключения, сообщающего о том, что необходимо обновить данные о СИ из БД
        /// </summary>
        public void OnRefreshAll(object sender,
            TextBox textBox1DeviceName,
            TextBox textBox2ManufacturerNumber,
            TextBox textBox3InventoryNumber)
        {
            if (RefreshingAllUsers != null)
            {
                FindUserDTO dto = new FindUserDTO()
                {
                    Surname = textBox1DeviceName.Text,
                    Name = textBox2ManufacturerNumber.Text,
                    Login = textBox3InventoryNumber.Text
                };

                RefreshingAllUsers(sender, dto);
            }
            else
            {
                throw new NullReferenceException("Нет обработчика поиска Пользователя");
                //ShowError("В программе нет возможности обновить данные из БД!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormUserAddOrEdit form = new FormUserAddOrEdit();
            form.ShowDialog();
        }

        public void PrintData(List<User> list, User? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<User>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }

        private void button2AddNew_Click(object sender, EventArgs e)
        {
            ClearFindFields();
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<User>(dataGridView1Data);
            if (data != null) OnEditing<User>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<User>(dataGridView1Data);
            if (data != null) OnDeleting<User>(this, Deleting, data);
        }

        private void button5Refresh_Click(object sender, EventArgs e)
        {
            ClearFindFields();
            OnRefreshAll(this, RefreshAll);
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10Refresh_Click(object sender, EventArgs e)
        {
            //найти
            OnRefreshAll(this, textBox1Sename, textBox2Name, textBox3Login);
        }

        /// <summary>
        /// Очистка полей поиска
        /// </summary>
        void ClearFindFields()
        {
            textBox1Sename.Clear();
            textBox2Name.Clear();
            textBox3Login.Clear();
        }

        private void button9Clear_Click(object sender, EventArgs e)
        {
            ClearFindFields();
        }
    }
}
