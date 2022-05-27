using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterface
{
    /// <summary>
    /// Интерфейс класса реализующего хранение и проверку логина и пароля администратора 
    /// </summary>
    public interface IAdminAuthentication
    {
        /// <summary>
        /// Минимальный размер для Login
        /// </summary>
        public int LoginMinSize { get; }

        /// <summary>
        /// Минимальный размер для пароля
        /// </summary>
        public int PasswordMinSize { get; }

        /// <summary>
        /// Установить новые логин и пароль для администратора
        /// </summary>
        /// <param name="login">Новый логин</param>
        /// <param name="password">Новай пароль</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void SetNewPassword(string? login, string? password);

        /// <summary>
        /// Проверка логина и пароля
        /// </summary>
        /// <param name="login">Проверяемый логин</param>
        /// <param name="password">Проверяемый пароль</param>
        /// <returns></returns>
        public bool CheckPassword(string? login, string? password);
    }
}
