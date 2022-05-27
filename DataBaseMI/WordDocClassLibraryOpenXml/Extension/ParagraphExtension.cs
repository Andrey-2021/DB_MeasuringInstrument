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
    public static class ParagraphExtension
    {

        /// <summary>
        /// Создать параграф
        /// </summary>
        /// <returns></returns>
        public static Paragraph CreateParagraph()
        {
            Paragraph paragraph2 = new Paragraph();
            ParagraphProperties pp = new ParagraphProperties();
            paragraph2.Append(pp); // Add paragraph properties to your paragraph
            return paragraph2;
        }

        /// <summary>
        /// Новая строка (пустой параграф)
        /// </summary>
        /// <returns></returns>
        public static Paragraph ParagraphNewLine()
        {
            Paragraph p = ParagraphExtension.CreateParagraph().ParagraphJustification(JustificationValues.Left);
            Run r = RunExtension.CreateRun();
            //r.AppendChild(new CarriageReturn()); //перенос строки
            p.Append(r);
            
            return p;
        }



        /// <summary>
        /// Выравнивание параграфа
        /// </summary>
        /// <param name="paragraph2"></param>
        /// <param name="justification"></param>
        /// <returns></returns>
        public static Paragraph ParagraphJustification(this Paragraph paragraph2, JustificationValues justification)
        {
            ParagraphProperties pp = paragraph2.ParagraphProperties;
            pp.Justification = new Justification() { Val = justification };
            return paragraph2;
        }

    }
}
