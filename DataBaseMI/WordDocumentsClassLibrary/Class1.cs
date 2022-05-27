using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WordDocumentsClassLibrary
{
    public class Class1
    {

        void Create()
        {

            string pathToDocFile = "doc1.doc";
            using (WordprocessingDocument doc =
                     WordprocessingDocument.Create(pathToDocFile,
                                                   WordprocessingDocumentType.Document,

                                                   true))
            {
                MainDocumentPart mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph paragraph = body.AppendChild(new Paragraph());
                Run run = paragraph.AppendChild(new Run());


                SectionProperties props = new SectionProperties();
                body.AppendChild(props);
            }

        }

        void AddText(WordprocessingDocument doc, string text)
        {
            MainDocumentPart mainPart = doc.MainDocumentPart;
            Body body = mainPart.Document.Body;
            Paragraph paragraph = body.AppendChild(new Paragraph());

            Run run = paragraph.AppendChild(new Run());
            run.AppendChild(new Text(text));
            run.PrependChild(new RunProperties());
        }

        public static void InsertWordHeading1(WordprocessingDocument doc,
                                      string headingText)
        {
            MainDocumentPart mainPart = doc.MainDocumentPart;
            Paragraph para = mainPart.Document.Body.AppendChild(new Paragraph());
            Run run = para.AppendChild(new Run());
            run.AppendChild(new Text(headingText));
            para.ParagraphProperties = new ParagraphProperties(
                                         new ParagraphStyleId() { Val = "Heading1" });
        }
    }
}