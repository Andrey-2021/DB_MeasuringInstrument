using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CommonClassLibrary
{
    /// <summary>
    /// Завод изготовитель
    /// </summary>
    [Index(nameof(Name), IsUnique = true, Name = "индекс Название завода изготовителя СИ")] //д.б. уникальной
    public class Manufacturer : ICloneable, IMiDependence
    {
        [Key]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [Required(ErrorMessage = "Не указано название")]
        [MaxLength(300, ErrorMessage = "Длина названия превышает допустимую величину (300 символов)")]
        [DisplayName("Название")]
        public string? Name { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        [Required(ErrorMessage = "Не указана страна")]
        [MaxLength(50, ErrorMessage = "Длина названия страны превышает допустимую величину (50 символов)")]
        [DisplayName("Страна")]
        public string? Country { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        [MaxLength(50, ErrorMessage = "Длина названия города превышает допустимую величину (50 символов)")]
        [DisplayName("Город")]
        public string? City { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        [MaxLength(150, ErrorMessage = "Длина адреса превышает допустимую величину (150 символов)")]
        //[DisplayName("Адрес")]
        [Browsable(false)]
        public string? Address { get; set; }

        /// <summary>
        /// Адрес страницы в интернете
        /// </summary>
        [MaxLength(25, ErrorMessage = "Длина строки, содержащей адрес страницы в интернете превышает допустимую величину (25 символов)")]
        [Url(ErrorMessage = "Некорретно ввели адрес страницы в интернете")]
        [DisplayName("Сайт")]
        public string? UrlAddress { get; set; }

        /// <summary>
        /// e-mail
        /// </summary>
        [MaxLength(25, ErrorMessage = "Длина e-mail превышает допустимую величину (25 символов)")]
        [EmailAddress(ErrorMessage ="Некорретно ввели e-mail")]
        [DisplayName("e-mail")]
        public string? EMail { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        [MaxLength(250, ErrorMessage = "Длина описания превышает допустимую величину (250 символов)")]
        //[DisplayName("Описание")]
        [Browsable(false)]
        public string? Description { get; set; }

        public List<MeasuringInstrument> MeasuringInstruments { get; set; } = new();//навигационное свойство

        public object Clone()
        {
            Manufacturer newObj = new Manufacturer();
            newObj.Id = Id;
            newObj.Name = Name?.Substring(0, Name.Length); //копируем строку
            newObj.Country = Country?.Substring(0, Country.Length);
            newObj.City = City?.Substring(0, City.Length);
            newObj.Address = Address?.Substring(0, Address.Length);
            newObj.UrlAddress= UrlAddress?.Substring(0, UrlAddress.Length);
            newObj.EMail = EMail?.Substring(0, EMail.Length);
            return newObj;
        }


        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {
            if (obj is Manufacturer mn)
                return Id == mn.Id
                    && string.Equals(Name?.ToUpper(), mn.Name?.ToUpper())
                    && string.Equals(Country?.ToUpper(), mn.Country?.ToUpper())
                    && string.Equals(City?.ToUpper(), mn.City?.ToUpper())
                    && string.Equals(Address?.ToUpper(), mn.Address?.ToUpper())
                    && string.Equals(UrlAddress?.ToUpper(), mn.UrlAddress?.ToUpper())
                    && string.Equals(EMail?.ToUpper(), mn.EMail?.ToUpper());
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString()+ Name).GetHashCode();
    }
}

