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
    /// Текущее состояние СИ
    /// </summary>
    [Index(nameof(State), IsUnique = true, Name = "индекс Текущее состояние СИ")] //д.б. уникальной
    public class DeviceState : ICloneable, IMiDependence
    {
        [Key]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int Id { get; set; }

        /// <summary>
        /// Состояние (Название) 
        /// </summary>
        [Required(ErrorMessage = "Не указано название состояния СИ")]
        [MaxLength(30, ErrorMessage = "Длина строки названия состояния СИ превышает допустимую величину (30 символов)")]
        [DisplayName("Состояние")]
        public string? State { get; set; }

        public List<MeasuringInstrument> MeasuringInstruments { get; set; } = new();//навигационное свойство
        public object Clone()
        {
            DeviceState newObj = new DeviceState();
            newObj.Id = Id;
            newObj.State = State?.Substring(0, State.Length); //копируем строку
            return newObj;
        }


        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {
            if (obj is DeviceState deviceState) // если параметр метода представляет нужный тип  И если поля совпадают, то возвращаем true
                return Id == deviceState.Id
                            && string.Equals(State?.ToUpper(), deviceState.State?.ToUpper());
                    
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString()+ State).GetHashCode();


        //переопределяем метод ToString()
        public override string? ToString()
        {
            return State;
        }
    }
}
