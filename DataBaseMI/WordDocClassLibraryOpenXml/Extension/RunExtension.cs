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
    public static class RunExtension
    {
        public static Run CreateRun()
        {
            Run run2 = new Run();
            RunProperties rp2 = new RunProperties();
            run2.Append(rp2);
            return run2;
        }

        
       


        public static Run RunBold(this Run run2)
        {
            RunProperties rp2 = run2.RunProperties;
            rp2.Bold = new Bold();
            return run2;
        }

        public static Run RunItalic(this Run run2)
        {
            RunProperties rp2 = run2.RunProperties;
            rp2.Italic = new Italic();
            return run2;
        }

        public static Run RunUnderline(this Run run2)
        {
            RunProperties rp2 = run2.RunProperties;
            rp2.Underline = new Underline();
            return run2;
        }

        public static Run RunFont(this Run run2, string font)
        {
            RunProperties rp2 = run2.RunProperties;
            rp2.RunFonts = new RunFonts { Ascii = font, HighAnsi= font };
            return run2;
        }

        public static Run RunSize(this Run run2, int size)
        {
            RunProperties rp2 = run2.RunProperties;
            rp2.AddChild(new FontSize() { Val = (size*2).ToString() });
            return run2;
        }


        public static Run RunColor(this Run run2, DocumentFormat.OpenXml.Wordprocessing.Color? color)
        {
            RunProperties rp2 = run2.RunProperties;
            rp2.Color = color;
            return run2;
        }

        public static Run RunAddText(this Run run2, string? text)
        {
            RunProperties rp2 = run2.RunProperties;
            Text t2 = new Text(text);
            run2.Append(t2);
            return run2;
        }
    }
}
