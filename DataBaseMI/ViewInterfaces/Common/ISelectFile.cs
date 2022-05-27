using System.Drawing;

namespace ViewInterfaces.Common
{
    /// <summary>
    /// Выбор папки и файла
    /// </summary>
    public interface ISelectFile
    {
        /// <summary>
        /// Выбрать папку и ввести имя файла
        /// </summary>
        /// <param name="fileName">Предлагаемое имя для файла</param>
        /// <returns>Новое имя файла</returns>
        public string SelectFileForSave(string fileName);

        /// <summary>
        /// Загрузить картинку из файла
        /// </summary>
        /// <returns>Загруженная картинка</returns>
        public Image? LoadFileFromDisk();
    }
}
