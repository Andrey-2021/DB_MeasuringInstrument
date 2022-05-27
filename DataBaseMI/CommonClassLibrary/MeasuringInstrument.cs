using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CommonClassLibrary
{
    /// <summary>
    /// Средство измерения (СИ)
    /// </summary>
    [Index(nameof(InventoryNumber), IsUnique = true, Name ="Инвентарный номер")] //Инвентарный номер д.б. уникальным
    public class MeasuringInstrument : ICloneable
    {
        /// <summary>
        /// Номер паспорта
        /// </summary>
        [Key]
        [DisplayName("№ паспорта")]
        public int Id { get; set; } //(1)

        /// <summary>
        /// Наименованиеие СИ
        /// </summary>
        [Required(ErrorMessage = "Не указано название прибора")]
        [MaxLength(120, ErrorMessage = "Длина строки 'Название прибора' превышает допустимую величину (120 символов)")]
        [DisplayName("Наименование")] //Название заголовка столбца в DataGridView
        public string? DeviceName { get; set; } //(2)

        /// <summary>
        /// Местоположение
        /// </summary>
        [Required(ErrorMessage = "Не указано местоположение СИ")]
        [Browsable(false)]
        public int? DepartmentId { get; set; } // (3) (Внешний ключ)
        /// <summary>
        /// Местоположение
        /// </summary>
        //[Browsable(false)]
        [DisplayName("Местоположение")]
        public virtual Department? Department { get; set; } //(Навигационное свойство)

        /// <summary>
        /// Дата поступления прибора в эксплуатацию
        /// </summary>
        [Required(ErrorMessage = "Не указано дата поступления прибора в эксплуатацию")]
        [DisplayName("Поступление")]
        [Browsable(false)]
        public DateTime UseDate { get; set; } //(4)

        /// <summary>
        /// Периодичность проверки прибока (Период калибровки)
        /// </summary>
        [Required(ErrorMessage = "Не указан период поверки (калибровки) СИ")]
        [Browsable(false)]
        public int? CalibrationPeriodId { get; set; } //(5)   (Внешний ключ) 

        /// <summary>
        /// Период калибровки
        /// </summary>
        [Browsable(false)]
        public CalibrationPeriod? CalibrationPeriod { get; set; } //(Навигационное свойство)

        /// <summary>
        /// Завод изготовитель 
        /// </summary>
        [Required(ErrorMessage = "Не указан завод изготовитель СИ")]
        [Browsable(false)]
        public int? ManufacturerID { get; set; } //(6)    (Внешний ключ)

        /// <summary>
        /// Завод изготовитель 
        /// </summary>
        [Browsable(false)]
        public virtual Manufacturer? Manufacturer { get; set; } //  (Навигационное свойство)

        /// <summary>
        /// Заводской номер
        /// </summary>
        [Required(ErrorMessage = "Не указан заводской номер")]
        [MaxLength(20, ErrorMessage = "Длина строки 'Заводской номер' превышает допустимую величину (20 символов)")]
        [DisplayName("Заводской номер")]
        public string? ManufacturerNumber { get; set; } //(7) допускается буквенно-цифровое обозначение

        /// <summary>
        /// Инвентарный номер
        /// </summary>
        [Required(ErrorMessage = "Не указан инвентарный номер")]
        [MaxLength(20, ErrorMessage = "Длина строки 'Инвентарный номер' превышает допустимую величину (20 символов)")]
        [DisplayName("Инвентарный номер")]
        public string? InventoryNumber { get; set; } //(8)

        /// <summary>
        /// Тип СИ. 
        /// </summary>
        [Required(ErrorMessage = "Не указан тип СИ")]
        [Browsable(false)]
        public int? DeviceTypeId { get; set; } // (9) (Внешний ключ)

        /// <summary>
        /// Тип СИ. 
        /// </summary>
        //[Browsable(false)]
        [DisplayName("Тип СИ")]
        public DeviceType? DeviceType { get; set; } //(Навигационное свойство)

        /// <summary>
        /// Пределы измерения
        /// </summary>
        [Required(ErrorMessage = "Не указаны пределы измерения СИ")]
        [MaxLength(30, ErrorMessage = "Длина строки 'Пределы измерения' превышает допустимую величину (30 символов)")]
        //[DisplayName("Пределы измерения")]
        [Browsable(false)]
        public string? WorkRange { get; set; } //(10)

        /// <summary>
        /// Единица измерения
        /// </summary>
        [Required(ErrorMessage = "Не указана единица измерения")]
        [Browsable(false)]
        public int? MeasurementUnitId { get; set; } // (10.1) (Внешний ключ)

        /// <summary>
        /// Единица измерения
        /// </summary>
        [Browsable(false)]
        public virtual MeasurementUnit? MeasurementUnit { get; set; } //(Навигационное свойство)

        /// <summary>
        /// Цена деления шкалы
        /// </summary>
        [Required(ErrorMessage = "Не указана цена деления шкалы")]
        [MaxLength(30, ErrorMessage = "Длина строки 'Цена деления шкалы' превышает допустимую величину (30 символов)")]
        //[DisplayName("Цена деления шкалы")]
        [Browsable(false)]
        public string? ScaleStep { get; set; }  //(11)

        /// <summary>
        /// Класс или допускаемая погрешность
        /// </summary>
        [Required(ErrorMessage = "Не указан класс (или допускаемая погрешность) СИ")]
        [MaxLength(20, ErrorMessage = "Длина строки 'Класс или допускаемая погрешность' превышает допустимую величину (20 символов)")]
        //[DisplayName("Класс или допускаемая погрешность")]
        [Browsable(false)]
        public string? Error { get; set; }  //(12)

        /// <summary>
        /// Перечень основных частей комплекта
        /// </summary>
        [MaxLength(200, ErrorMessage = "Длина строки 'Перечень основных частей комплекта' превышает допустимую величину (200 символов)")]
        //[DisplayName("Перечень частей комплекта")]
        [Browsable(false)]
        public string? MainPartsList { get; set; }  //(13)

        /// <summary>
        /// Текущее состояние прибора
        /// </summary>
        [Required(ErrorMessage = "Не указано текущее состояние прибора")]
        [Browsable(false)]
        public int? DeviceStateId { get; set; } // (9) (Внешний ключ)

        /// <summary>
        /// Текущее Состояние прибора
        /// </summary>
        //[Browsable(false)]
        [DisplayName("Текущее состояние СИ")]
        public virtual DeviceState? DeviceState { get; set; } //(Навигационное свойство)

        /// <summary>
        /// Фотография СИ
        /// </summary>
        //[DisplayName("Фото")]
        [Browsable(false)]
        public Photo? Photo { get; set; }

        
        public List<Calibration>Calibrations { get; set; } = new();//навигационное свойство

        /// <summary>
        /// Конструктор
        /// </summary>
        public MeasuringInstrument()
        {
            UseDate = DateTime.Now; //при создании объекта, задаём UseDate текущую дату
        }


        // для копирования строк не рекомендуется использовать string.Copy();
        // поэтому используем Substring()
        // https://docs.microsoft.com/ru-ru/dotnet/api/system.string.copy?f1url=%3FappId%3DDev16IDEF1%26l%3DRU-RU%26k%3Dk(System.String.Copy);k(DevLang-csharp)%26rd%3Dtrue&view=net-6.0

        public object Clone()
        {
            MeasuringInstrument newObj = (MeasuringInstrument)this.MemberwiseClone();
            
            newObj.DeviceName = DeviceName?.Substring(0, DeviceName.Length); //string.Copy(DeviceName);
            newObj.Department = this.Department?.Clone() as Department;
            newObj.CalibrationPeriod = CalibrationPeriod?.Clone() as CalibrationPeriod;
            newObj.Manufacturer = Manufacturer?.Clone() as Manufacturer;
            newObj.ManufacturerNumber = ManufacturerNumber?.Substring(0, ManufacturerNumber.Length);
            newObj.InventoryNumber = InventoryNumber?.Substring(0, InventoryNumber.Length);
            newObj.DeviceType = DeviceType?.Clone() as DeviceType;
            newObj.WorkRange = WorkRange?.Substring(0, WorkRange.Length);
            newObj.MeasurementUnit = MeasurementUnit?.Clone() as MeasurementUnit;
            newObj.ScaleStep = ScaleStep?.Substring(0, ScaleStep.Length);
            newObj.Error = Error?.Substring(0, Error.Length);
            newObj.MainPartsList = MainPartsList?.Substring(0, MainPartsList.Length);
            newObj.DeviceState = DeviceState?.Clone() as DeviceState;
            newObj.Photo = Photo?.Clone() as Photo;
          
            return newObj;
        }


        //! (нулевой прощающий) оператор (справочник по C#)  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
        
        /// <summary>
        /// Сравнение двух объектов на равенство 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is MeasuringInstrument mI)// если параметр метода представляет этот тип И если поля совпадают, то возвращаем true
                return
                    Id == mI.Id
                    && string.Equals(DeviceName?.ToUpper(), mI.DeviceName?.ToUpper())
                    && DepartmentId==mI.DepartmentId
                    && Department!.Equals(mI.Department)
                    && CalibrationPeriodId == mI.CalibrationPeriodId
                    && CalibrationPeriod!.Equals(mI.CalibrationPeriod)
                    && ManufacturerID == mI.ManufacturerID
                    && Manufacturer!.Equals(mI.Manufacturer)
                    && string.Equals(ManufacturerNumber?.ToUpper(), mI.ManufacturerNumber?.ToUpper())
                    && string.Equals(InventoryNumber?.ToUpper(), mI.InventoryNumber?.ToUpper())
                    && DeviceTypeId == mI.DeviceTypeId
                    && DeviceType!.Equals(mI.DeviceType)
                    && string.Equals(WorkRange?.ToUpper(), mI.WorkRange?.ToUpper())
                    && MeasurementUnitId == mI.MeasurementUnitId
                    && MeasurementUnit!.Equals(mI.MeasurementUnit)
                    && string.Equals(ScaleStep?.ToUpper(), mI.ScaleStep?.ToUpper())
                    && string.Equals(Error?.ToUpper(), mI.Error?.ToUpper())
                    && string.Equals(MainPartsList?.ToUpper(), mI.MainPartsList?.ToUpper())
                    && DeviceStateId == mI.DeviceStateId
                    && DeviceState!.Equals(mI.DeviceState)
                    && CheckEqualsePhotos(Photo, mI.Photo);

            return false;
        }


        bool CheckEqualsePhotos(Photo? photo, Photo? miPhoto)
        {
            if (photo == null && miPhoto == null) return true;
            if ((photo != null && miPhoto == null)
                || (photo == null && miPhoto != null)) return false;

                //(if (Photo == null && mI.Photo == null) true //  Photo ==null?true: Photo!.Equals(mI?.Photo)
                return Photo.Equals(miPhoto);
            //return true;
        }


        // вместе с методом Equals следует реализовать метод GetHashCode. Используем "Инвентарный номер" т.к. он уникальный в БД 
        public override int GetHashCode() => (Id.ToString() 
                                                + DeviceName
                                                + ManufacturerNumber
                                                + InventoryNumber
                                                + WorkRange
                                                + ScaleStep
                                                + Error
                                                + MainPartsList
                                                + DepartmentId
                                                + CalibrationPeriodId
                                                + ManufacturerID
                                                + DeviceTypeId
                                                + MeasurementUnitId
                                                + DeviceStateId
                                                ).GetHashCode();
    }
}
