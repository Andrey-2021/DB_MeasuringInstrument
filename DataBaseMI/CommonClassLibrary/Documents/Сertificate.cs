
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonClassLibrary
{
    /// <summary>
    /// Свидетельство о поверке
    /// </summary>
    public class Сertificate : BaseForCertificate, ICloneable
    {
        /// <summary>
        /// Наименования юр.лица/инд.предпринимателя
        /// </summary>
        [Required(ErrorMessage = "Не указано ")]
        [MaxLength(100, ErrorMessage = "Длина строки, содержащей наименования юр.лица(инд.предпринимателя) превышает допустимую величину (100 символов)")]
        [DisplayName("юр.лицо/инд.предприн.")]
        public string? Businessman { get; set; }

        /// <summary>
        /// Дата, до которой действительно свидетельство
        /// </summary>
        [Required(ErrorMessage = "Не указана дата, до которой действительно свидетельство")]
        [DisplayName("Действителен до")]
        [Column(TypeName = "DATE")] //Тип в БД MSSQL
        public DateTime ActiveDate { get; set; }


        /// <summary>
        /// Наименования величин, диапазонов, на которых поверено средство
        /// </summary>
        //[Required(ErrorMessage = "Не указано ")]
        [MaxLength(100, ErrorMessage = "Длина строки, содержащей наименования величин, диапазонов, на которых поверено средство превышает допустимую величину (100 символов)")]
        [DisplayName("Величины поверки")]
        public string? Values{ get; set; }



        /// <summary>
        /// Эталон
        /// </summary>
        [Required(ErrorMessage = "Не указана информация по эталону")]
        [MaxLength(100, ErrorMessage = "Длина строки, содержащей информацию по эталону измерения превышает допустимую величину (100 символов)")]
        [DisplayName("Эталон")]
        public string? Standard { get; set; }

        /// <summary>
        /// Факторы
        /// </summary>
        [Required(ErrorMessage = "Не указана информация по влияющим факторам")]
        [MaxLength(100, ErrorMessage = "Длина строки, содержащей информацию по факторам превышает допустимую величину (100 символов)")]
        [DisplayName("Факторы")]
        public string? Factors { get; set; }

        /// <summary>
        /// Знак поверки
        /// </summary>
        [Required(ErrorMessage = "Не указан знак поверки")]
        [MaxLength(50, ErrorMessage = "Длина знака поверки превышает допустимую величину (50 символов)")]
        [DisplayName("Знак поверки")]
        public string? Mark { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Сertificate()
        {
            Date = DateTime.Now; //при создании объекта, задаём текущую дату
            ActiveDate = DateTime.Now; //при создании объекта, задаём текущую дату
        }

        public override object Clone()
        {
            Сertificate? newObj = (Сertificate)MemberwiseClone();
            newObj.Standard = Standard?.Substring(0, Standard.Length); //копируем строку
            newObj.Factors = Factors?.Substring(0, Factors.Length);
            newObj.Mark = Mark?.Substring(0, Mark.Length);
            return newObj;
        }

        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {// если параметр метода представляет нужный тип И если поля совпадают, то возвращаем true
            if (obj is Сertificate cer)
                return Id == cer.Id
                    && base.Equals(obj)
                     && string.Equals(Standard?.ToUpper(), cer.Standard?.ToUpper())
                     && string.Equals(Factors?.ToUpper(), cer.Factors?.ToUpper())
                     && string.Equals(Mark?.ToUpper(), cer.Mark?.ToUpper());

            return false;
        }

        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString()
                                                + Number
                                                + Mark).GetHashCode();
    }
}
