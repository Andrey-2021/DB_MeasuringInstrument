using AuthenticationLib;
using CommonClassLibrary;
using CommonInterface;
using ConteinerLibrary;
using Presenters.Common;
using RepositoryInterfaces;
using ViewInterfaces;

namespace Presenters
{
    /// <summary>
    /// Presenter для окна аутинтификации входящего пользователя
    /// </summary>
    internal class AuthenticationPresenter : IPresenter
    {
        IPasswordView _view;
        IRepository _repositiry;

        /// <summary>
        /// Результат Аутентификации пользователя
        /// </summary>
        public EnumAuthenticationResult Login { get; private set; } = EnumAuthenticationResult.off;

        /// <summary>
        /// Информация о вошедшем пользователе
        /// </summary>
        public User? LoggedUser { get; private set; } = null;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="view"></param>
        /// <param name="repositiry"></param>
        public AuthenticationPresenter(IPasswordView view, IRepository repositiry)
        {
            _view = view;
            _repositiry = repositiry;
            _view.CheckingLogin += CheckLogin;
            _view.ClosingMyWindow += CloseViewWindow;
        }

        public void Run()
        {
            _view.ShowView();
        }

        /// <summary>
        /// Проверка введённых логина и пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data">кортеж, содержащий введённые логин и пароль</param>
        void CheckLogin(Object? sender, (string? login, string? password) data)
        {
            var adminCheck = CheckAdminLogin(data);
            if (adminCheck.result == EnumLoginCheckResult.СheckedSuccessfulResult)  //это администратор
            {
                LoggedUser = new User() { Name = "Администратор" };
                Login = EnumAuthenticationResult.admin;
                _view.CloseView();
                return;
            }

            User? user;
            var userCheck = CheckUserLogin(data, out user);
            if (userCheck.result == EnumLoginCheckResult.СheckedSuccessfulResult) //это пользователь
            {
                LoggedUser = user;
                Login = EnumAuthenticationResult.user;
                _view.CloseView();
                return;
            }

            if (adminCheck.result == EnumLoginCheckResult.СheckedUnSuccessfulResult //проверка прошла, но это и не администратор
                && userCheck.result == EnumLoginCheckResult.СheckedUnSuccessfulResult) // и не пользователь
            {
                Login = EnumAuthenticationResult.off;
                _view.ShowError("Неправильно ввели логин или пароль!");
                return;
            }


            if (adminCheck.result == EnumLoginCheckResult.ICantCheckAdmin //невозможно проверить, ошибки при проверке администратора
                && userCheck.result == EnumLoginCheckResult.IСantСheckUser) // и при проверке пользователя
            {
                Login = EnumAuthenticationResult.off;
                _view.ShowError("Невозможно проверить введённые логин и пароль:"
                                + Environment.NewLine
                                + "1. " + adminCheck.error
                                + Environment.NewLine
                                + "2. " + userCheck.error
                                + Environment.NewLine
                                + "Обратитесь в службу поддержки программы!");
                return;
            }


            if (adminCheck.result == EnumLoginCheckResult.СheckedUnSuccessfulResult // это не администратор
                && userCheck.result == EnumLoginCheckResult.IСantСheckUser) //невозможно проверить, пользователя
            {
                Login = EnumAuthenticationResult.off;
                _view.ShowError("1. Неправильно ввели логин или пароль администратора!"
                                + Environment.NewLine
                                + "2. Невозможно проверить введённые логин и пароль для пользователя:"
                                + Environment.NewLine
                                + userCheck.error
                                + Environment.NewLine
                                + "Если вы пользователь, обратитесь в службу поддержки программы!");
                return;
            }


            if (adminCheck.result == EnumLoginCheckResult.ICantCheckAdmin // невозможно проверить администратора
                && userCheck.result == EnumLoginCheckResult.СheckedUnSuccessfulResult) //и это не пользователь пользователя
            {
                Login = EnumAuthenticationResult.off;
                _view.ShowError("1. Неправильно ввели логин или пароль для пользователя!"
                                + Environment.NewLine
                                + "2. Невозможно проверить введённые логин и пароль для администратора:"
                                + Environment.NewLine
                                + adminCheck.error
                                + Environment.NewLine
                                + "Если вы администратор, обратитесь в службу поддержки программы!");
                return;
            }

            //если как-то дошли сюда
            Login = EnumAuthenticationResult.off;
            _view.ShowError("Неправильно ввели логин или пароль!"
                                + Environment.NewLine
                                + "Невозможный вариант, обратитесь в службу поддержки программы!");
        }

        /// <summary>
        /// Проверка соответствуют ли введённые логин и пароль администратору
        /// </summary>
        /// <param name="data">кортеж, содержащий введённые логин и пароль</param>
        /// <returns>кортеж, результат проверки</returns>
        (EnumLoginCheckResult result, string error) CheckAdminLogin((string? login, string? password) data)
        {
            bool result = false;
            try
            {
                var adminAuthentication = Conteiner.GetInstance().GetClassInstance<IAdminAuthentication>();
                if (adminAuthentication == null) throw new NullReferenceException("Отсутствует класс выполняющий аутинтификацию администратора, реальзующий " + nameof(IAdminAuthentication));

                result = adminAuthentication.CheckPassword(data.login, data.password);
                if (result) return (EnumLoginCheckResult.СheckedSuccessfulResult, string.Empty);
                else return (EnumLoginCheckResult.СheckedUnSuccessfulResult, string.Empty);
            }
            catch (Exception ex)
            {
                return (EnumLoginCheckResult.ICantCheckAdmin, ex.Message);
            }
        }

        /// <summary>
        /// Проверка соответствуют ли введённые логин и пароль какому-нибудь пользователю
        /// </summary>
        /// <param name="data">кортеж, содержащий введённые логин и пароль</param>
        /// <returns>кортеж, результат проверки</returns>
        (EnumLoginCheckResult result, string error) CheckUserLogin((string? login, string? password) data, out User? user)
        {
            user = null;

            try
            {
                var list = _repositiry.ReadFromDb<User>((x) => x.Login == data.login && x.Password == data.password);
                if (list.Count > 0)
                {
                    user = list[0];
                    return (EnumLoginCheckResult.СheckedSuccessfulResult, string.Empty);
                }
                else return (EnumLoginCheckResult.СheckedUnSuccessfulResult, string.Empty);
            }
            catch (Exception ex)
            {
                return (EnumLoginCheckResult.IСantСheckUser, ex.Message);
            }
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
