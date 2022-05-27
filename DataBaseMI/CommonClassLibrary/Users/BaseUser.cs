using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonClassLibrary
{
    /// <summary>
    /// Базовый класс для Пользователя и Поверителя
    /// </summary>
    public abstract class BaseUser : ICloneable
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
        public string? Surname { get; set; } = null!;

        /// <summary>
        /// Имя
        /// </summary>
        [Required(ErrorMessage = "Не указано имя")]
        [MaxLength(30, ErrorMessage = "Длина имени превышает допустимую величину (30 символов)")]
        [DisplayName("Имя")]
        public string? Name { get; set; } = null!;

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
        [Browsable(false)]
        public Department? Department { get; set; } = null!; //(Навигационное свойство)

        /// <summary>
        /// Свойство для отображения в DataGridView вместо Department;
        /// </summary>
        [DisplayName("Отдел")]
        [NotMapped]
        public string WhatSeeInsteadDepartment => Department?.Name + ", " + Department?.SubdevisionNumber;

        public virtual object Clone()
        {
            BaseUser newObj = (BaseUser)this.MemberwiseClone();
            newObj.Surname = Surname?.Substring(0, Surname.Length); //копируем строку
            newObj.Name = Name?.Substring(0, Name.Length); //копируем строку
            newObj.MiddleName = MiddleName?.Substring(0, MiddleName.Length); //копируем строку
            newObj.Department = this.Department?.Clone() as Department;
            return newObj;
        }

        /// <summary>
        /// сравнение двух объектов на равенство
        /// </summary>
        public override bool Equals(object? obj)
        {
            // если параметр метода представляет этот тип 
            // И если поля совпадают, то возвращаем true
            if (obj is BaseUser user)
                return
                     Id == user.Id
                     && string.Equals(Surname?.ToUpper(), user.Surname?.ToUpper())
                     && string.Equals(Name?.ToUpper(), user.Name?.ToUpper())
                     && string.Equals(MiddleName?.ToUpper(), user.MiddleName?.ToUpper())
                     && DepartmentId == user.DepartmentId
                     && Department!.Equals(user.Department);
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString()+ Surname + Name + MiddleName).GetHashCode();
    }
}
