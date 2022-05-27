using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Xml.Serialization;

namespace CommonClassLibrary
{
    /// <summary>
    /// Фотография СИ
    /// </summary>
    [Serializable]
    public class Photo : ICloneable
    {
        [Key]
        [Browsable(false)]
        public int Id { get; set; }

        /// <summary>
        /// Название картинки
        /// </summary>
        [DisplayName("Название картинки")]
        [MaxLength(30, ErrorMessage = "Длина названия картинки превышает допустимую величину (30 символов)")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Не указано СИ")]
        [Browsable(false)] //не выводить столбец в DataGridView
        public int MeasuringInstrumentId { get; set; }

        [Browsable(false)]
        public MeasuringInstrument? MeasuringInstrument { get; set; }

        /// <summary>
        /// Картинка
        /// </summary>
        public byte[]? BytePicture { get; set; }

        [XmlIgnore]
        [NotMapped]
        public Image? Image
        {
            get
            {
                //преобразуем массив байт в картинку
                if (BytePicture != null && BytePicture.Length > 0)
                {
                    ImageConverter imageConverter = new ImageConverter();
                    Object? image = imageConverter.ConvertFrom((object)BytePicture);
                    return (Image?)image;
                }
                else return null;

            }
            set //преобразуем картинку в массив байт
            {
                if (value != null)
                {
                    ImageConverter imageConverter = new ImageConverter();
                    BytePicture = (byte[]?)imageConverter.ConvertTo(value, typeof(byte[]));
                }
            }
        }

        public object Clone()
        {
            Photo newObj = new Photo(); //)this.MemberwiseClone();
            newObj.Id = this.Id;
            newObj.Name = Name?.Substring(0, Name.Length); //копируем строку
            //newObj.MeasuringInstrument = this.MeasuringInstrument?.Clone() as MeasuringInstrument;
            newObj.MeasuringInstrument = this.MeasuringInstrument;
            newObj.MeasuringInstrumentId = this.MeasuringInstrumentId;

            if (this.BytePicture?.Length > 0)
            {
                newObj.BytePicture = new byte[BytePicture.Length];
                BytePicture?.CopyTo(newObj.BytePicture, 0);
            }
            return newObj;
        }

        //сравнение двух объектов на равенство
        public override bool Equals(object? obj)
        {
            if (obj is Photo picture) // если параметр метода представляет этот тип И если поля совпадают, то возвращаем true
            {
                if (BytePicture == null && picture.BytePicture == null) return true;
                if ((BytePicture != null && picture.BytePicture == null)
                    || (BytePicture == null && picture.BytePicture != null)) return false;

                return
                    Id == picture.Id
                    && ByteArrayCompareWithSimplest(BytePicture, picture.BytePicture!)
                    && string.Equals(Name?.ToUpper(), picture.Name?.ToUpper());
            }

            return false;
        }
        // вместе с методом Equals следует реализовать метод GetHashCode
        public override int GetHashCode() => (Id + BytePicture?.GetHashCode()).GetHashCode();

        /// <summary>
        /// Сравнение двух массивов
        /// </summary>
        /// <param name="first">Первый массив</param>
        /// <param name="second">Второй массив</param>
        /// <returns></returns>
        private bool ByteArrayCompareWithSimplest(byte[]? first, byte[]? second)
        {
            if (first == null && second == null) return true;
            if ((first != null && second == null)
                || (first == null && second != null)) return false;

            if (first?.Length != second?.Length)
                return false;

            var length = first?.Length;

            for (int i = 0; i < length; i++)
            {
                if (first?[i] != second?[i])
                    return false;
            }

            return true;
        }
    }
}
