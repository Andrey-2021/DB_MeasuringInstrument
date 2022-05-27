namespace WordDocDTO
{
    /// <summary>
    /// Строка для итоговой таблицы в Отчёте или Сводке
    /// </summary>
    public class SummaryLineReportDTO
    {
        /// <summary>
        /// Подразделение
        /// </summary>
        public string? DepartmentSubdevisionNumber { get; set; }

        /// <summary>
        /// Сумма по плану
        /// </summary>
        public int PlanSum { get; set; }

        /// <summary>
        /// Сумма фактическая
        /// </summary>
        public int InFactSum { get; set; }

        /// <summary>
        /// Сумма по ремонта
        /// </summary>
        public int RepairSum { get; set; }
    }
}
