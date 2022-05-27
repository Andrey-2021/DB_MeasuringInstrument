namespace DbClassLibrary
{
    /// <summary>
    /// Запись для Отчёта и Сводки
    /// </summary>
    public class ReportRecord
    {
        /// <summary>
        /// Наименованиеие СИ
        /// </summary>
        public string? MIDeviceName { get; set; }

        /// <summary>
        /// Подразделение
        /// </summary>
        public string? DepartmentSubdevisionNumber { get; set; }

        /// <summary>
        /// Дата поверки/калибровки
        /// </summary>
        public DateTime? CalibrationDate { get; set; }

        /// <summary>
        /// Дата следующей поверки/калибровки
        /// </summary>
        public DateTime? NextCalibrationDate { get; set; }


        /// <summary>
        /// Дата ремонта
        /// </summary>
        public DateTime RepairDate { get; set; }
    }
}
