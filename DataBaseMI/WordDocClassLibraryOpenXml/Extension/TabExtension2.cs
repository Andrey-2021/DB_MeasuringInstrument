
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;


namespace WordDocClassLibraryOpenXml
{
    public static class TabExtension2
    {
        /// <summary>
        /// Создать заполненную таблицу, со столбцами одинаковой ширины
        /// </summary>
        /// <param name="nRow">количество строк</param>
        /// <param name="nCol">количество чтолбцов</param>
        /// <returns></returns>
        public static Table InsertTable(int nRow, int nCol)
        {
            int[] widthInPercent = new int[nCol];
            for (int i = 0; i < nCol; i++)
            {
                widthInPercent[i]= 100 / nCol;
            }

            return InsertTable(nRow, nCol, widthInPercent);
        }







        /// <summary>
        /// Создать заполненную таблицу 
        /// </summary>
        /// <param name="nRow">количество строк</param>
        /// <param name="nCol">количество чтолбцов</param>
        /// <param name="widthInPercent">ширина столбца</param>
        /// <returns></returns>
        public static Table InsertTable(//WordprocessingDocument doc,
                                   int nRow, int nCol, int[] widthInPercent)
        {


            if (nCol != widthInPercent.Length) 
                throw new ArgumentException("Количество столбцов (" + nCol + ") не соответствует количеству переданных размеров столбцов " + widthInPercent.Length);

            DocumentFormat.OpenXml.Wordprocessing.Table dTable =
              new DocumentFormat.OpenXml.Wordprocessing.Table();

            TableProperties props = new TableProperties();

            props.Append(GetTableWidth()); //Таблица на всю ширину страницы
            props.Append(GetTableBorders());//Границы таблицы

            dTable.AppendChild<TableProperties>(props);

            for (int i = 0; i < nRow; i++)
            {
                var tr = new TableRow();

                for (int j = 0; j < nCol; j++)
                {
                    var tc = new TableCell();

                    var tCp = new TableCellProperties();
                    TableCellWidth cw = new TableCellWidth() { Type = TableWidthUnitValues.Pct, Width = (widthInPercent[j]*5000/100).ToString() };
                    TableCellVerticalAlignment va = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };
                    tCp.Append(cw);
                    tCp.Append(va);
                    tc.Append(tCp);

                    //tc.Append(new Paragraph(new Run(new Text(table[i, j]))));
                    tc.Append(
                        new Paragraph(
                            new ParagraphProperties(new Justification() { Val = JustificationValues.Center }),
                            new Run(new Text(""))
                            )
                        );

                    tr.Append(tc);
                }
                dTable.Append(tr);
            }

            return dTable;
            //doc.MainDocumentPart.Document.Body.Append(dTable);
        }





































        //https://docs.microsoft.com/ru-ru/office/open-xml/how-to-change-text-in-a-table-in-a-word-processing-document
        /// <summary>
        /// Замена текста в ячейке таблицы
        /// </summary>
        /// <param name="table">таблица</param>
        /// <param name="nRow">индекс строки</param>
        /// <param name="nColumn">индекс столбца</param>
        /// <param name="txt">Новый текст для ячейки</param>
        public static void ChangeText(Table table, int nRow, int nColumn, string? txt)
        {
            // Find the row in the table.
            TableRow row = table.Elements<TableRow>().ElementAt(nRow);
            // Find the cell in the row.
            TableCell cell = row.Elements<TableCell>().ElementAt(nColumn);

            Paragraph p = cell.Elements<Paragraph>().First();// Find the first paragraph in the table cell.
            Run r = p.Elements<Run>().First(); // Find the first run in the paragraph.
            Text t = r.Elements<Text>().First();
            t.Text = txt??"";
        }


        /// <summary>
        /// Горизонтальное объединение ячеек
        /// </summary>
        /// <param name="table"></param>
        /// <param name="iRow"></param>
        /// <param name="jColumn"></param>
        /// <param name="count">количество ячеек</param>
        public static void HorizontolCellsMerge(Table table, int iRow, int jColumn, int count)
        {
            TableRow row = table.Elements<TableRow>().ElementAt(iRow);
            TableCell cell = row.Elements<TableCell>().ElementAt(jColumn);
            TableCellProperties cp = cell.TableCellProperties;
            cp.Append(new HorizontalMerge()
            {
                Val = MergedCellValues.Restart
            });


            for (int k = 1; k < count; k++)
            {
                TableCell cell2 = row.Elements<TableCell>().ElementAt(jColumn + k);
                TableCellProperties cp2 = cell2.TableCellProperties;
                cp2.Append(new HorizontalMerge()
                {
                    Val = MergedCellValues.Continue
                });
            }
        }








        public static void HorizontolCellMergeGridSpan(Table table, int i, int j, int count)
        {
            TableRow row = table.Elements<TableRow>().ElementAt(i);
            TableCell cell = row.Elements<TableCell>().ElementAt(j);
            TableCellProperties cp = cell.TableCellProperties;

            GridSpan gridSpan = new GridSpan() { Val = count };
            cp.Append(gridSpan);
        }







        /// <summary>
        /// Вертикальное объединение ячеек
        /// </summary>
        /// <param name="table"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="count">количество ячеек</param>
        public static void VerticalCellsMerge(Table table, int i, int j, int count)
        {
            TableRow row = table.Elements<TableRow>().ElementAt(i);
            TableCell cell = row.Elements<TableCell>().ElementAt(j);
            TableCellProperties cp = cell.TableCellProperties;

            cp.Append(new VerticalMerge()
            {
                Val = MergedCellValues.Restart
            });


            for (int k = 1; k < count; k++)
            {
                TableRow row2 = table.Elements<TableRow>().ElementAt(i + k);
                TableCell cell2 = row2.Elements<TableCell>().ElementAt(j);
                TableCellProperties cp2 = cell2.TableCellProperties;
                cp2.Append(new VerticalMerge()
                {
                    Val = MergedCellValues.Continue
                });
            }

        }

        /// <summary>
        /// Объединение ячеек в прямоугольнике
        /// </summary>
        /// <param name="table"></param>
        /// <param name="startRow"></param>
        /// <param name="startColumn"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public static void BoxMerge(Table table, int startRow, int startColumn, int rows, int columns)
        {
            TableRow row = table.Elements<TableRow>().ElementAt(startRow);
            TableCell cell = row.Elements<TableCell>().ElementAt(startColumn);
            TableCellProperties cp = cell.TableCellProperties;
            cp.Append(new HorizontalMerge()
            {
                Val = MergedCellValues.Restart
            });
            cp.Append(new VerticalMerge()
            {
                Val = MergedCellValues.Restart
            });

            //первая строка
            for (int k = 1; k < columns; k++)
            {
                TableCell cell2 = row.Elements<TableCell>().ElementAt(startColumn + k);
                TableCellProperties cp2 = cell2.TableCellProperties;
                cp2.Append(new HorizontalMerge()
                {
                    Val = MergedCellValues.Continue
                });
            }


            //первый столбец
            for (int m = 1; m < rows; m++)
            {
                TableRow row2 = table.Elements<TableRow>().ElementAt(startRow + m);

                //for (int k = 0; k < cCount; k++)
                {
                    //if (m == i && k == j) continue;

                    TableCell cell2 = row2.Elements<TableCell>().ElementAt(startColumn);
                    TableCellProperties cp2 = cell2.TableCellProperties;

                    cp2.Append(new VerticalMerge()
                    {
                        Val = MergedCellValues.Continue
                    });

                    cp2.Append(new HorizontalMerge()
                    {
                        Val = MergedCellValues.Restart
                    });
                }
            }



            //оставшийся прямоугольник
            for (int m = 1; m < rows; m++)
            {
                TableRow row2 = table.Elements<TableRow>().ElementAt(startRow + m);

                for (int k = 1; k < columns; k++)
                {
                    //if (m == i && k == j) continue;

                    TableCell cell2 = row2.Elements<TableCell>().ElementAt(startColumn + k);
                    TableCellProperties cp2 = cell2.TableCellProperties;

                    cp2.Append(new VerticalMerge()
                    {
                        Val = MergedCellValues.Continue
                    });

                    cp2.Append(new HorizontalMerge()
                    {
                        Val = MergedCellValues.Continue
                    });
                }
            }
        }


        /// <summary>
        /// Удалить все границы ячеек
        /// </summary>
        /// <param name="table"></param>
        /// <param name="nRows"></param>
        /// <param name="nCol"></param>
        public static void DelAllBorder(Table table, int nRows, int nCol)
        {
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    DelCellBorder(table, i, j);
                }
            }
        }






        /// <summary>
        /// Удалить границы ячейки
        /// </summary>
        /// <param name="table">таблица</param>
        /// <param name="i">индекс строки</param>
        /// <param name="j">индекс столбца</param>
        /// <param name="top">true - удалить границу</param>
        /// <param name="bottom">true - удалить границу</param>
        /// <param name="left">true - удалить границу</param>
        /// <param name="right">true - удалить границу</param>
        public static void DelCellBorder(Table table, int i, int j, bool top = true, bool bottom = true, bool left = true, bool right = true)
        {
            // Find the second row in the table.
            TableRow row = table.Elements<TableRow>().ElementAt(i);

            // Find the third cell in the row.
            TableCell cell = row.Elements<TableCell>().ElementAt(j);

            TableCellProperties cp = cell.TableCellProperties;

            TableCellBorders cb = cp.TableCellBorders;

            if (cb == null)
            {
                cb = new TableCellBorders();
                cp.Append(cb);

            }
            EnumValue<BorderValues> borderValues = new EnumValue<BorderValues>(BorderValues.Nil);

            if (left) cb.LeftBorder = new LeftBorder() { Val = borderValues, Size = 0 };
            if (right) cb.RightBorder = new RightBorder() { Val = borderValues, Size = 0 };
            if (top) cb.TopBorder = new TopBorder() { Val = borderValues, Size = 0 };
            if (bottom) cb.BottomBorder = new BottomBorder() { Val = borderValues, Size = 0 };
        }



        /*
        public static void CellAlligment(Table table, int i, int j, TableCellVerticalAlignment verticalAlignment, )
        {
            // Find the second row in the table.
            TableRow row = table.Elements<TableRow>().ElementAt(i);

            // Find the third cell in the row.
            TableCell cell = row.Elements<TableCell>().ElementAt(j);

            TableCellProperties cp = cell.TableCellProperties;

            TableCellBorders cb = cp.TableCellBorders;

            if (cb == null)
            {
                cb = new TableCellBorders();
                cp.Append(cb);

            }
            EnumValue<BorderValues> borderValues = new EnumValue<BorderValues>(BorderValues.Nil);

            if (left) cb.LeftBorder = new LeftBorder() { Val = borderValues, Size = 0 };
            if (right) cb.RightBorder = new RightBorder() { Val = borderValues, Size = 0 };
            if (top) cb.TopBorder = new TopBorder() { Val = borderValues, Size = 0 };
            if (bottom) cb.BottomBorder = new BottomBorder() { Val = borderValues, Size = 0 };
        }


        */







        /// <summary>
        /// Задаём Границы таблицы
        /// </summary>
        /// <returns></returns>
        static TableBorders GetTableBorders()
        {
            //здесь задаёт стиль границ
            EnumValue<BorderValues> borderValues = new EnumValue<BorderValues>(BorderValues.Single);
            //Границы таблицы
            TableBorders tableBorders = new TableBorders(
                                 new TopBorder { Val = borderValues, Size = 4 },
                                 new BottomBorder { Val = borderValues, Size = 4 },
                                 new LeftBorder { Val = borderValues, Size = 4 },
                                 new RightBorder { Val = borderValues, Size = 4 },
                                 new InsideHorizontalBorder { Val = borderValues, Size = 4 },
                                 new InsideVerticalBorder { Val = borderValues, Size = 4 });

            return tableBorders;
        }



        /// <summary>
        /// Таблица на всю ширину страницы
        /// </summary>
        /// <returns></returns>
        static TableWidth GetTableWidth()
        {
            //Для того чтобы таблица заняла всю ширину страницы можно использовать TableWidth заданную следующим образом
            // habr.com/ru/company/pvs-studio/blog/573866/

            TableWidth tableWidth = new TableWidth()
            {
                Width = "5000",
                Type = TableWidthUnitValues.Pct
            };
            return tableWidth;
        }
    }
}
