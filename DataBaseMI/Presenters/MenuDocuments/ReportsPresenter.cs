using CommonClassLibrary.DTO;
using CommonInterface;
using ConteinerLibrary;
using DbClassLibrary;
using Microsoft.EntityFrameworkCore;
using Presenters.MenuDocuments;
using System.Text;
using ViewInterfaces.Common;
using ViewInterfaces.MenuDocuments;
using WordDocClassLibraryOpenXml;
using WordDocDTO;

namespace Presenters
{
    /// <summary>
    /// Presener для "Отчёт"
    /// </summary>
    internal class ReportsPresenter : IPresenter
    {
        IReportAndSummariesView _view;
        DbContextOptions _dbOption;

        /// <summary>
        /// Конструктор
        /// </summary>
        public ReportsPresenter(IReportAndSummariesView view, DbContextOptions dbOption)
        {
            _view = view;
            _dbOption = dbOption;

            //_view.RefreshingAllMeasuringInstruments+= RefreshAllDatas;
            _view.ClosingMyWindow += CloseViewWindow;
            _view.SavingReportInDocxFile += SaveReportDoc;
        }

        public void Run()
        {
            _view.ShowView();
        }

        /*
               public async void RefreshAllDatas(object sender, FindMeasuringInstrumentDTO data)
                {
                    try
                    {
                        //todo сделать свой метод чтения из БД  асинхронным

                        var list = _repositiry.ReadFromDb<MeasuringInstrument>(data.Predicate);
                        _view.PrintData(list);
                    }
                    catch (Exception ex)
                    {
                        _view.ShowError(ex.Message);
                    }
                }

                */

        /// <summary>
        /// Закрыть окно
        /// </summary>
        public void CloseViewWindow(object sender, EventArgs args)
        {
            _view.CloseView();
        }

        /// <summary>
        /// Создать "Отчёт по СИ"
        /// </summary>
        public void SaveReportDoc(Object? sender, ReportDatesDTO data)
        {
            _view.PrintInfo(new StringBuilder().Append("Подождите, идёт обработка данных..."));

            var saveClass = Conteiner.GetInstance().GetClassInstance<ISelectFile>();
            if (saveClass == null) throw new NullReferenceException("Нет класса , реализующего интерфейс " + nameof(ISelectFile));
            //Данные от пользователя
            var inputUserData = ExtractDatasFromObjectRecivedFromView(data);

            string? fileName = null;
            fileName = saveClass.SelectFileForSave(inputUserData.fileName);
            if (String.IsNullOrEmpty(fileName)) return;

            //Таблица итоговых данных для отчёта
            List<SummaryLineReportDTO> sumTable = new();

            try
            {
                var plan = GetDatesForReport.GetCalibrationPlan(_dbOption, inputUserData.beginDate, inputUserData.endDate);
                var inFact = GetDatesForReport.GetCalibrationInFact(_dbOption, inputUserData.beginDate, inputUserData.endDate);
                var repairInFact = GetDatesForReport.GetrRepairInFact(_dbOption, inputUserData.beginDate, inputUserData.endDate);

                //Группируем данные
                var tableCalibrationPlanByGroup = plan.GroupBy(z => z.DepartmentSubdevisionNumber).OrderBy(x => x.Key);
                var sumTableCalibrationPlanByGroup = tableCalibrationPlanByGroup.Select(n => new  //подсчитвывем количество записей в группе
                {
                    MetricName = n.Key,
                    MetricCount = n.Count()
                });

                var tableCalibrationInFactByGroup = inFact.GroupBy(z => z.DepartmentSubdevisionNumber).OrderBy(x => x.Key);
                var sumTableCalibrationInFactByGroup = tableCalibrationInFactByGroup.Select(n => new
                {
                    MetricName = n.Key,
                    MetricCount = n.Count()
                });

                var tableRepairInFactByGroup = repairInFact.GroupBy(z => z.DepartmentSubdevisionNumber).OrderBy(x => x.Key);
                var sumTableRepairInFactByGroup = tableRepairInFactByGroup.Select(n => new
                {
                    MetricName = n.Key,
                    MetricCount = n.Count()
                });


                //копируем данные в таблицу итоговых данных для отчёта
                foreach (var item in sumTableCalibrationPlanByGroup)
                {
                    SummaryLineReportDTO line = new SummaryLineReportDTO() { DepartmentSubdevisionNumber = item.MetricName, PlanSum = item.MetricCount };
                    sumTable.Add(line);
                }

                foreach (var item in sumTableCalibrationInFactByGroup)
                {
                    SummaryLineReportDTO line = sumTable.FirstOrDefault(x => x.DepartmentSubdevisionNumber == item.MetricName);
                    if (line == null)
                    {
                        line = new SummaryLineReportDTO() { DepartmentSubdevisionNumber = item.MetricName, InFactSum = item.MetricCount };
                        sumTable.Add(line);
                    }
                    else
                        line.InFactSum = item.MetricCount;
                }
                foreach (var item in sumTableRepairInFactByGroup)
                {
                    SummaryLineReportDTO line = sumTable.FirstOrDefault(x => x.DepartmentSubdevisionNumber == item.MetricName);
                    if (line == null)
                    {
                        line = new SummaryLineReportDTO() { DepartmentSubdevisionNumber = item.MetricName,  RepairSum= item.MetricCount };
                        sumTable.Add(line);
                    }
                    else
                        line.RepairSum = item.MetricCount;
                }

                ShowReportForUser(tableCalibrationPlanByGroup, 
                    tableCalibrationInFactByGroup,
                    tableRepairInFactByGroup);
            }
            catch (Exception ex)
            {
                _view.ShowError("При получении данных из БД произошла ошибка: " + ex.Message);
                return;
            }

            //Создаём документ Word
            try
            {
                ReportDTO dto = new ReportDTO() {FileName = fileName, Title = inputUserData.operationName, SumTable= sumTable };
                dto.TotalPlan = sumTable.Sum(x => x.PlanSum);
                dto.TotalInFact = sumTable.Sum(x => x.InFactSum);
                dto.TotalRepair = sumTable.Sum(x => x.RepairSum);

                MainDoc.CreateReports(dto);
                
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
                return;
            }

            RunWordDocInWindows.RunDoc(fileName, _view);

            //try
            //{
            //    RunWordDocInWindows.RunDoc(fileName);
            //}
            //catch (Exception ex)
            //{
            //    _view.ShowError("При открытие созданного документа средствами Windows возникла ошибка:"+ ex.Message);
            //}
        }


        /// <summary>
        /// Вывести отчёт пользователю по тем СИ, которые соответствуют заданным условиям выборки
        /// </summary>
        void ShowReportForUser(IOrderedEnumerable<IGrouping<string, ReportRecord>> tableCalibrationPlanByGroup,
            IOrderedEnumerable<IGrouping<string, ReportRecord>> tableCalibrationInFactByGroup,
            IOrderedEnumerable<IGrouping<string, ReportRecord>> tableRepairInFactByGroup)
        {
            StringBuilder text = new StringBuilder();
            text.Append("Данные по СИ, которые будут взяты для итоговой таблицы.");
            text.Append(Environment.NewLine);
            text.Append(Environment.NewLine);

            text.Append("Запланированные поверки за выбранный период (Подразделение, СИ, дата запланированной поверки):");
            text.Append(Environment.NewLine);

            foreach (var group in tableCalibrationPlanByGroup)
            {
                text.Append(group.Key);
                text.Append(Environment.NewLine);
                foreach (var item in group)
                {
                    text.Append($"\t {item.MIDeviceName,35} \t{item.NextCalibrationDate:d}");
                    text.Append(Environment.NewLine);
                }
                //text.Append("Итого: " + sumTableCalibrationPlanByGroup.FirstOrDefault(x => x.MetricName == group.Key).MetricCount);
                //text.Append(Environment.NewLine);
            }
            text.Append(Environment.NewLine);
            text.Append("Фактически проведённые поверки за выбранный период (Подразделение, СИ, дата поверок ):");
            text.Append(Environment.NewLine);
            foreach (var group in tableCalibrationInFactByGroup)
            {
                text.Append(group.Key);
                text.Append(Environment.NewLine);
                foreach (var item in group)
                {
                    text.Append($"\t {item.MIDeviceName,35} \t{item.CalibrationDate:d}");
                    text.Append(Environment.NewLine);
                }
                //text.Append("Итого: " + sumTableCalibrationInFactByGroup.FirstOrDefault(x => x.MetricName == group.Key).MetricCount);
                //text.Append(Environment.NewLine);
            }

            text.Append(Environment.NewLine);
            text.Append("Фактически проведённые ремонты за выбранный период (Подразделение, СИ, дата ремонта):");
            text.Append(Environment.NewLine);
            foreach (var group in tableRepairInFactByGroup)
            {
                text.Append(group.Key);
                text.Append(Environment.NewLine);
                foreach (var item in group)
                {
                    text.Append($"\t {item.MIDeviceName,35} \t{item.RepairDate:d}");
                    text.Append(Environment.NewLine);
                }
                //text.Append("Итого: " + sumTableRepairInFactByGroup.FirstOrDefault(x => x.MetricName == group.Key).MetricCount);
                //text.Append(Environment.NewLine);
            }

            /*
            text.Append("Таблица сумм:");
            text.Append(Environment.NewLine);
            foreach (var item in sumTable)
            {
                text.Append(item.DepartmentSubdevisionNumber + " \t " + item.PlanSum + " \t " + item.InFactSum + " \t " + item.RepairSum);
                text.Append(Environment.NewLine);
            }
            */
            _view.PrintInfo(text);
        }

        /// <summary>
        /// Извлекаем данные из объекта , который получен из View
        /// </summary>
        /// <param name="data">Объект полученный из View</param>
        /// <returns>Кортеж, содержащий:
        /// beginDate - начальная дата создаваемого отчёта/сводки;
        /// endDate - конечная дата создаваемого отчёта/сводки; 
        /// operationName - заголовок для создаваемого документа;
        /// fileName - имя файла
        /// </returns>
        /// <exception cref="Exception"></exception>
        private (DateTime beginDate, DateTime endDate, string operationName, string fileName) ExtractDatasFromObjectRecivedFromView(ReportDatesDTO data)
        {
            switch (data.reportType)
            {
                case ReportTypeEnum.yearReport: return Year(data);
                case ReportTypeEnum.monthReport: return Month(data);
                case ReportTypeEnum.quarterReport: return Quarter(data);
                case ReportTypeEnum.weekReport: return Week(data);
                default:
                    throw new Exception("Необрабатываемый выриант отчёта: " + data.reportType);
            }
        }

        /// <summary>
        /// Если создаём сводку за год
        /// </summary>
        private (DateTime beginDate, DateTime endDate, string operationName, string fileName) Year(ReportDatesDTO data)
        {
            DateTime beginDate = new DateTime(data.year, 1, 1);
            DateTime endDate = new DateTime(data.year, 12, 31);
            string operationName = "Годовая сводка. "+data.year + " год";
            return (beginDate, endDate, operationName, operationName);
        }

        /// <summary>
        /// Если создаём сводку за квартал
        /// </summary>
        private (DateTime beginDate, DateTime endDate, string operationName, string fileName) Quarter(ReportDatesDTO data)
        {
            string operationName = "Квартал " + data.quarter + " " + data.year + "г";
            DateTime beginDate;
            DateTime endDate;

            switch (data.quarter)
            {
                case 1:
                    beginDate = new DateTime(data.year, 1, 1);
                    endDate = new DateTime(data.year, 3, 31);
                    break;
                case 2:
                    beginDate = new DateTime(data.year, 4, 1);
                    endDate = new DateTime(data.year, 6, 30);
                    break;
                case 3:
                    beginDate = new DateTime(data.year, 7, 1);
                    endDate = new DateTime(data.year, 9, 30);
                    break;
                case 4:
                    beginDate = new DateTime(data.year, 10, 1);
                    endDate = new DateTime(data.year, 12, 31);
                    break;
                default:
                    throw new Exception("Неизвестный номер квартала: " + data.quarter);
            }
            return (beginDate, endDate, operationName, "Квартальная сводка. " + operationName);
        }

        /// <summary>
        /// Если создаём отчёт за месяц
        /// </summary>
        private (DateTime beginDate, DateTime endDate, string operationName, string fileName) Month(ReportDatesDTO data)
        {
            //DateTime date = DateTime.ParseExact(data.month, "MMMM", System.Globalization.CultureInfo.CurrentCulture);
            //int month = date.Month;

            string operationName = "Месяц " + (new DateTime(2022, data.month, 1)).ToString("MMMM") + " " + data.year + "г";
            DateTime beginDate = new DateTime(data.year, data.month, 1);
            DateTime endDate = new DateTime(data.year, data.month, DateTime.DaysInMonth(data.year, data.month));
            return (beginDate, endDate, operationName, "Месячный отчёт. " + operationName);
        }

        /// <summary>
        /// Если создаём отчёт за неделю
        /// </summary>
        private (DateTime beginDate, DateTime endDate, string operationName, string fileName) Week(ReportDatesDTO data)
        {
            string operationName = "Неделя c " + data.monday.ToShortDateString() + " по " + data.sunday.ToShortDateString();
            return (data.monday, data.sunday, operationName, "Недельный отчёт. " + operationName);
        }
    }
}
