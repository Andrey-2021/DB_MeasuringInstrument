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
    public class CreateNewDoc_Old
    {

        //WordprocessingDocument doc;

        public CreateNewDoc_Old(string fileName)
        {
            using (WordprocessingDocument package 
                = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
            {
                // Add a new main document part. 
                package.AddMainDocumentPart();

                // Create the Document DOM. 
                package.MainDocumentPart.Document =
                  new Document(
                    new Body(
                      //new Paragraph(
                      //  new Run(
                      //    //new Text("Hello World!")
                      //      ))


                      ));

                AddText(package, "Привет", new List<TextProp> { TextProp.Bold }, null ,JustificationValues.Center);
                AddText(package, "Салют", new List<TextProp> { TextProp.Empty }, new Color() { Val = "FF0000" }, JustificationValues.Left);
                AddText(package, "Ура", new List<TextProp> { TextProp.Italic }, null, JustificationValues.Right);
                AddText(package, "ДА", new List<TextProp> { TextProp.Empty }, null, JustificationValues.Center);
                AddText(package, "ДА", new List<TextProp> { TextProp.Underline, TextProp.Bold }, null, JustificationValues.Left);
                AddText(package, "ДА", new List<TextProp> { TextProp.Empty }, null, JustificationValues.Right);

                // Save changes to the main document part. 
                //package.MainDocumentPart.Document.Save();
                //this.doc = package;
                package.Save();
            }
        }


        public enum TextProp
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
            Italic,

            Underline
        }




        public void AddText(WordprocessingDocument doc,
                            string text, 
                            List<TextProp> properties,
                            DocumentFormat.OpenXml.Wordprocessing.Color? color,
                            JustificationValues justification)  
        {
            MainDocumentPart mainPart = doc.MainDocumentPart;
            Body body = mainPart.Document.Body;

            //    Paragraph paragraph = new Paragraph();
            //        Run run = new Run();
            //            Text t = new Text(text);
            //            run.Append(t);
            //    paragraph.Append(run);
            //body.AppendChild(paragraph);


            Paragraph paragraph2 = new Paragraph();
            //выравнивание 
            ParagraphProperties pp = new ParagraphProperties();
            pp.Justification = new Justification() { Val = justification };
            paragraph2.Append(pp); // Add paragraph properties to your paragraph

            Run run2 = new Run();
            
            RunProperties rp2 = new RunProperties();

            foreach (var property in properties)
            {
                if (property == TextProp.Bold) rp2.Bold = new Bold();
                if (property == TextProp.Italic) rp2.Italic = new Italic();
                if (property == TextProp.Underline) rp2.Underline = new Underline() { Val= UnderlineValues.Single};
            }
            if (color is not null) rp2.Color = color;

            run2.Append(rp2);

            Text t2 = new Text(text);
            run2.Append(t2);
            paragraph2.Append(run2);

            body.AppendChild(paragraph2);
        }

    }
}
