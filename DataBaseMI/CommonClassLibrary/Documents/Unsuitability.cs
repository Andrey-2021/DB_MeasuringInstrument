using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonClassLibrary
{
    /// <summary>
    /// Извещения о непригодности к применению
    /// </summary>
    public class Unsuitability : BaseForCertificate, ICloneable
    {
        /// <summary>
        /// Причины непригодности
        /// </summary>
        [Required(ErrorMessage = "Не указаны причины непригодности СИ")]
        [MaxLength(250, ErrorMessage = "Длина строки, содержащей информацию о причинах непригодности СИ превышает допустимую величину (250 символов)")]
        [DisplayName("Причины непригодности")]
        public string? UnsuitabilityReasons { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Unsuitability()
        {
            Date = DateTime.Now; //при создании объекта, задаём текущую дату
        }

        public override object Clone()
        {
            Unsuitability? newObj = (Unsuitability)MemberwiseClone();
            newObj.UnsuitabilityReasons = UnsuitabilityReasons?.Substring(0, UnsuitabilityReasons.Length); //копируем строку
            return newObj;
        }

        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {// если параметр метода представляет нужный тип И если поля совпадают, то возвращаем true
            if (obj is Unsuitability unsuitability)
                return Id == unsuitability.Id
                    && base.Equals(obj)
                     && string.Equals(UnsuitabilityReasons?.ToUpper(), unsuitability.UnsuitabilityReasons?.ToUpper());
            
            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id.ToString()
                                                + Number
                                                + UnsuitabilityReasons).GetHashCode();
    }
}
