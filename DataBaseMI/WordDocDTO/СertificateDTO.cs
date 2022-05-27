using CommonClassLibrary;

namespace WordDocDTO
{

    /// <summary>
    /// Объект передачи данных для создания "Свидетельства о поверке"
    /// </summary>
    public class СertificateDTO
    {
        public EnumСertificateVersion Ver { get; set; }

        /// <summary>
        /// Имя файла, в который сохраняем 
        /// </summary>
        public string? FileName { get; set; }

        public Сertificate? Сertificate { get; set;}

    }
}