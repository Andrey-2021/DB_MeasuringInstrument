using System.Diagnostics;
using ViewInterfaces;

namespace Presenters.MenuDocuments
{
    /// <summary>
    /// Открыть созданный документ Word средствами Windows
    /// </summary>
    internal class RunWordDocInWindows
    {
        /// <summary>
        /// Открыть документ средствами Windows
        /// </summary>
        /// <param name="fileName">имя файла</param>
        public static void RunDoc(string fileName, IView view)
        {
            try
            {
                var process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = fileName
                };
                process.Start();
            }
            catch (Exception ex)
            {
                view.ShowError("При открытие созданного документа средствами Windows возникла ошибка:" + ex.Message);
            }
        }
    }
}
