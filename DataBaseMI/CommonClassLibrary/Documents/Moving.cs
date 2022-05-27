using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClassLibrary
{
    /// <summary>
    /// Перемещение СИ
    /// </summary>
    [Index(nameof(Date), nameof(GiveDepartmentId), IsUnique = true, Name = "Дата перемещения и отправитель")] //д.б. уникальным
    [Index(nameof(Date), nameof(TakeDepartmentId), IsUnique = true, Name = "Дата перемещения и получатель")] //д.б. уникальным
    public class Moving : ICloneable
    {
        [Key]
        [DisplayName("№ документа")]
        public int Id { get; set; }

        /// <summary>
        /// Средство измерения
        /// </summary>
        [Required(ErrorMessage = "Не указано средство измерения")]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int? MeasuringInstrumentId { get; set; } //(Внешний ключ)

        /// <summary>
        /// Средство измерения
        /// </summary>
        [Browsable(false)]
        public MeasuringInstrument? MeasuringInstrument { get; set; } = null!; //(Навигационное свойство)

        /// <summary>
        /// Дата перемещения
        /// </summary>
        [Required(ErrorMessage = "Не указана дата перемещения СИ")]
        [DisplayName("Дата перемещения")]
        [Column(TypeName = "DATE")] //Тип в БД MSSQL
        public DateTime Date { get; set; }

        /// <summary>
        /// Шифр (Местоположение/Подразделение) отправителя
        /// </summary>
        [Required(ErrorMessage = "Не указан шифр отправителя")]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int? GiveDepartmentId { get; set; } // (Внешний ключ)

        /// <summary>
        /// Шифр отправителя (Подразделение)
        /// </summary>
        [ForeignKey(nameof(GiveDepartmentId))]
        [Browsable(false)]
        public Department? GiveDepartment { get; set; } = null!; //(Навигационное свойство)
        //virtual

        /// <summary>
        /// Свойство для отображения в DataGridView вместо GiveDepartment;
        /// </summary>
        [DisplayName("Шифр отправителя")]
        [NotMapped]
        public string WhatSeeInsteadGiveDepartment => GiveDepartment?.Name + ", " + GiveDepartment?.SubdevisionNumber;

        /// <summary>
        /// Шифр(Местоположение/Подразделение) получателя 
        /// </summary>
        [Required(ErrorMessage = "Не указан шифр получателя")]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int? TakeDepartmentId { get; set; } // (Внешний ключ)

        /// <summary>
        /// Шифр получателя (Подразделение)
        /// </summary>
        [ForeignKey(nameof(TakeDepartmentId))]
        [Browsable(false)]
        public Department? TakeDepartment { get; set; } = null!; //(Навигационное свойство)

        /// <summary>
        /// Свойство для отображения в DataGridView вместо TakeDepartment;
        /// </summary>
        [DisplayName("Шифр получателя")]
        [NotMapped]
        public string WhatSeeInsteadTakeDepartment => TakeDepartment?.Name + ", " + TakeDepartment?.SubdevisionNumber;

        /// <summary>
        /// Сдал, ФИО
        /// </summary>
        [MaxLength(40, ErrorMessage = "Длина Ф.И.О. сдающего превышает допустимую величину (40 символов)")]
        [DisplayName("Сдал, Ф.И.О.")]
        [Required(ErrorMessage = "Не указано Ф.И.О. сдающего СИ")]
        public string? GiveName { get; set; }


        /// <summary>
        /// Принял, ФИО
        /// </summary>
        [MaxLength(40, ErrorMessage = "Длина Ф.И.О. принимающего превышает допустимую величину (40 символов)")]
        [DisplayName("Принял, Ф.И.О.")]
        [Required(ErrorMessage = "Не указано Ф.И.О. принявшего СИ")]
        public string? TakeName { get; set; }


        /// <summary>
        /// Конструктор
        /// </summary>
        public Moving()
        {
            Date = DateTime.Now; //при создании объекта, задаём текущую дату
        }



        //todo сделать полное клонирование
        public virtual object Clone()
        {
            Moving? newObj = (Moving)MemberwiseClone();

            newObj.MeasuringInstrument = this.MeasuringInstrument?.Clone() as MeasuringInstrument;
            newObj.MeasuringInstrumentId = this.MeasuringInstrumentId;

            newObj.GiveDepartment= this.GiveDepartment?.Clone() as Department;
            newObj.GiveDepartmentId = this.GiveDepartmentId;

            newObj.TakeDepartment = this.TakeDepartment?.Clone() as Department;
            newObj.TakeDepartmentId = this.TakeDepartmentId;


            newObj!.GiveName = GiveName?.Substring(0, GiveName.Length); //копируем строку
            newObj!.TakeName = TakeName?.Substring(0, TakeName.Length); //копируем строку
            return newObj;
        }

        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {
            // если параметр метода представляет нужный тип 
            // И если поля совпадают, то возвращаем true
            if (obj is Moving mv)
                return Id == mv.Id
                    && MeasuringInstrumentId == mv.MeasuringInstrumentId
                    && MeasuringInstrument!.Equals(mv.MeasuringInstrument)

                    && GiveDepartmentId == mv.GiveDepartmentId
                    && GiveDepartment!.Equals(mv.GiveDepartment)

                    && TakeDepartmentId == mv.TakeDepartmentId
                    && TakeDepartment!.Equals(mv.TakeDepartment)

                    && string.Equals(GiveName?.ToUpper(), mv.GiveName?.ToUpper())
                    && string.Equals(TakeName?.ToUpper(), mv.TakeName?.ToUpper())
                    && Date == mv.Date;
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id
                                                + MeasuringInstrumentId
                                                + Date.ToString()
                                                + GiveDepartmentId.ToString()
                                                + TakeDepartmentId.ToString()
                                                ).GetHashCode();
    }
}
