using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using WordDocDTO;

namespace WordDocClassLibraryOpenXml.Docs
{
    /// <summary>
    /// Создание документа Word "Паспорт СИ", форма 1
    /// </summary>
    internal class PasportVer1
    {
        public void CreatePasportV1(PasportDTO dTO)
        {
            using (WordprocessingDocument package
                = WordprocessingDocument.Create(dTO.FileName, WordprocessingDocumentType.Document))
            {

                DocExtension.CreateMainPart(package);
                Body body = package.MainDocumentPart.Document.Body;

                //https://translated.turbopages.org/proxy_u/en-ru.ru.69d29284-6275968f-3196dfaa-74722d776562/https/stackoverflow.com/questions/9429752/setting-the-margin-of-word-document-in-c-sharp-using-open-xml
                //https://docs.microsoft.com/ru-ru/dotnet/api/documentformat.openxml.wordprocessing.pagemargin?view=openxml-2.8.1
                //поля документа
                SectionProperties sectionProps = new SectionProperties();
                PageMargin pageMargin = new PageMargin() { Top = 1440, Right = (UInt32Value)1008U, Bottom = 1440, Left = (UInt32Value)1008U, Header = (UInt32Value)720U, Footer = (UInt32Value)720U, Gutter = (UInt32Value)0U };
                sectionProps.Append(pageMargin);
                body.Append(sectionProps);

                //шапка документа
                //Paragraph p = ParagraphExtensio.CreateParagraph().ParagraphJustification(JustificationValues.Right);
                //Run r = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(14).RunAddText("Паспорт СИ, форма 1");
                //p.Append(r);
                //body.AppendChild(p);


                var t = TabExtension2.InsertTable(7, 7);

                TabExtension2.BoxMerge(t, 0, 0, 2, 2);
                TabExtension2.ChangeText(t, 0, 0, "Предприятие");
                TabExtension2.BoxMerge(t, 2, 0, 2, 2);
                TabExtension2.ChangeText(t, 2, 0, "Наименование предприятия");
                TabExtension2.DelCellBorder(t, 1, 0, false, true, false, false);
                TabExtension2.DelCellBorder(t, 2, 0, true, false, false, false);

                TabExtension2.BoxMerge(t, 0, 2, 2, 2);
                TabExtension2.ChangeText(t, 0, 2, "ПАСПОРТ №" + dTO?.MI?.Id);
                TabExtension2.HorizontolCellsMerge(t, 2, 2, 2);
                TabExtension2.DelCellBorder(t, 1, 2, false, true, false, false);
                TabExtension2.DelCellBorder(t, 2, 2, true, false, false, false);
                TabExtension2.ChangeText(t, 2, 2, "на " + dTO?.MI?.DeviceName);
                TabExtension2.HorizontolCellsMerge(t, 3, 2, 2);
                TabExtension2.ChangeText(t, 3, 2, "наименование прибора");

                TabExtension2.HorizontolCellsMerge(t, 0, 4, 3);
                TabExtension2.ChangeText(t, 0, 4, dTO?.MI?.UseDate.ToShortDateString());
                TabExtension2.HorizontolCellsMerge(t, 1, 4, 3);
                TabExtension2.ChangeText(t, 1, 4, "дата поступления в эксплуатацию");
                TabExtension2.DelCellBorder(t, 1, 4, false, true, false, false);
                TabExtension2.DelCellBorder(t, 2, 4, true, false, false, false);
                TabExtension2.HorizontolCellsMerge(t, 2, 4, 3);
                TabExtension2.ChangeText(t, 2, 4, dTO?.MI?.CalibrationPeriod?.Period);
                TabExtension2.HorizontolCellsMerge(t, 3, 4, 3);
                TabExtension2.ChangeText(t, 3, 4, "периодичность поверки прибора");

                int n = 4;
                TabExtension2.ChangeText(t, n, 0, "Завод изготовитель");
                TabExtension2.ChangeText(t, n + 2, 0, dTO?.MI?.Manufacturer?.Name);
                TabExtension2.ChangeText(t, n, 1, "Заводской №");
                TabExtension2.ChangeText(t, n + 2, 1, dTO?.MI?.ManufacturerNumber);
                TabExtension2.ChangeText(t, n, 2, "Инвентарный №");
                TabExtension2.ChangeText(t, n + 2, 2, dTO?.MI?.InventoryNumber);
                TabExtension2.ChangeText(t, n, 3, "Тип или система");
                TabExtension2.ChangeText(t, n + 2, 3, dTO?.MI?.DeviceType?.TypeName);
                TabExtension2.ChangeText(t, n, 4, "Пределы измерения");
                TabExtension2.ChangeText(t, n + 2, 4, dTO?.MI?.WorkRange);
                TabExtension2.ChangeText(t, n, 5, "Цена деления шкалы");
                TabExtension2.ChangeText(t, n + 2, 5, dTO?.MI?.ScaleStep);
                TabExtension2.ChangeText(t, n, 6, "Класс или доступная погрешность");
                TabExtension2.ChangeText(t, n + 2, 6, dTO?.MI?.Error);


                n++;
                for (int i = 1; i <= 6; i++)
                {
                    TabExtension2.ChangeText(t, n, i - 1, i.ToString());
                }
                body.Append(t);

                //Добавим параграф
                body.AppendChild(CommonDocumentParts.CreateEnumPargraph());

                //добавим параграф
                Paragraph p2 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                Run r2 = RunExtension.CreateRun().RunUnderline().RunFont("Times New Roman").RunSize(12).RunAddText("Перечень основных частей комплекта: "
                    + dTO?.MI?.MainPartsList);
                p2.Append(r2);
                body.AppendChild(p2);

                //Добавим параграф
                //body.AppendChild(CommonDocumentParts.CreateEnumPargraph());


                /*
                //таблица Результаты поверки
                var t2 = TabExt2.InsertTable(5, 8);
                TabExt2.HorizontolCellsMerge(t2, 0, 0, 8);
                TabExt2.ChangeText(t2, 0, 0, "Результаты поверки");
                n = 1;
                TabExt2.ChangeText(t2, n, 0, "Дата поверки");
                TabExt2.ChangeText(t2, n, 1, "Заключение");
                TabExt2.ChangeText(t2, n, 2, "Дата поверки");
                TabExt2.ChangeText(t2, n, 3, "Заключение");
                TabExt2.ChangeText(t2, n, 4, "Дата поверки");
                TabExt2.ChangeText(t2, n, 5, "Заключение");
                TabExt2.ChangeText(t2, n, 6, "Дата поверки");
                TabExt2.ChangeText(t2, n, 7, "Заключение");
                body.Append(t2);
                */
                
                //добавим параграф
                Paragraph pCalib = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                Run rCalib = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(12).RunAddText("Результаты поверки");
                pCalib.Append(rCalib);
                body.AppendChild(pCalib);
                body.Append(PasportVer2.CreateCalibrationTable(dTO, "Заключение"));

                //Добавим параграф
                body.AppendChild(CommonDocumentParts.CreateEnumPargraph());

                //добавим параграф
                Paragraph p3 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                Run r3 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(12).RunAddText("Начальник МС _______________________________________________________");
                p3.Append(r3);
                body.AppendChild(p3);

                //добавим параграф
                Paragraph p4 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                Run r4 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(12).RunAddText("Дата составления документа '______' _________________ 20_____г.         МП");
                p4.Append(r4);
                body.AppendChild(p4);



                //разрыв страницы
                DocExtension.InsertWordBreak(package);

                //количество строк в таблице
                int numRows = 7;
                int numGroups = 2;
                int nRowsInHead = 3; //количество строк в шапке таблицы
                int nColumns = 10;
                int nColumnsInGroup = nColumns / numGroups; //количество столбцов в группе

                if (dTO?.MI?.Calibrations?.Count > (numRows - nRowsInHead) * numGroups) numRows = dTO.MI.Calibrations.Count / numGroups + nRowsInHead+1;

                //таблица Результаты периодической поверки
                var t3 = TabExtension2.InsertTable(numRows, nColumns);
                TabExtension2.HorizontolCellsMerge(t3, 0, 0, nColumns);
                TabExtension2.ChangeText(t3, 0, 0, "Результаты периодической поверки");
                n = 1;
                TabExtension2.ChangeText(t3, n, 0, "Дата поверки");
                TabExtension2.ChangeText(t3, n, 1, "№ протокола поверки");
                TabExtension2.ChangeText(t3, n, 2, "Заключение (годен - негоден)");
                TabExtension2.ChangeText(t3, n, 3, "Подпись пове-рявшего");
                TabExtension2.ChangeText(t3, n, 4, "Место-положение");

                TabExtension2.ChangeText(t3, n, 5, "Дата поверки");
                TabExtension2.ChangeText(t3, n, 6, "№ протокола поверки");
                TabExtension2.ChangeText(t3, n, 7, "Заключение (годен - негоден)");
                TabExtension2.ChangeText(t3, n, 8, "Подпись пове-рявшего");
                TabExtension2.ChangeText(t3, n, 9, "Место-положение");

                for (int i = 1; i <= nColumns; i++)
                {
                    TabExtension2.ChangeText(t3, n + 1, i - 1, i.ToString());
                }

                int index = 0;
                for (int j = 0; j < numGroups && index < dTO?.MI?.Calibrations?.Count; j++)
                {
                    for (int i = 0; i < numRows - nRowsInHead && index < dTO?.MI?.Calibrations?.Count; i++)
                    {
                        TabExtension2.ChangeText(t3, i + nRowsInHead, j * nColumnsInGroup, dTO?.MI.Calibrations[index].Date.ToShortDateString());
                        TabExtension2.ChangeText(t3, i + nRowsInHead, j * nColumnsInGroup + 2, dTO?.MI.Calibrations[index].Rezult);
                        index++;
                    }
                }

                /*
                n = 5;
                TabExt2.HorizontolCellsMerge(t3, n, 0, 2);
                TabExt2.HorizontolCellsMerge(t3, n + 1, 0, 2);
                TabExt2.ChangeText(t3, n + 1, 0, "Дата ремонта, ТО");
                TabExt2.HorizontolCellsMerge(t3, n, 2, 8);
                TabExt2.ChangeText(t3, n, 2, "Сведения о ремонте, ТО");
                TabExt2.HorizontolCellsMerge(t3, n + 1, 2, 8);
                TabExt2.ChangeText(t3, n + 1, 2, "Краткая характеристика ремонта, ТО");
                */
                body.Append(t3);


                //добавим параграф
                Paragraph pRepair = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                Run rRepair = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(12).RunAddText("Сведения о ремонте");
                pRepair.Append(rRepair);
                body.AppendChild(pRepair);

                body.Append(PasportVer2.CreateRepairTable(dTO));
                


                package.Save();
            }
        }
    }
}
