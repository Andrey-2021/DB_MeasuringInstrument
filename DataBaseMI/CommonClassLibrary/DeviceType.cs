using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CommonClassLibrary
{
    /// <summary>
    /// Тип СИ
    /// </summary>
    [Index(nameof(TypeName), IsUnique = true, Name = "индекс Тип СИ")] //д.б. уникальной
    public class DeviceType : ICloneable, IMiDependence
    {
        [Key]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int Id { get; set; }

        /// <summary>
        /// Название типа СИ
        /// </summary>
        [Required(ErrorMessage = "Не указано название типа СИ")]
        [MaxLength(30, ErrorMessage = "Длина строки названия типа СИ превышает допустимую величину (30 символов)")]
        [DisplayName("Название типа СИ")]
        public string? TypeName { get; set; }

        public List<MeasuringInstrument> MeasuringInstruments { get; set; } = new();//навигационное свойство

        public object Clone()
        {
            DeviceType newObj = new DeviceType();
            newObj.Id = Id;
            newObj.TypeName = TypeName?.Substring(0, TypeName.Length); //копируем строку
            return newObj;
        }

        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {
            
            if (obj is DeviceType deviceType)// если параметр метода представляет этот тип И если поля совпадают, то возвращаем true
                return Id == deviceType.Id
                            && string.Equals(TypeName?.ToUpper(), deviceType.TypeName?.ToUpper());
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() =>(Id.ToString()+ TypeName).GetHashCode();


        //переопределяем метод ToString()
        public override string? ToString()
        {
            return TypeName;
        }
    }
}
