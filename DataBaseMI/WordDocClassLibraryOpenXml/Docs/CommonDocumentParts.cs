using DocumentFormat.OpenXml.Wordprocessing;

namespace WordDocClassLibraryOpenXml.Docs
{

    /// <summary>
    /// Общие методы
    /// </summary>
    internal class CommonDocumentParts
    {

        /// <summary>
        /// Создать пустой параграф
        /// </summary>
        /// <param name="numberBreak">Количество переводов на новую строку</param>
        /// <returns></returns>
        public static Paragraph CreateEnumPargraph(int numberBreak=0)
        {
            Paragraph p19 = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
            Run r19 = RunExtension.CreateRun().RunFont("Times New Roman").RunSize(14).RunAddText("");
            p19.Append(r19);
            for (int i = 0; i < numberBreak; i++)
            {
                r19.AppendChild(new Break());
            }
            return p19;
        }


        /// <summary>
        /// Создать таблицу с подписями
        /// </summary>
        public static Table CreateSignatureTable(string? job, string? director, string? calibrator)
        {
            //таблица Подписи
            var t2 = TabExtension2.InsertTable(5, 5, new int[] { 40, 5, 20, 5, 30 });
            //TabExt2.DelAllBorder(t2, 5, 5);

            //строка 1
            TabExtension2.DelCellBorder(t2, 0, 0);
            TabExtension2.DelCellBorder(t2, 0, 1);
            TabExtension2.DelCellBorder(t2, 0, 2);
            TabExtension2.DelCellBorder(t2, 0, 3);
            TabExtension2.DelCellBorder(t2, 0, 4);

            //строка 2
            TabExtension2.DelCellBorder(t2, 1, 0, false);
            TabExtension2.DelCellBorder(t2, 1, 1);
            TabExtension2.DelCellBorder(t2, 1, 2, false);
            TabExtension2.DelCellBorder(t2, 1, 3);
            TabExtension2.DelCellBorder(t2, 1, 4, false);

            //строка 3
            TabExtension2.DelCellBorder(t2, 2, 0);
            TabExtension2.DelCellBorder(t2, 2, 1);
            TabExtension2.DelCellBorder(t2, 2, 2);
            TabExtension2.DelCellBorder(t2, 2, 3);
            TabExtension2.DelCellBorder(t2, 2, 4);

            //строка 4
            TabExtension2.DelCellBorder(t2, 3, 0);
            TabExtension2.DelCellBorder(t2, 3, 1);
            TabExtension2.DelCellBorder(t2, 3, 2);
            TabExtension2.DelCellBorder(t2, 3, 3);
            TabExtension2.DelCellBorder(t2, 3, 4);

            //строка 5
            TabExtension2.DelCellBorder(t2, 4, 0);
            TabExtension2.DelCellBorder(t2, 4, 1);
            TabExtension2.DelCellBorder(t2, 4, 2, false);
            TabExtension2.DelCellBorder(t2, 4, 3);
            TabExtension2.DelCellBorder(t2, 4, 4, false);


            //1-й стобец
            TabExtension2.ChangeText(t2, 0, 0, job);
            TabExtension2.ChangeText(t2, 1, 0, "должность руководителя подразделения");
            TabExtension2.ChangeText(t2, 2, 0, "");
            TabExtension2.ChangeText(t2, 3, 0, "Поверитель");
            TabExtension2.ChangeText(t2, 4, 0, "");



            //3-й стобец
            TabExtension2.ChangeText(t2, 0, 2, "");
            TabExtension2.ChangeText(t2, 1, 2, "подпись");
            TabExtension2.ChangeText(t2, 2, 2, "");
            TabExtension2.ChangeText(t2, 3, 2, "");
            TabExtension2.ChangeText(t2, 4, 2, "подпись");

            //5-й стобец
            TabExtension2.ChangeText(t2, 0, 4, director);
            TabExtension2.ChangeText(t2, 1, 4, "инициалы, фамилия");
            TabExtension2.ChangeText(t2, 2, 4, "");
            TabExtension2.ChangeText(t2, 3, 4, calibrator);
            TabExtension2.ChangeText(t2, 4, 4, "инициалы, фамилия");

            return t2;
        }
    }
}
