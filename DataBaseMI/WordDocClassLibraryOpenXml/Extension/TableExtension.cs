using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;


namespace WordDocClassLibraryOpenXml
{
    public static class TableExtension
    {

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
            //https://habr.com/ru/company/pvs-studio/blog/573866/
         
            TableWidth tableWidth = new TableWidth()
            {
                Width = "5000",
                Type = TableWidthUnitValues.Pct
            };
            return tableWidth;
        }

        public static Table CreateTable()
        {
            Table table = new Table();

            //сразу добавляем 
            TableProperties props = new TableProperties();
            props.Append(GetTableWidth()); //Таблица на всю ширину страницы
            props.Append(GetTableBorders());//Границы таблицы
            table.AppendChild<TableProperties>(props);

            return table;
        }

        //public static Table AddRow(this Table table)
        //{
        //    TableRow tr1 = new TableRow();
        //    table.Append(tr1);
        //    return table;
        //}

        public static TableRow CreateRow()
        {
            TableRow tr1 = new TableRow();
            return tr1;
        }


        //как создать таблицу в документе Word и использовать TableCellProperties класс для указания ширины ячейки таблицы.
        //https://docs.microsoft.com/ru-ru/dotnet/api/documentformat.openxml.wordprocessing.tablecellproperties?view=openxml-2.8.1


        public static TableRow AddCell(this TableRow tr1, Paragraph? p11, int size)
        {
            TableCell tc11 = new TableCell();
            if (p11!=null) tc11.Append(p11);

            //сразу добавляем 
            var tCp = new TableCellProperties( new TableCellWidth() { Type=TableWidthUnitValues.Dxa, Width=size.ToString()});
            tc11.Append(tCp);

            tr1.Append(tc11);
            return tr1;
        }




        /// <summary>
        /// Создать заполненную таблицу из матрицы строк
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="table"></param>
        public static void InsertWordTable(WordprocessingDocument doc,
                                   string[,] table)
        {
            DocumentFormat.OpenXml.Wordprocessing.Table dTable =
              new DocumentFormat.OpenXml.Wordprocessing.Table();

            TableProperties props = new TableProperties();
            props.Append(GetTableWidth()); //Таблица на всю ширину страницы
            props.Append(GetTableBorders());//Границы таблицы

            dTable.AppendChild<TableProperties>(props);

            for (int i = 0; i < table.GetLength(0); i++)
            {
                var tr = new TableRow();

                for (int j = 0; j < table.GetLength(1); j++)
                {
                    var tc = new TableCell();
                    tc.Append(new Paragraph(new Run(new Text(table[i, j]))));

                    tc.Append(new TableCellProperties());

                    tr.Append(tc);
                }
                dTable.Append(tr);
            }
            doc.MainDocumentPart.Document.Body.Append(dTable);
        }


    }
}
