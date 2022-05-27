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
    public static class DocExtension
    {
        /// <summary>
        /// Создание основных частей документа
        /// </summary>
        /// <param name="package"></param>
        public static WordprocessingDocument CreateMainPart(WordprocessingDocument package)
        {
            package.AddMainDocumentPart(); // Add a new main document part. 

            // Create the Document DOM. 
            package.MainDocumentPart.Document = new Document(new Body());
            MainDocumentPart mainPart = package.MainDocumentPart;
            Body body = mainPart.Document.Body;

            SectionProperties props = new SectionProperties();
            body.AppendChild(props);

            return package;
        }



        /// <summary>
        /// Горизонтальная ориентация страницы
        /// </summary>
        public static void SetHorizontalOrient(WordprocessingDocument package)
        {
            MainDocumentPart mainPart = package.MainDocumentPart;

            //Смена ориентации страницы
            var sectionProperties = mainPart.Document
                            .Body
                            .GetFirstChild<SectionProperties>();

            sectionProperties.AddChild(new PageSize()
            {
                Width = (UInt32Value)15840U,
                Height = (UInt32Value)12240U,
                Orient = PageOrientationValues.Landscape
            });
        }


        //habr.com/ru/company/pvs-studio/blog/573866/
        /// <summary>
        /// Разрыв страницы
        /// </summary>
        /// <param name="doc"></param>
        public static void InsertWordBreak(WordprocessingDocument doc)
        {
            MainDocumentPart mainPart = doc.MainDocumentPart;
            mainPart.Document.Body.InsertAfter(new Paragraph(
                                                 new Run(
                                                   new Break()
                                                   {
                                                       Type = BreakValues.Page
                                                   })),
                                               mainPart.Document.Body.LastChild);
        }


    }
}
