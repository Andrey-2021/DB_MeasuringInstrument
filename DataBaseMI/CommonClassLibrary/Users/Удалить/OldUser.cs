using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace CommonClassLibrary
{

    [Microsoft.EntityFrameworkCore.Index("Login", IsUnique = true)]
    //todo не работает Индекс со строками - не создаёт Уникальное поле
    public class OldUser : ICloneable
    {
        [Key]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int Id { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Required(ErrorMessage = "Не указана фамилия")]
        [MaxLength(30, ErrorMessage = "Длина фамилии превышает допустимую величину (30 символов)")]
        [DisplayName("Фамилия")] //Название заголовка столбца в DataGridView
        public string Surname { get; set; } = null!;

        /// <summary>
        /// Имя
        /// </summary>
        [Required(ErrorMessage = "Не указано имя")]
        [MaxLength(30, ErrorMessage = "Длина имени превышает допустимую величину (30 символов)")]
        [DisplayName("Имя")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Отчество
        /// </summary>
        [MaxLength(30, ErrorMessage = "Длина отчества превышает допустимую величину (30 символов)")]
        [DisplayName("Отчество")]
        public string? MiddleName { get; set; }

        /// <summary>
        /// Подразделение. Внешний ключ на Подразделение
        /// </summary>
        [Required(ErrorMessage = "Не указано подразделение")]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int DepartmentId { get; set; } // (Внешний ключ)
        
        /// <summary>
        /// Подразделение
        /// </summary>
        //[ForeignKey("DepartmentId")]
        [Browsable(false)]
        public virtual Department Department { get; set; } = null!; //(Навигационное свойство)

        /// <summary>
        /// Свойство для отображения в DataGridView вместо Department;
        /// </summary>
        [DisplayName("Отдел")]
        [NotMapped]
        public string WhatSeeInsteadDepartment => Department?.Name + ", " + Department?.SubdevisionNumber;



        /// <summary>
        /// Логин
        /// </summary>
        [Required(ErrorMessage = "Не указан логин")]
        [MaxLength(30, ErrorMessage = "Длина логина превышает допустимую величину (30 символов)")]
        [DisplayName("Логин")]
        public string Login { get; set; } = null!;

        /// <summary>
        /// Пароль
        /// </summary>
        [Required(ErrorMessage = "Не указан пароль")]
        [MaxLength(30, ErrorMessage = "Длина пароля превышает допустимую величину (30 символов)")]
        [DisplayName("Пароль")]
        public string Password { get; set; } = null!;


        /// <summary>
        /// Повторный Пароль
        /// </summary>
        [NotMapped]
        [Required(ErrorMessage = "Не указан повторный пароль")]
        [MaxLength(30, ErrorMessage = "Длина повторного пароля превышает допустимую величину (30 символов)")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [Browsable(false)]
        public string CopyPassword { get; set; } = null!;



        //todo сделать полное клонирование
        public object Clone()
        {
            var newObj= MemberwiseClone();
            ((User)newObj).Department = this.Department;
            ((User)newObj).DepartmentId = this.DepartmentId;

            return newObj;
        }

        //сравнение двух объектов на равенство
        //todo доделать сравнение по полям
        public override bool Equals(object? obj)
        {
            // если параметр метода представляет этот тип 
            // И если поля совпадают, то возвращаем true
            if (obj is User user)
                return
                     Id == user.Id
                     && Surname == user.Surname
                     && Name==user.Name
                     && MiddleName==user.MiddleName
                    && Login == user.Login
                    && Password == user.Password
                    && DepartmentId==user.DepartmentId;
                    

            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Login+Password).GetHashCode();
    }
}
