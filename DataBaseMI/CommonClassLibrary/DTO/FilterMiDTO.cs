using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClassLibrary
{
    public class FilterMiDTO
    {
        /// <summary>
        /// Наименованиеие прибора
        /// </summary>
        public string? DeviceName { get; set; } //(2)

        /// <summary>
        /// Заводской номер
        /// </summary>
        public string? ManufacturerNumber { get; set; }

        /// <summary>
        /// Инвентарный номер
        /// </summary>
        public string? InventoryNumber { get; set; }

        /// <summary>
        /// Тип СИ. 
        /// </summary>
        public int? DeviceTypeId { get; set; } // (9) (Внешний ключ)
        public DeviceType? DeviceType { get; set; } //(Навигационное свойство)


        /// <summary>
        /// Текущее состояние прибора
        /// </summary>
        public int? DeviceStateId { get; set; } // (9) (Внешний ключ)
        public virtual DeviceState? DeviceState { get; set; } //(Навигационное свойство)

        /// <summary>
        /// Местоположение
        /// </summary>
        public int? DepartmentId { get; set; } // (3) (Внешний ключ)
        public virtual Department? Department { get; set; } //(Навигационное свойство)

        /// <summary>
        /// Дата поверки/калибровки
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Дата следующей поверки/калибровки
        /// </summary>
        public DateTime? NextCalibrationDate { get; set; }

        /// <summary>
        /// год поверки/калибровки
        /// </summary>
        public uint? Year { get; set; }

        /// <summary>
        /// Месяц поверки/калибровки
        /// </summary>
        public string? Month { get; set; }

        /// <summary>
        /// Условие отбора записей в БД
        /// </summary>
        public Func<MeasuringInstrument, bool> Predicate =>
            x => x.DeviceName.ToUpper().Contains(this.DeviceName.ToUpper()) == true
            && x.ManufacturerNumber.ToUpper().Contains(this.ManufacturerNumber.ToUpper()) == true
            && x.InventoryNumber.ToUpper().Contains(this.InventoryNumber.ToUpper()) == true
            && (this.DeviceTypeId == null ? true : x.DeviceTypeId == this.DeviceTypeId)
            && (this.DeviceStateId==null?true:x.DeviceStateId==this.DeviceStateId)
            && (this.DepartmentId==null?true:x.DepartmentId==this.DepartmentId)
            //&& (this.Date == null ? true : x.Calibrations.Date == this.Date)
            && CheckDate(x.Calibrations, this.Date)
            && CheckNextCalibrationDate(x.Calibrations, this.NextCalibrationDate)
            && CheckYearMonth(x.Calibrations, this.Year, this.Month)
            ;


        /// <summary>
        /// Проверка Года и Месяца поверки/калибровки:
        /// </summary>
        /// <param name="calibrations">Список, содержащий все калибровки/поверки текущего СИ</param>
        /// <param name="year">Год из текущего объекта FilterMiDTO</param>
        /// <param name="month">Месяц из текущего объекта FilterMiDTO</param>
        /// <returns></returns>
        bool CheckYearMonth(List<Calibration>? calibrations, uint? year, string? month)
        {
            if (year == null) return true;
            if (calibrations == null) return false; //&& year != null

            foreach (var item in calibrations)
            {
                if (month==null)
                {
                    if (item.Date.Year == year) return true;
                }
                else
                {
                    if (item.Date.Year == year)
                    {
                        if (month.ToLower() == "январь" && item.Date.Month == 1) return true;
                        if (month.ToLower() == "февраль" && item.Date.Month == 2) return true;
                        if (month.ToLower() == "март" && item.Date.Month == 3) return true;
                        if (month.ToLower() == "апрель" && item.Date.Month == 4) return true;
                        if (month.ToLower() == "май" && item.Date.Month == 5) return true;
                        if (month.ToLower() == "июнь" && item.Date.Month == 6) return true;
                        if (month.ToLower() == "июль" && item.Date.Month == 7) return true;
                        if (month.ToLower() == "август" && item.Date.Month == 8) return true;
                        if (month.ToLower() == "сентябрь" && item.Date.Month == 9) return true;
                        if (month.ToLower() == "октябрь" && item.Date.Month == 10) return true;
                        if (month.ToLower() == "ноябрь" && item.Date.Month == 11) return true;
                        if (month.ToLower() == "декабрь" && item.Date.Month == 12) return true;
                    }    
                }
            }
            return false;
        }


        /// <summary>
        /// Проверка Даты поверки/калибровки:
        /// </summary>
        /// <param name="calibrations">Список, содержащий все калибровки/поверки текущего СИ</param>
        /// <param name="date">Дата из текущего объекта FilterMiDTO </param>
        /// <returns></returns>
        bool CheckDate(List<Calibration>? calibrations, DateTime? date)
        {
            if (date == null) return true;
            if (calibrations == null) return false; //&& date != null
            foreach (var item in calibrations)
            {
                if (item.Date.ToShortDateString() == date?.ToShortDateString()) return true;
            }
            return false;
        }


        /// <summary>
        /// Проверка Даты поверки/калибровки:
        /// </summary>
        /// <param name="calibrations">Список, содержащий все калибровки/поверки текущего СИ</param>
        /// <param name="nextCalibrationDate">Дата следующей поверки/калибровки из текущего объекта FilterMiDTO </param>
        /// <returns></returns>
        bool CheckNextCalibrationDate(List<Calibration>? calibrations, DateTime? nextCalibrationDate)
        {
            if (nextCalibrationDate == null) return true;
            if (calibrations == null) return false; //&& nextCalibrationDate != null
            foreach (var item in calibrations)
            {
                if (item.NextCalibrationDate?.ToShortDateString() == nextCalibrationDate?.ToShortDateString()) return true;
            }
            return false;
        }

        /// <summary>
        /// Список месяцев
        /// </summary>
        /// <returns></returns>
        public static string[] GetMonths()
        {
            string[] month = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
            return month;
        }
    }
}
