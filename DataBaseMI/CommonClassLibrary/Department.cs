using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace CommonClassLibrary
{
    /// <summary>
    /// Местоположение, подразделение
    /// </summary>
    [Index(nameof(Name), IsUnique = true, Name = "индекс Местоположение")] //д.б. уникальной
    public class Department : ICloneable, IMiDependence
    {
        [Key]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int Id { get; set; }

        /// <summary>
        /// Местоположение
        /// </summary>
        [Required(ErrorMessage = "Не указано местоположение СИ")]
        [MaxLength(40, ErrorMessage = "Длина строки, содержащей название местоположения превышает допустимую величину (40 символов)")]
        [DisplayName("Местоположение")] //Название заголовка столбца в DataGridView
        public string? Name { get; set; }

        /// <summary>
        /// Подразделение
        /// </summary>
        [Required(ErrorMessage = "Не указано подразделение")]
        [MaxLength(10, ErrorMessage = "Длина строки, содержащей название подразделения превышает допустимую величину (10 символов)")]
        [DisplayName("Подразделение")]
        public string? SubdevisionNumber { get; set; }

        public List<MeasuringInstrument> MeasuringInstruments { get; set; } = new();//навигационное свойство
        public object Clone()
        {
            Department newObj = (Department)this.MemberwiseClone();
            newObj.Name = Name?.Substring(0, Name.Length); //копируем строку
            newObj.SubdevisionNumber = SubdevisionNumber?.Substring(0, SubdevisionNumber.Length);
            return newObj;
        }

        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {
            if (obj is Department department) // если параметр метода представляет нужный тип  И если поля совпадают, то возвращаем true
                return Id == department.Id
                    && string.Equals(Name?.ToUpper(), department.Name?.ToUpper())
                    && string.Equals(SubdevisionNumber?.ToUpper(), department.SubdevisionNumber?.ToUpper());
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString()+ Name).GetHashCode();
        
        public override string? ToString()//переопределяем метод ToString()
        {
            return Name+"/"+ SubdevisionNumber;
        }
    }
}
