using ViewInterfaces;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Форма для ввода нового логина и паролья администратора
    /// </summary>
    public partial class FormPasswordChang : BaseViewShowErrorAndWarning, IPasswordChangeView
    {

        public event EventHandler<(string? login, string? password, string? passwordCopy)>? SavingNewPassword;

        public FormPasswordChang()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }

        void OnSavingNewPassword()
        {
            string login = textBox1Login.Text;
            string password = textBox2Password.Text;
            string passwordCopy = textBox3CopyPassword.Text;
            SavingNewPassword?.Invoke(this, (login, password, passwordCopy));
        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            OnSavingNewPassword();
        }

        private void button2Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
