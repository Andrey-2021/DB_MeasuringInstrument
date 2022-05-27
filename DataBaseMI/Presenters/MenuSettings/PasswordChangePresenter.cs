using AuthenticationLib;
using CommonClassLibrary;
using CommonInterface;
using Presenters.Common;
using RepositoryInterfaces;
using ViewInterfaces;

namespace Presenters
{
    /// <summary>
    /// Presenter для окна ввода нового логина и паролья администратора
    /// </summary>
    public class PasswordChangePresenter : IPresenter
    {
        IPasswordChangeView _view;
        IAdminAuthentication _adminAuthentication;

        /// <summary>
        /// Результат Аутентификации пользователя
        /// </summary>
        public EnumAuthenticationResult Login { get; private set; } = EnumAuthenticationResult.off;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="view"></param>
        /// <param name="repositiry"></param>
        public PasswordChangePresenter(IPasswordChangeView view, IAdminAuthentication adminAuthentication)
        {
            _view = view;
            _adminAuthentication = adminAuthentication;
            _view.SavingNewPassword += SaveNewPassword;
            _view.ClosingMyWindow += CloseViewWindow;
        }

        public void Run()
        {
            _view.ShowView();
        }


        /// <summary>
        /// Сохранить новые логин и пароль администратора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        void SaveNewPassword(Object? sender, (string? login, string? password, string? passwordCopy) data)
        {
            if (CheckData(data))
            {
                try
                {
                    _adminAuthentication.SetNewPassword(data.login, data.password);
                    _view.ShowInfo("Пароль изменён");
                    _view.CloseView();
                }
                catch (Exception ex)
                {
                    _view.ShowError("Ошибка: " + ex.Message);
                }
            }
        }


        /// <summary>
        /// Проверка данных
        /// </summary>
        /// <param name="data">Проверяемые тданные</param>
        /// <returns>Результат проверки</returns>
       private bool CheckData((string? login, string? password, string? passwordCopy) data)
        {
            if (string.IsNullOrEmpty(data.login) || data.login.Length < _adminAuthentication.LoginMinSize)
            {
                _view.ShowError("Длина логина должна быть не менее " + _adminAuthentication.LoginMinSize + " символов!");
                return false;
            }

            if (string.IsNullOrEmpty(data.password) || data.password.Length < _adminAuthentication.PasswordMinSize)
            {
                _view.ShowError("Длина пароля должна быть не менее " + _adminAuthentication.PasswordMinSize + " символов!");
                return false;
            }

            if (data.password != data.passwordCopy)
            {
                _view.ShowError("Пароли не совпадают!");
                return false;
            }

            return true;
        }




        /// <summary>
        /// Закрыть окно
        /// </summary>
        public void CloseViewWindow(object? sender, EventArgs args)
        {
            _view.CloseView();
        }

    }
}
