
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using WordDocDTO;

namespace WordDocClassLibraryOpenXml
{

    /// <summary>
    /// Накладная на внутреннее перемещение
    /// </summary>
    public class MovementDocument
    {
        MovementDTO _dTO;
        public MovementDocument(MovementDTO dTO)
        {
            this._dTO = dTO;
        }

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
                    Paragraph p = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Right);
                    Run r = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(11).RunAddText("Форма АВН №М-13");
                    p.Append(r);
                    body.AppendChild(p);

                    //шапка документа
                    Paragraph p1 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                    Run r1 = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(14).RunAddText("Накладная на внутреннее перемещение");
                    p1.Append(r1);
                    body.AppendChild(p1);

                    //таблица
                    int nRows = 11;
                    var t = TabExtension2.InsertTable(nRows, 12);
                    TabExtension2.BoxMerge(t, 0, 0, 2, 2);
                    TabExtension2.DelCellBorder(t, 0, 0);
                    TabExtension2.DelCellBorder(t, 1, 0);

                    TabExtension2.ChangeText(t, 0, 2, "Шифр документа");
                    TabExtension2.ChangeText(t, 0, 3, "Номер документа");
                    TabExtension2.ChangeText(t, 1, 3, _dTO?.Moving?.Id.ToString());
                    TabExtension2.ChangeText(t, 0, 4, "Дата");
                    TabExtension2.ChangeText(t, 1, 4, _dTO?.Moving?.Date.ToShortDateString());
                    TabExtension2.HorizontolCellsMerge(t, 0, 5, 2);
                    TabExtension2.ChangeText(t, 0, 5, "Шифр отправителя");
                    TabExtension2.HorizontolCellsMerge(t, 1, 5, 2);
                    TabExtension2.ChangeText(t, 1, 5, _dTO?.Moving?.GiveDepartment?.SubdevisionNumber);
                    TabExtension2.HorizontolCellsMerge(t, 0, 7, 3);
                    TabExtension2.ChangeText(t, 0, 7, "Шифр получателя");
                    TabExtension2.HorizontolCellsMerge(t, 1, 7, 3);
                    TabExtension2.ChangeText(t, 1, 7, _dTO?.Moving?.TakeDepartment?.SubdevisionNumber);
                    TabExtension2.ChangeText(t, 0, 10, "Шифр вида операции");
                    TabExtension2.ChangeText(t, 0, 11, "Шифр затрат");

                    //2я шапка таблицы
                    TabExtension2.ChangeText(t, 2, 0, "№");
                    TabExtension2.ChangeText(t, 3, 0, "1");
                    TabExtension2.ChangeText(t, 4, 0, "1");

                    for (int i = 0; i < nRows - 2; i++)
                    {
                        TabExtension2.HorizontolCellsMerge(t, 2 + i, 1, 5);
                        TabExtension2.HorizontolCellsMerge(t, 2 + i, 6, 2);
                    }
                    //TabExt2.HorizontolCellsMerge(t, 2, 1, 5);
                    TabExtension2.ChangeText(t, 2, 1, "Наименование, сорт профиль, размер, марка");
                    //TabExt2.HorizontolCellsMerge(t, 3, 1, 5);
                    TabExtension2.ChangeText(t, 3, 1, "2");

                    //название СИ разделяем на строки
                    var arr = _dTO?.Moving?.MeasuringInstrument?.DeviceName?.Split(new char[] { ' ' });
                    int startWord = 0;
                    int count = 0;
                    int row = 0;
                    string str = "";
                    const int nomberCharInRow = 22;

                    while (startWord + count < arr?.Length && row < nRows - 4)
                    {
                        bool check = str.Length + arr[count].Length < nomberCharInRow;
                        if (check)
                        {
                            str = str + " " + arr[startWord + count];
                            count++;
                        }
                        if (!check || startWord + count - 1 == arr.Length - 1)
                        {
                            row++;
                            TabExtension2.ChangeText(t, 3 + row, 1, str);
                            str = "";
                            startWord = startWord + count;
                            count = 0;
                        }
                    }
                    row++;
                    TabExtension2.ChangeText(t, 3 + row, 1, "№" + _dTO?.Moving?.MeasuringInstrument?.ManufacturerNumber);//заводской номер



                    //TabExt2.HorizontolCellsMerge(t, 2, 6, 2);
                    TabExtension2.ChangeText(t, 2, 6, "Номенклатурный номер (обозначение)");
                    //TabExt2.HorizontolCellsMerge(t, 3, 6, 2);
                    TabExtension2.ChangeText(t, 3, 6, "3");
                    TabExtension2.ChangeText(t, 4, 6, _dTO?.Moving?.MeasuringInstrument?.InventoryNumber);//берём инвентарный номер


                    TabExtension2.ChangeText(t, 2, 8, "Ед. изм.");
                    TabExtension2.ChangeText(t, 3, 8, "4");
                    TabExtension2.ChangeText(t, 4, 8, "шт");

                    TabExtension2.ChangeText(t, 2, 9, "Количество");
                    TabExtension2.ChangeText(t, 3, 9, "5");
                    TabExtension2.ChangeText(t, 4, 9, "1");

                    TabExtension2.ChangeText(t, 2, 10, "Цена");
                    TabExtension2.ChangeText(t, 3, 10, "6");

                    TabExtension2.ChangeText(t, 2, 11, "Сумма");
                    TabExtension2.ChangeText(t, 3, 11, "7");
                    body.Append(t);

                    //добавим пустой параграф
                    Paragraph p2 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                    Run r2 = RunExtension.CreateRun().RunBold().RunFont("Times New Roman").RunSize(12).RunAddText("");
                    p2.Append(r2);
                    body.AppendChild(p2);


                    //таблица Результаты поверки
                    var t2 = TabExtension2.InsertTable(2, 4);
                    TabExtension2.ChangeText(t2, 0, 0, "Разрешил");
                    TabExtension2.ChangeText(t2, 0, 1, "Контролёр ОТК");
                    TabExtension2.ChangeText(t2, 0, 2, "Сдал");
                    TabExtension2.ChangeText(t2, 0, 3, "Принял");

                    TabExtension2.ChangeText(t2, 1, 2, _dTO?.Moving?.GiveName);
                    TabExtension2.ChangeText(t2, 1, 3, _dTO?.Moving?.TakeName);

                    body.Append(t2);

                    //добавим параграф
                    Paragraph p3 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                    Run r3 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(12).RunAddText("Таксировку произвёл_________________________");
                    p3.Append(r3);
                    body.AppendChild(p3);

                    package.Save();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("При создании документа возникла ошибка: " + ex.Message);
            }
        }

        /*
        string name = "Накладная на внутреннее перемещение";
        public MovementDocument(string filePath)
        {
            string fileName = filePath + name + ".docx";

            using (WordprocessingDocument package
                = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
            {
                //package.AddMainDocumentPart(); // Add a new main document part. 

                //// Create the Document DOM. 
                //package.MainDocumentPart.Document = new Document(new Body());
                //MainDocumentPart mainPart = package.MainDocumentPart;
                //Body body = mainPart.Document.Body;

                //SectionProperties props = new SectionProperties();
                //body.AppendChild(props);

                DocExtension.CreateMainPart(package);
                DocExtension.SetHorizontalOrient(package);
                Body body = package.MainDocumentPart.Document.Body;


                ////Смена ориентации страницы
                //var sectionProperties = mainPart.Document
                //                .Body
                //                .GetFirstChild<SectionProperties>();

                //sectionProperties.AddChild(new PageSize()
                //{
                //    Width = (UInt32Value)15840U,
                //    Height = (UInt32Value)12240U,
                //    Orient = PageOrientationValues.Landscape
                //});





                //шапка документа
                Paragraph p = ParagraphExtensio.CreateParagraph().ParagraphJustification(JustificationValues.Right);
                Run r = RunExtension.CreateRun().RunBold().RunFont("Courier New").RunSize(12).RunAddText("Форма АВН № М-13");
                p.Append(r);
                body.AppendChild(p);

                Paragraph p2 = ParagraphExtensio.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                Run r2 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(18).RunAddText("Накладная на внутреннее перемещение");
                p2.Append(r2);
                body.AppendChild(p2);



                /*
                //таблица документа
                Table t = TableExtension.CreateTable();

                
                Paragraph p3 = ParagraphExtensio.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                Run r3 = RunExtension.CreateRun().RunAddText("шифр документа");
                p3.Append(r3);*/

        /*
        TableRow tr1 = TableExtension.CreateRow()
            .AddCell(GetParagraph("шифр документа"), 2400)
            .AddCell(GetParagraph("Номер документа"), 2400)
            .AddCell(GetParagraph("Дата"), 3000);
            //.AddCell(GetParagraph("Шифр отправителя"))
            //.AddCell(GetParagraph("Шифр получателя"))
            //.AddCell(GetParagraph("Шифр вида операции"))
            //.AddCell(GetParagraph("Шифр затрат"));

        //TableRow tr2 = TableExtension.CreateRow()
        //   .AddCell(GetParagraph(""))
        //   .AddCell(GetParagraph(""))
        //   .AddCell(GetParagraph(""))
        //   .AddCell(GetParagraph(""))
        //   .AddCell(GetParagraph(""))
        //   .AddCell(GetParagraph(""))
        //   .AddCell(GetParagraph(""));

        t.Append(tr1);
       // t.Append(tr2);
        body.Append(t);
        */
        /*
                        var t = TabExt2.InsertTable(10, 12);
                        TabExt2.ChangeText(t, 0, 3, "Номер документа");
                        TabExt2.ChangeText(t, 1, 3, "23");

                        TabExt2.ChangeText(t, 0, 4, "Дата");
                        TabExt2.ChangeText(t, 1, 4, "29.01.21");

                        TabExt2.HorizontolCellsMerge(t,1, 0,3);
                        TabExt2.HorizontolCellsMerge(t,2, 0, 3);
                        // TabExt2.HorizontolCellMergeGridSpan(t, 1, 0, 3);


                        TabExt2.BoxMerge(t, 3, 3, 2, 4);

                        //TabExt2.VerticalMerge(t, 1, 0, 2);
                        //TabExt2.VerticalMerge(t, 1, 1, 2);
                        //TabExt2.VerticalMerge(t, 1, 2, 2);

                        body.Append(t);

                        TabExt2.DelCellBorder(t, 0, 0);
                        TabExt2.DelCellBorder(t, 1, 0);




                        body.AppendChild(ParagraphExtensio.ParagraphNewLine());//новая строка
                        //нижняя таблица документа
                        TableExtension.InsertWordTable(package, 
                            new string[,]{ { "Разрешил","Контролёр ОТК","Сдал","Принял"},
                            {"","","","" } });


                        body.AppendChild(ParagraphExtensio.ParagraphNewLine()); //новая строка
                        //текст
                        Paragraph p99 = ParagraphExtensio.CreateParagraph().ParagraphJustification(JustificationValues.Left);
                        Run r99 = RunExtension.CreateRun().RunFont("Arial").RunSize(14).RunBold().RunAddText("Таксировку произвёл_______");
                        p99.Append(r99);
                        body.AppendChild(p99);



                        package.Save();
                    }


                    Paragraph GetParagraph(string text)
                    {
                        Paragraph p3 = ParagraphExtensio.CreateParagraph().ParagraphJustification(JustificationValues.Center);
                        Run r3 = RunExtension.CreateRun().RunAddText(text);
                        p3.Append(r3);
                        return p3;
                    }

                }
        */

    }
}
