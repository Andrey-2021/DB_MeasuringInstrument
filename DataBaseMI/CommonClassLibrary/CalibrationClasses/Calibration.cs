using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonClassLibrary
{
    /// <summary>
    /// История поверок/калибровок
    /// </summary>
    [Index(nameof(Date), IsUnique = true, Name = "Дата калибровки СИ")] //д.б. уникальной. Считаем, что у СИ не м.б. несколько калибровок в один день
    public class Calibration : ICloneable, IValidatableObject
    {
        [Key]
        [Browsable(false)] //не выводить столбец в DataGridView
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
        [ForeignKey(nameof(MeasuringInstrumentId))]
        public MeasuringInstrument? MeasuringInstrument { get; set; } = null!; //(Навигационное свойство)

        /*
        /// <summary>
        /// Свойство для отображения в DataGridView вместо СИ;
        /// </summary>
        [DisplayName("СИ, инвентарный №")]
        [NotMapped]
        public string WhatSeeInsteadMeasuringInstrument => MeasuringInstrument?.DeviceName 
                + ", " 
                + MeasuringInstrument?.InventoryNumber;
        */


        /// <summary>
        /// Дата поверки/калибровки
        /// </summary>
        [Required(ErrorMessage = "Не указана дата поверки (калибровки)")]
        [DisplayName("Дата поверки/калибровки")]
        [Column(TypeName = "DATE")]
        //[DisplayFormat(DataFormatString ="{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode =true)]
        public DateTime Date { get; set; }

        /// <summary>
        /// результат калибровки
        /// </summary>
        [Required(ErrorMessage = "Не указан результат калибровки")]
        [MaxLength(40, ErrorMessage = "Длина строки 'результат калибровки' превышает допустимую величину (40 символов)")]
        [DisplayName("Результат")] //Название заголовка столбца в DataGridView
        public string? Rezult { get; set; }

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
                + ' '
                + (Calibrator?.Name?.Trim().Length>0 ? Calibrator?.Name?.Trim()[0]+"." : "")
                + (Calibrator?.MiddleName == null ? "" : (Calibrator?.MiddleName?.Trim().Length>0?Calibrator?.MiddleName?.Trim()[0] + ".":""));

        /// <summary>
        /// Дата следующей поверки/калибровки
        /// </summary>
        //[Required(ErrorMessage = "Не указана следующая дата поверки (калибровки)")]
        //todo если СИ неисправно, даты не должно быть
        [Column(TypeName = "DATE")] //Тип в БД MSSQL
        [DisplayName("Дата следующей поверки/калибровки")]
        //[Compare(nameof(Date))]
        public DateTime? NextCalibrationDate { get; set; }


        //проверка дат калибровки
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (NextCalibrationDate != null)
            {
                int result = DateTime.Compare(Date, NextCalibrationDate!.Value);
                if (result > 0)
                {
                    yield return new ValidationResult("Дата следующей поверки/калибровки должна быть больше текущей даты поверки/калибровки!", new[] { "Исправьте!" });
                }
            }
        }


        /// <summary>
        /// Конструктор
        /// </summary>
        public Calibration()
        {
            Date = DateTime.Now; //при создании объекта, задаём текущую дату
        }


        public virtual object Clone()
        {
            Calibration newObj = (Calibration)this.MemberwiseClone();
            newObj.MeasuringInstrument = this.MeasuringInstrument?.Clone() as MeasuringInstrument;
            newObj.MeasuringInstrumentId = newObj?.MeasuringInstrument?.Id;
            newObj!.Calibrator = this.Calibrator?.Clone() as Calibrator;
            newObj.CalibratorId = newObj?.Calibrator?.Id;
            newObj!.Rezult = Rezult?.Substring(0, Rezult.Length); //копируем строку
            return newObj;
        }

        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {
            // если параметр метода представляет нужный тип И если поля совпадают, то возвращаем true
            if (obj is Calibration cl)
                return Id == cl.Id
                    && string.Equals(Rezult?.ToUpper(), cl.Rezult?.ToUpper())
                    && MeasuringInstrumentId == cl.MeasuringInstrumentId
                    && MeasuringInstrument!.Equals(cl.MeasuringInstrument)
                    && CalibratorId == cl.CalibratorId
                    && Calibrator!.Equals(cl.Calibrator)
                    && Date == cl.Date
                    && NextCalibrationDate == cl.NextCalibrationDate;
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id
                                                + Date.ToString()
                                                + NextCalibrationDate.ToString()).GetHashCode();
    
    
    
    
    }

    /*
    public class CalibrationValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is Calibration calibration)
            {
                if 
                if (user.Name == "Tom" && user.Age == 37)
                {
                    ErrorMessage = "Имя не должно быть Tom и возраст одновременно не должен быть равен 37";
                    return false;
                }
                return true;
            }
            return false;
        }
    }
    */
}
