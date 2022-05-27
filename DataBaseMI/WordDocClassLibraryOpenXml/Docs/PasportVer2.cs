using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using WordDocDTO;

namespace WordDocClassLibraryOpenXml.Docs
{
    /// <summary>
    /// Создание документа Word "Паспорт СИ", форма 2
    /// </summary>
    internal class PasportVer2
    {
        public void CreatePasportV2(PasportDTO dTO)
        {
            using (WordprocessingDocument package
                = WordprocessingDocument.Create(dTO.FileName, WordprocessingDocumentType.Document))
            {

                DocExtension.CreateMainPart(package);
                Body body = package.MainDocumentPart.Document.Body;

                //шапка документа
                //Paragraph p = ParagraphExtensio.CreateParagraph().ParagraphJustification(JustificationValues.Right);
                //Run r = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(14).RunAddText("Паспорт СИ, форма 2");
                //p.Append(r);
                //body.AppendChild(p);


                var t = TabExtension2.InsertTable(6, 7);

                //TabExt2.VerticalCellsMerge(t, 0, 0, 2);
                TabExtension2.ChangeText(t, 0, 0, "Предприятие");
                TabExtension2.VerticalCellsMerge(t, 1, 0, 2);
                TabExtension2.ChangeText(t, 0, 1, "Производственное подразделение");
                TabExtension2.VerticalCellsMerge(t, 1, 1, 2);
                TabExtension2.ChangeText(t, 1, 1, dTO?.MI?.Department?.Name);

                //TabExt2.BoxMerge(t, 0, 2, 2, 2);
                TabExtension2.HorizontolCellsMerge(t, 0, 2, 2);
                TabExtension2.ChangeText(t, 0, 2, "ПАСПОРТ №" + dTO?.MI?.Id);
                TabExtension2.DelCellBorder(t, 0, 2, false, true, false, false);
                TabExtension2.DelCellBorder(t, 1, 2, true, false, false, false);
                TabExtension2.HorizontolCellsMerge(t, 1, 2, 2);
                TabExtension2.ChangeText(t, 1, 2, "на " + dTO?.MI?.DeviceName);
                TabExtension2.HorizontolCellsMerge(t, 2, 2, 2);
                TabExtension2.ChangeText(t, 2, 2, "наименование прибора");

                TabExtension2.HorizontolCellsMerge(t, 0, 4, 2);
                TabExtension2.ChangeText(t, 0, 4, "Дата поступления в эксплуатацию");
                TabExtension2.ChangeText(t, 0, 6, dTO?.MI?.UseDate.ToShortDateString());
                //TabExt2.VerticalCellsMerge(t, 0, 6, 2);
                TabExtension2.BoxMerge(t, 1, 4, 2, 2);
                //TabExt2.HorizontolCellsMerge(t, , 4, 2);
                TabExtension2.ChangeText(t, 1, 4, "Межповерочный период");
                TabExtension2.ChangeText(t, 1, 6, dTO?.MI?.CalibrationPeriod?.Period);
                TabExtension2.VerticalCellsMerge(t, 1, 6, 2);



                int n = 3;
                TabExtension2.ChangeText(t, n, 0, "Завод изготовитель");
                TabExtension2.ChangeText(t, n + 2, 0, dTO?.MI?.Manufacturer?.Name);
                TabExtension2.ChangeText(t, n, 1, "Заводской №");
                TabExtension2.ChangeText(t, n + 2, 1, dTO?.MI?.ManufacturerNumber);
                TabExtension2.ChangeText(t, n, 2, "Тип или система");
                TabExtension2.ChangeText(t, n + 2, 2, dTO?.MI?.DeviceType?.TypeName);
                TabExtension2.ChangeText(t, n, 3, "Пределы измерения");
                TabExtension2.ChangeText(t, n + 2, 3, dTO?.MI?.WorkRange);
                TabExtension2.ChangeText(t, n, 4, "Цена деления шкалы");
                TabExtension2.ChangeText(t, n + 2, 4, dTO?.MI?.ScaleStep);
                TabExtension2.HorizontolCellsMerge(t, n, 5, 2);
                TabExtension2.HorizontolCellsMerge(t, n + 1, 5, 2);
                TabExtension2.HorizontolCellsMerge(t, n + 2, 5, 2);
                TabExtension2.ChangeText(t, n, 5, "Класс точности или доступная погрешность");
                TabExtension2.ChangeText(t, n + 2, 5, dTO?.MI?.Error);

                n++;
                for (int i = 1; i <= 6; i++)
                {
                    TabExtension2.ChangeText(t, n, i - 1, i.ToString());
                }

                body.Append(t);


                //добавим параграф
                Paragraph p2 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                Run r2 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(12).RunAddText("Результаты поверки");
                p2.Append(r2);
                body.AppendChild(p2);
                
                body.Append(CreateCalibrationTable(dTO, "Заключение (годен - негоден)"));


                //добавим параграф
                Paragraph pRepair = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                Run rRepair = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(12).RunAddText("Сведения о ремонте");
                pRepair.Append(rRepair);
                body.AppendChild(pRepair);

                body.Append(CreateRepairTable(dTO));
                
                

                //разрыв страницы
                DocExtension.InsertWordBreak(package);

                //количество строк в таблице
                int numRows = 10;
                if (dTO?.MI?.Calibrations?.Count > numRows-3) numRows = dTO.MI.Calibrations.Count + 3;

                //таблица оборотная сторона
                var t4 = TabExtension2.InsertTable(numRows, 12);

                TabExtension2.HorizontolCellsMerge(t4, 0, 0, 12);
                TabExtension2.ChangeText(t4, 0, 0, "Результаты поверки (калибровки)");
                TabExtension2.VerticalCellsMerge(t4, 1, 0, 2);
                TabExtension2.ChangeText(t4, 1, 0, "Дата поверки (калибровки)");
                TabExtension2.HorizontolCellsMerge(t4, 1, 1, 8);
                TabExtension2.ChangeText(t4, 1, 1, "Поверяемые (калибруемые) точки");
                TabExtension2.VerticalCellsMerge(t4, 1, 9, 2);
                TabExtension2.ChangeText(t4, 1, 9, "Заключение (годе, негоден)");
                TabExtension2.VerticalCellsMerge(t4, 1, 10, 2);
                TabExtension2.ChangeText(t4, 1, 10, "Дата следующей поверки");
                TabExtension2.VerticalCellsMerge(t4, 1, 11, 2);
                TabExtension2.ChangeText(t4, 1, 11, "Подпись поверителя");

                for (int i = 0; i < dTO?.MI?.Calibrations?.Count; i++)
                {
                    TabExtension2.ChangeText(t4, 3+i, 0, dTO?.MI.Calibrations[i].Date.ToShortDateString());
                    TabExtension2.ChangeText(t4, 3+i, 9, dTO?.MI.Calibrations[i].Rezult);
                    TabExtension2.ChangeText(t4, 3+i, 10, dTO?.MI.Calibrations[i].NextCalibrationDate?.ToShortDateString());
                }

                body.Append(t4);

                package.Save();
            }

        }


        /// <summary>
        /// Создать таблицу с результатами поверок
        /// </summary>
        /// <param name="dTO"></param>
        /// <param name="message"></param>
        /// <returns></returns>
       internal static Table CreateCalibrationTable(PasportDTO? dTO, string message)
        {
            //количество строк в таблице
            int numRows = 3;
            int numGroups = 4;
            if (dTO?.MI?.Calibrations?.Count > (numRows - 1) * numGroups) numRows = dTO.MI.Calibrations.Count / numGroups + 2;

            //таблица Результаты поверки
            var t2 = TabExtension2.InsertTable(numRows, 8);
            int n = 0;
            TabExtension2.ChangeText(t2, n, 0, "Дата поверки");
            TabExtension2.ChangeText(t2, n, 1, message); //"Заключение (годен - негоден)"
            TabExtension2.ChangeText(t2, n, 2, "Дата поверки");
            TabExtension2.ChangeText(t2, n, 3, message);
            TabExtension2.ChangeText(t2, n, 4, "Дата поверки");
            TabExtension2.ChangeText(t2, n, 5, message);
            TabExtension2.ChangeText(t2, n, 6, "Дата поверки");
            TabExtension2.ChangeText(t2, n, 7, message);

            int index = 0;
            for (int j = 0; j < numGroups && index < dTO?.MI?.Calibrations?.Count; j++)
            {
                for (int i = 0; i < numRows - 1 && index < dTO?.MI?.Calibrations?.Count; i++)
                {
                    TabExtension2.ChangeText(t2, i + 1, j * 2, dTO?.MI.Calibrations[index].Date.ToShortDateString());
                    TabExtension2.ChangeText(t2, i + 1, j * 2 + 1, dTO?.MI.Calibrations[index].Rezult);
                    index++;
                }
            }

            return t2;
        }


        /// <summary>
        /// Создать таблицу Сведений о ремонте
        /// </summary>
        /// <param name="dTO"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        internal static Table CreateRepairTable(PasportDTO? dTO)
        {
            int nRows = 5;
            if (dTO?.Repairs?.Count > 4) nRows = dTO.Repairs.Count + 1;

            var t3 = TabExtension2.InsertTable(nRows, 2, new int[] { 30, 70 });
            TabExtension2.ChangeText(t3, 0, 0, "Дата ремонта");
            TabExtension2.ChangeText(t3, 0, 1, "Краткая характеристика ремонта");
            for (int i = 0; i < dTO?.Repairs?.Count; i++)
            {
                TabExtension2.ChangeText(t3, i + 1, 0, dTO?.Repairs?[i].Date.ToShortDateString());
                TabExtension2.ChangeText(t3, i + 1, 1, dTO?.Repairs?[i].Description);
            }
            return t3;
        }

    }
}
