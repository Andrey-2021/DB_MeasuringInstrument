using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonClassLibrary
{
    /// <summary>
    /// Произведённый ремонт.
    /// (ремонт, ТО, ревизия, чистка и другие манипуляции с данным прибором.)
    /// </summary>
    public class Repair : ICloneable
    {
        [Key]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int Id { get; set; }

        /// <summary>
        /// Средство измерения
        /// </summary>
        [Required(ErrorMessage = "Не указано СИ")]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int? MeasuringInstrumentId { get; set; } //(Внешний ключ)

        /// <summary>
        /// Средство измерения
        /// </summary>
        [Browsable(false)]
        public MeasuringInstrument? MeasuringInstrument { get; set; } //(Навигационное свойство)

        /// <summary>
        /// Дата выполнения
        /// </summary>
        [Required(ErrorMessage = "Не указана дата ремонта")]
        [DisplayName("Дата выполнения")]
        [Column(TypeName = "DATE")] //Тип в БД MSSQL
        public DateTime Date { get; set; }

        /// <summary>
        /// Описание, характеристика
        /// </summary>
        [Required(ErrorMessage = "Не указано описание (характеристика) ремонта")]
        [MaxLength(90, ErrorMessage = "Длина описания (характеристики) ремонта превышает допустимую величину (90 символов)")]
        [DisplayName("Описание (характеристика)")] //Название заголовка столбца в DataGridView
        public string? Description { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Repair()
        {
            Date = DateTime.Now; //при создании объекта, задаём текущую дату
        }

        public virtual object Clone()
        {
            Repair newObj = (Repair)MemberwiseClone();
            newObj.MeasuringInstrument = this.MeasuringInstrument?.Clone() as MeasuringInstrument;
            newObj.MeasuringInstrumentId = this.MeasuringInstrumentId;
            newObj!.Description = Description?.Substring(0, Description.Length); //копируем строку
            return newObj;
        }

        public override bool Equals(object? obj)
        {
            // если параметр метода представляет нужный тип И если поля совпадают, то возвращаем true
            if (obj is Repair repair)
                return Id == repair.Id
                    && MeasuringInstrumentId == repair.MeasuringInstrumentId
                    && Date == repair.Date
                    && Description == repair.Description;

            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id
                                                + MeasuringInstrumentId
                                                + Date.ToString()
                                                + Description).GetHashCode();
    }
}
