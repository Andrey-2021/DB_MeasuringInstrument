using Xceed.Words.NET;

namespace WordDocClassLibrary
{
    public class WordDoc
    {
       
        public void CreateDoc()
        {
            string fileName = @"E:\exempleWord.docx";

            var doc = DocX.Create(fileName);

            doc.InsertParagraph("Hello Word");

            doc.Save();

            //Process.Start("WINWORD.EXE", fileName);
        }

    }
}