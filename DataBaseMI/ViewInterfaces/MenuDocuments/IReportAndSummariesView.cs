using CommonClassLibrary.DTO;
using System.Text;

namespace ViewInterfaces.MenuDocuments
{
    public interface IReportAndSummariesView: IView
    {
        /// <summary>
        /// Создание отчёта или сводки по СИ
        /// </summary>
        public event EventHandler<ReportDatesDTO>? SavingReportInDocxFile;

        public void PrintInfo(StringBuilder text);
    }
}
