using CommonInterface;
using System.Security.Cryptography;
using System.Text;

namespace AuthenticationLib
{
    /// <summary>
    /// Проверка логина и пароля администратора
    /// </summary>
    public class AdminAuthentication: IAdminAuthentication
    {
        /// <summary>
        /// Имя файла, в котором храним зашифорованные логин и пароль
        /// </summary>
        private const string fileName = "security";
       
        /// <summary>
        /// Минимальная длина логина
        /// </summary>
        public int LoginMinSize => 4;

        /// <summary>
        /// Минимальная длина пароля
        /// </summary>
        public int PasswordMinSize => 4;
        
        /// <summary>
        /// Установить новый пароль
        /// </summary>
        /// <param name="login">Новый логин</param>
        /// <param name="password">Новый пароль</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void SetNewPassword(string? login, string? password)
        {
            if (string.IsNullOrEmpty(login) || login.Length < LoginMinSize)
                throw new ArgumentOutOfRangeException("Длина Login должна быть не менее " + LoginMinSize + " символов");

            if (string.IsNullOrEmpty(password) || password.Length < PasswordMinSize)
                throw new ArgumentOutOfRangeException("Длина пароля должна быть не менее " + PasswordMinSize + " символов");

            SaveToFile( Coding(login), Coding(password));
        }

        /// <summary>
        /// Проверить логин и пароль
        /// </summary>
        /// <param name="login">Логин для проверки</param>
        /// <param name="password">Пароль для проверки</param>
        /// <returns></returns>
        public bool CheckPassword(string? login, string? password)
        {
            var fromFile = LoadFromFile();

            if (Coding(login) == fromFile.codedLogin && Coding(password) == fromFile.codedPassword)
                return true;
            return false;
        }

        /// <summary>
        /// Закодировать строку
        /// </summary>
        /// <param name="input">Исходная строка</param>
        /// <returns>Закодированная строка</returns>
       private string Coding(string? input)
        {
            string codedString;

            using (MD5 crypt = MD5.Create())
            {
                byte[] loginHash = crypt.ComputeHash(Encoding.UTF8.GetBytes(input));
                codedString = Convert.ToBase64String(loginHash);
            }
            return codedString;
        }

        /// <summary>
        /// Запись строк в файл
        /// </summary>
        /// <param name="codedLogin">закодированный логин</param>
        /// <param name="codedPassword">закодированный пароль</param>
        private void SaveToFile(string codedLogin, string codedPassword)
        {
            try
            {
                if (File.Exists(fileName)) File.Delete(fileName);
                File.WriteAllLines(fileName, new string[] { codedLogin, codedPassword });
                File.SetAttributes(fileName, FileAttributes.ReadOnly);
                File.SetAttributes(fileName, FileAttributes.Hidden);
            }
            catch (Exception ex)
            {
                throw new IOException("Ошбка при сохранении пароля администратора: "+ex.Message);
            }
        }

        /// <summary>
        /// Чтение строк из файла
        /// </summary>
        /// <returns>возвращаем кортеж - прочитанный из файла закодированные (логин,пароль)</returns>
        /// <exception cref="IOException">Ошибка при чтении файла</exception>
        private (string? codedLogin, string? codedPassword) LoadFromFile()
        {
            if (File.Exists(fileName))
            {
                try
                {
                    var lines = File.ReadAllLines(fileName);
                    if (lines?.Length < 2) return (null, null);
                    return (lines![0], lines[1]);
                }
                catch (Exception)
                {
                    throw new IOException("Ошбка при получении пароля администратора");
                }
            }
            throw new IOException("Отсутствует пароль администратора!");
        }
    }
}