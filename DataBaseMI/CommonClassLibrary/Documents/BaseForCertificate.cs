
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CommonClassLibrary
{
    /// <summary>
    /// Базовый класс для классов 
    /// 1) Извещение о непригодности СИ
    /// 2) Свидетельства о поверке СИ
    /// </summary>
    [Index(nameof(Number), IsUnique = true, Name = "номер извещения")] //д.б. уникальной
    public abstract class BaseForCertificate
    {
        [Key]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int Id { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        [Required(ErrorMessage = "Не указан номер документа")]
        [MaxLength(15, ErrorMessage = "Длина номера документа превышает допустимую величину (15 символов)")]
        [DisplayName("№ документа")]
        public string? Number { get; set; }

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
        /// Дополнительная информация по СИ
        /// </summary>
        [MaxLength(50, ErrorMessage = "Длина информации по СИ превышает допустимую величину (50 символов)")]
        [DisplayName("Информация по СИ")]
        public string? Info { get; set; }

        /// <summary>
        /// Наименование документа, на основании которого выполнена проверка
        /// </summary>
        [MaxLength(50, ErrorMessage = "Длина наименования документа, на основании которого выполнена проверка СИ превышает допустимую величину (50 символов)")]
        [DisplayName("Пров. выполнена на основании")]
        public string? Document { get; set; }

        /// <summary>
        /// Должность руководителя
        /// </summary>
        [Required(ErrorMessage = "Не указана должность руководителя")]
        [MaxLength(50, ErrorMessage = "Длина названия должности руководителя превышает допустимую величину (50 символов)")]
        [DisplayName("Должность руководителя")]
        public string? Job { get; set; }

        /// <summary>
        /// Руководитель ФИО
        /// </summary>
        [Required(ErrorMessage = "Не указан руководитель")]
        [MaxLength(30, ErrorMessage = "Длина Ф.И.О. руководителя превышает допустимую величину (30 символов)")]
        [DisplayName("Руководитель")]
        public string? Director { get; set; }

        /// <summary>
        /// Поверитель
        /// </summary>
        [Required(ErrorMessage = "Не указан поверитель")]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int? CalibratorId { get; set; } // (3) (Внешний ключ)

        /// <summary>
        /// Поверитель
        /// </summary>
        [Browsable(false)]
        public Calibrator? Calibrator { get; set; } = null!; //(Навигационное свойство)

        /// <summary>
        /// Свойство для отображения в DataGridView вместо Поверителя;
        /// </summary>
        [DisplayName("Поверитель")]
        [NotMapped]
        public string WhatSeeInsteadCalibrator =>
                Calibrator?.Surname
                +" "
                + Calibrator?.Name?.Trim()[0]+"."
                + ( Calibrator?.MiddleName!=null && Calibrator?.MiddleName?.Length>0 ? " "+ Calibrator?.MiddleName?.Trim()[0]+"." :"");
                
                //+ (Calibrator?.MiddleName.Trim()[0] ?? ". "Calibrator?.MiddleName?.Trim()[0]?"")
                // +". "
                //+ Calibrator?.MiddleName?.Trim()[0];

        /// <summary>
        /// Дата составления
        /// </summary>
        [Required(ErrorMessage = "Не указана дата составления")]
        [DisplayName("Дата")]
        [Column(TypeName = "DATE")] //Тип в БД MSSQL
        public DateTime Date { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public BaseForCertificate()
        {
            Date = DateTime.Now; //при создании объекта, задаём Date текущую дату
        }

        public virtual object Clone()
        {
            BaseForCertificate newObj = (BaseForCertificate)this.MemberwiseClone();
            newObj.Number = Number?.Substring(0, Number.Length); //копируем строку
            newObj.Info = Info?.Substring(0, Info.Length);
            newObj.Document = Document?.Substring(0, Document.Length);
            newObj.Job = Job?.Substring(0, Job.Length);
            newObj.Director = Director?.Substring(0, Director.Length);

            newObj.MeasuringInstrument = this.MeasuringInstrument?.Clone() as MeasuringInstrument;
            newObj.MeasuringInstrumentId = this.MeasuringInstrumentId;

            newObj.Calibrator = this.Calibrator?.Clone() as Calibrator;
            newObj.CalibratorId = this.CalibratorId;
            return newObj;
        }

        /// <summary>
        /// сравнение двух объектов на равенство
        /// </summary>
        public override bool Equals(object? obj)
        {// если параметр метода представляет этот тип // И если поля совпадают, то возвращаем true
            if (obj is BaseForCertificate parent)
                return
                     Id == parent.Id
                     && string.Equals(Number?.ToUpper(), parent.Number?.ToUpper())
                     && string.Equals(Info?.ToUpper(), parent.Info?.ToUpper())
                     && string.Equals(Document?.ToUpper(), parent.Document?.ToUpper())
                     && string.Equals(Job?.ToUpper(), parent.Job?.ToUpper())
                     && string.Equals(Director?.ToUpper(), parent.Director?.ToUpper())
                     && CalibratorId == parent.CalibratorId
                     && Calibrator!.Equals(parent.Calibrator)
                     && MeasuringInstrumentId == parent.MeasuringInstrumentId
                     && MeasuringInstrument!.Equals(parent.MeasuringInstrument);
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString() 
                                                + Number).GetHashCode();
    }
}
