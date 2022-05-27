using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WordDocClassLibraryOpenXml
{
    public class WordDoc
    {

        public void CreateDoc()
        {

        }


        public static void Save3(string parFileName)
        {
            string docName= parFileName + ".docx";

            // Create a Wordprocessing document. 
            using (WordprocessingDocument package = WordprocessingDocument.Create(docName, WordprocessingDocumentType.Document))
            {
                // Add a new main document part. 
                package.AddMainDocumentPart();

                // Create the Document DOM. 
                package.MainDocumentPart.Document =
                  new Document(
                    new Body(
                      new Paragraph(
                        new Run(
                          new Text("Hello World!")))));

                // Save changes to the main document part. 
                package.MainDocumentPart.Document.Save();
            }
        }

        public static string Save(string parFileName)
        {
            try
            {

                parFileName += ".docx";
                using (WordprocessingDocument doc = WordprocessingDocument.Create(parFileName,
                                                    WordprocessingDocumentType.Document,
                                                    true))
                {
                    // Add a new main document part.
                    MainDocumentPart mainPart = doc.AddMainDocumentPart();

                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    AddText(doc, "Тетрис. Результаты игр:", TextProp.Bold, 18);

                    /*
                    string[,] table = new string[parGameRezults.Count + 1, 3];
                    table[0, 0] = "Имя";
                    table[0, 1] = "Очки";
                    table[0, 2] = "Дата и время игры";

                    for (int i = 1; i <= parGameRezults.Count; i++)
                    {
                        table[i, 0] = parGameRezults[i - 1].Name;
                        table[i, 1] = parGameRezults[i - 1].Score.ToString();
                        table[i, 2] = parGameRezults[i - 1].DateTime.ToString();
                    }
                    InsertWordTable(doc, table);
                    */

                    AddText(doc, "", TextProp.Empty,14);
                    AddText(doc, "Первый максимальный результат:", TextProp.Bold,12);
                    AddText(doc, "Имя: " ,  TextProp.Italic,10);
                    AddText(doc, "Очков: " , TextProp.Empty,10);
                    AddText(doc, "Дата: " , TextProp.Empty,10);

                }
                return String.Empty;
            }
            catch (Exception ex)
            {
                return "При записи в docx-фалй произошла ошибка:" + ex.Message;
            }

        }


        public  enum TextProp
        {
            /// <summary>
            /// Обычный текст
            /// </summary>
            Empty,

            /// <summary>
            /// Жирный
            /// </summary>
            Bold,

            /// <summary>
            /// Курсив
            /// </summary>
            Italic
        }


        /// <summary>
        /// Добавить текст
        /// </summary>
        public static void AddText(WordprocessingDocument parDoc, string parText, TextProp property, int fontSize)
        {
            MainDocumentPart mainPart = parDoc.MainDocumentPart;
            Body body = mainPart.Document.Body;
            Paragraph paragraph = body.AppendChild(new Paragraph());
            

            Run run = new Run();
            RunProperties runProp = new RunProperties();
            

            
            //if (property==TextProp.Bold) run.RunProperties.AddChild(new Bold());
            if (property == TextProp.Bold) runProp.Bold=new Bold();

            //if (property == TextProp.Italic) run.RunProperties.AddChild(new Italic());
            if (property == TextProp.Italic) runProp.Italic = new Italic();
            else runProp.Italic = null;

            runProp.Underline = new Underline();

            runProp.RunFonts = new RunFonts { Ascii = "Arial" };
            runProp.FontSize = new FontSize { Val = (2 * fontSize).ToString() };
            //run.RunProperties.AddChild(new FontSize() { Val = (2*fontSize).ToString() });

            //run.PrependChild(runProp);
            run.Append(runProp);

            var text = new DocumentFormat.OpenXml.Math.Text(parText) { Space = SpaceProcessingModeValues.Preserve };
            run.AppendChild(text);
            //run.AppendChild(new CarriageReturn());

            //paragraph.AppendChild(
            paragraph.Append(run);

        }

        /*
        /// <summary>
        /// Вставка таблицы
        /// </summary>
        public static void InsertWordTable(WordprocessingDocument parDoc,
                                   string[,] parTable)
        {
            DocumentFormat.OpenXml.Wordprocessing.Table dTable =
              new DocumentFormat.OpenXml.Wordprocessing.Table();

            TableProperties props = new TableProperties();

            //рамка
            var borderValues = new EnumValue<BorderValues>(BorderValues.Single);
            var tableBorders = new TableBorders(
                                 new TopBorder { Val = borderValues, Size = 4 },
                                 new BottomBorder { Val = borderValues, Size = 4 },
                                 new LeftBorder { Val = borderValues, Size = 4 },
                                 new RightBorder { Val = borderValues, Size = 4 },
                                 new InsideHorizontalBorder { Val = borderValues, Size = 4 },
                                 new InsideVerticalBorder { Val = borderValues, Size = 4 });

            props.Append(tableBorders);

            //ширина таблицы
            var tableWidth = new TableWidth()
            {
                Width = "5000",
                Type = TableWidthUnitValues.Pct
            };
            props.Append(tableWidth);




            dTable.AppendChild<TableProperties>(props);

            for (int i = 0; i < parTable.GetLength(0); i++)
            {
                var tr = new TableRow();

                for (int j = 0; j < parTable.GetLength(1); j++)
                {
                    var tc = new DocumentFormat.OpenXml.Drawing.TableCell();
                    tc.Append(new Paragraph(new Run(new DocumentFormat.OpenXml.Math.Text(parTable[i, j]))));

                    if (i == 0) tc.Append(new TableCellProperties(new Shading { Fill = "EEDDEE" }));
                    else tc.Append(new TableCellProperties(new Shading { Fill = "DDFFDD" }));

                    tr.Append(tc);
                }
                dTable.Append(tr);
            }
            parDoc.MainDocumentPart.Document.Body.Append(dTable);
        }
        */
    }
}