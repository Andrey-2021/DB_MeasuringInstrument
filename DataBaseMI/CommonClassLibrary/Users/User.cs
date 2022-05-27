using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace CommonClassLibrary
{
    /// <summary>
    /// Пользователь ПО
    /// </summary>
    [Index(nameof(Login), IsUnique = true, Name = "Логин пользователя")] //д.б. уникальной
    public class User : BaseUser, ICloneable
    {
        /// <summary>
        /// Логин
        /// </summary>
        [Required(ErrorMessage = "Не указан логин")]
        [MaxLength(30, ErrorMessage = "Длина логина превышает допустимую величину (30 символов)")]
        [DisplayName("Логин")]
        public string? Login { get; set; } = null!;

        /// <summary>
        /// Пароль
        /// </summary>
        [Required(ErrorMessage = "Не указан пароль")]
        [MaxLength(30, ErrorMessage = "Длина пароля превышает допустимую величину (30 символов)")]
        [DisplayName("Пароль")]
        public string? Password { get; set; } = null!;

        /// <summary>
        /// Повторный Пароль
        /// </summary>
        [NotMapped]
        [Required(ErrorMessage = "Не указан повторный пароль")]
        [MaxLength(30, ErrorMessage = "Длина повторного пароля превышает допустимую величину (30 символов)")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [Browsable(false)]
        public string? CopyPassword { get; set; } = null!;

        public override object Clone()
        {
            User newObj = (User)this.MemberwiseClone();
            newObj.Login = Login?.Substring(0, Login.Length); //копируем строку
            newObj.Password = Password?.Substring(0, Password.Length);
            newObj.CopyPassword = CopyPassword?.Substring(0, CopyPassword.Length);
            return newObj;
        }

        public override bool Equals(object? obj)
        {
            // если параметр метода представляет этот тип И если поля совпадают, то возвращаем true
            if (obj is User user)
                return
                     Id == user.Id
                     && base.Equals(obj)
                     && string.Equals(Login?.ToUpper(), user.Login?.ToUpper())
                     && string.Equals(Password?.ToUpper(), user.Password?.ToUpper())
                     && string.Equals(CopyPassword?.ToUpper(), user.CopyPassword?.ToUpper());
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString()+Login+Password).GetHashCode();
    }
}
