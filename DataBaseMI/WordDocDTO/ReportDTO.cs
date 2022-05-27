using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocDTO
{
    /// <summary>
    /// Объект передачи данных для создания отчёта и сводки по СИ
    /// </summary>
    public class ReportDTO
    {
        /// <summary>
        /// Имя файла
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// Заголовок отчёта
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Свойство. Итоговая таблица, содержащая стрки с суммами 
        /// </summary>
        public List<SummaryLineReportDTO>? SumTable { get; set; }

        /// <summary>
        /// Итого по колонке ПЛАН поверки
        /// </summary>
        public int TotalPlan { get; set; }
        /// <summary>
        /// Итого по колонке ФАКТ поверки
        /// </summary>
        public int TotalInFact { get; set; }

        /// <summary>
        /// Итого по колонке ФАКТ ремонта
        /// </summary>
        public int TotalRepair { get; set; }
    }
}
