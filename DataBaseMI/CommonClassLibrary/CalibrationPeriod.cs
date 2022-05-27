using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonClassLibrary
{
    /// <summary>
    /// Периодичность калибровки СИ.
    /// </summary>
    [Index(nameof(Period), IsUnique = true, Name = "Индекс Периодичность калибровки СИ")] //д.б. уникальной
    public class CalibrationPeriod : ICloneable, IMiDependence
    {
        [Key]
        [Browsable(false)] //не будем выводить столбец в DataGridView
        public int Id { get; set; }

        /// <summary>
        /// Период калибровки
        /// </summary>
        [Required(ErrorMessage = "Не указан перод калибровки")]
        [MaxLength(25, ErrorMessage = "Длина строки 'Период калибровки' превышает допустимую величину (25 символов)")]
        [DisplayName("Период калибровки")] //Название заголовка столбца в DataGridView
        public string? Period { get; set; }


        public List<MeasuringInstrument> MeasuringInstruments { get; set; } = new();//навигационное свойство

        public object Clone()
        {
            CalibrationPeriod newObj = new CalibrationPeriod();
            newObj.Id = Id;
            newObj.Period = Period?.Substring(0, Period.Length); //копируем строку
            return newObj;
        }

        /// <summary>
        /// Сравнение двух объектов на равенство 
        /// </summary>
        public override bool Equals(object? obj)
        {   // если параметр метода представляет тип CalibrationPeriod И если поля совпадают, то возвращаем true
            if (obj is CalibrationPeriod calibrationPeriod)
                return Id == calibrationPeriod.Id
                             && string.Equals(Period?.ToUpper(), calibrationPeriod.Period?.ToUpper());

            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString() + Period).GetHashCode();
    }
}
