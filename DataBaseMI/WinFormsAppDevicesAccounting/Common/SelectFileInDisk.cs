using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Выбор файла
    /// </summary>
    public class SelectFileInDisk: ISelectFile
    {
        /// <summary>
        /// Выбираем/создаём файл на диске, в который будем записывать документ
        /// </summary>
        /// <param name="fileName">Исходное имя файла</param>
        /// <returns>Итоговое имя файла</returns>
        public string SelectFileForSave(string fileName)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = fileName;

            saveFile.Filter = "docx files(*.docx)|*.docx|Txt files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return String.Empty;

            return saveFile.FileName; // получаем выбранный файл
        }


        /// <summary>
        /// Загрузка файла, содержащего картинку
        /// </summary>
        /// <returns>Картинка</returns>
        public Image? LoadFileFromDisk()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "";
            openFileDialog.Filter = "Image files (*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return null;

            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            try
            {
                return Image.FromFile(filename);
            }
            catch 
            {
                return null;
            }
           
        }
    }
}
