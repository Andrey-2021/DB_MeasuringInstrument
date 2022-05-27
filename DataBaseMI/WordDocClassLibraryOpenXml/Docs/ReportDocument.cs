
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using WordDocClassLibraryOpenXml.Docs;
using WordDocDTO;

namespace WordDocClassLibraryOpenXml
{

    /// <summary>
    /// Отчёт по СИ. Создание Doc-файла
    /// </summary>
    public class ReportDocument
    {
        ReportDTO _dTO;
        public ReportDocument(ReportDTO dTO)
        {
            this._dTO = dTO;
        }

        public object Application { get; private set; }

        public void CreateMovmentDoc()
        {
            try
            {
                using (WordprocessingDocument package
                   = WordprocessingDocument.Create(_dTO.FileName, WordprocessingDocumentType.Document))
                {

                    DocExtension.CreateMainPart(package);
                    Body body = package.MainDocumentPart.Document.Body;

                    //шапка документа
                    Paragraph p1 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                    Run r1 = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(14).RunAddText(_dTO.Title);
                    p1.Append(r1);
                    body.AppendChild(p1);

                    //Добавим параграф
                    body.AppendChild(CommonDocumentParts.CreateEnumPargraph());

                    int nRows = 15 + 3 + 1; //3 строки - заголовок таблицы, 1 строка для Итогов
                    if (_dTO?.SumTable?.Count > 15) nRows = _dTO.SumTable.Count + 3 + 1;

                    int width = 8;
                    var t3 = TabExtension2.InsertTable(nRows, 10, new int[] { 8, 100 - 8 * width - 8, width, width, width, width, width, width, width, width });
                    TabExtension2.VerticalCellsMerge(t3, 0, 0, 3);
                    TabExtension2.ChangeText(t3, 0, 0, "№№ П.П.");
                    TabExtension2.VerticalCellsMerge(t3, 0, 1, 3);
                    TabExtension2.ChangeText(t3, 0, 1, "ПОДРАЗДЕЛЕНИЕ");

                    TabExtension2.HorizontolCellsMerge(t3, 0, 2, 4);
                    TabExtension2.ChangeText(t3, 0, 2, "ПОВЕРКА");
                    TabExtension2.HorizontolCellsMerge(t3, 1, 2, 2);
                    TabExtension2.ChangeText(t3, 1, 2, "ПЛАН");
                    TabExtension2.ChangeText(t3, 2, 2, "ШТ.");
                    TabExtension2.ChangeText(t3, 2, 3, "Н/Ч");
                    TabExtension2.HorizontolCellsMerge(t3, 1, 4, 2);
                    TabExtension2.ChangeText(t3, 1, 4, "ФАКТ");
                    TabExtension2.ChangeText(t3, 2, 4, "ШТ.");
                    TabExtension2.ChangeText(t3, 2, 5, "Н/Ч");

                    TabExtension2.HorizontolCellsMerge(t3, 0, 6, 4);
                    TabExtension2.ChangeText(t3, 0, 6, "РЕМОНТ");
                    TabExtension2.HorizontolCellsMerge(t3, 1, 6, 2);
                    TabExtension2.ChangeText(t3, 1, 6, "ПЛАН");
                    TabExtension2.ChangeText(t3, 2, 6, "ШТ.");
                    TabExtension2.ChangeText(t3, 2, 7, "Н/Ч");
                    TabExtension2.HorizontolCellsMerge(t3, 1, 8, 2);
                    TabExtension2.ChangeText(t3, 1, 8, "ФАКТ");
                    TabExtension2.ChangeText(t3, 2, 8, "ШТ.");
                    TabExtension2.ChangeText(t3, 2, 9, "Н/Ч");

                    for (int i = 0; i < _dTO?.SumTable?.Count; i++)
                    {
                        //Номер строки
                        TabExtension2.ChangeText(t3, i + 3, 0, (i + 1).ToString());
                        //Название
                        TabExtension2.ChangeText(t3, i + 3, 1, _dTO.SumTable[i].DepartmentSubdevisionNumber);
                        //план
                        TabExtension2.ChangeText(t3, i + 3, 2, _dTO.SumTable[i].PlanSum.ToString());
                        //факт
                        TabExtension2.ChangeText(t3, i + 3, 4, _dTO.SumTable[i].InFactSum.ToString());
                        //Ремонт Факт
                        TabExtension2.ChangeText(t3, i + 3, 8, _dTO.SumTable[i].RepairSum.ToString());
                    }

                    TabExtension2.ChangeText(t3, nRows - 1, 1, "Итого:");
                    TabExtension2.ChangeText(t3, nRows - 1, 2, _dTO?.TotalPlan.ToString());
                    TabExtension2.ChangeText(t3, nRows - 1, 4, _dTO?.TotalInFact.ToString());
                    TabExtension2.ChangeText(t3, nRows - 1, 8, _dTO?.TotalRepair.ToString());

                    body.Append(t3);
                    package.Save();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("При создании документа возникла ошибка: " + ex.Message);
            }
        }
    }
}
