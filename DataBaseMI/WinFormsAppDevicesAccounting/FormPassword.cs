using ViewInterfaces;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Форма аутентификации входящего пользователя по введённым логину и паролю
    /// </summary>
    public partial class FormPassword : BaseViewShowErrorAndWarning, IPasswordView
    {
        public event EventHandler<(string? login, string? password)>? CheckingLogin;

        public FormPassword()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }

        void OnCheckingLogin()
        {
            string login = textBox1Login.Text;
            string password = textBox2Password.Text;
            CheckingLogin?.Invoke(this, (login, password));
        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            OnCheckingLogin();
        }

        private void button2Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
