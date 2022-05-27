using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonClassLibrary
{
    /// <summary>
    /// Единица измерения
    /// </summary>
    [Index(nameof(Value), IsUnique = true, Name = "индекс Единица измерения")] //д.б. уникальной
    public class MeasurementUnit : ICloneable, IMiDependence
    {
        [Key]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int Id { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        [Required(ErrorMessage = "Не указана единицы измерения")]
        [MaxLength(25, ErrorMessage = "Длина строки, содержащей название единицы измерения превышает допустимую величину (25 символов)")]
        [DisplayName("Единица измерения")]
        public string? Value { get; set; }

        public List<MeasuringInstrument> MeasuringInstruments { get; set; } = new();//навигационное свойство

        public object Clone()
        {
            MeasurementUnit newObj = new MeasurementUnit();
            newObj.Id = Id;
            newObj.Value = Value?.Substring(0, Value.Length); //копируем строку
            return newObj;
        }

        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {
            // если параметр метода представляет нужный тип 
            // И если поля совпадают, то возвращаем true
            if (obj is MeasurementUnit measurementUnit)
                return Id == measurementUnit.Id
                    && string.Equals(Value?.ToUpper(), measurementUnit.Value?.ToUpper());

            return false;
        }

        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString() + Value).GetHashCode();
    }
}
