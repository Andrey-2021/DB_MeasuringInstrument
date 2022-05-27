using CommonClassLibrary;

namespace WordDocDTO
{

    /// <summary>
    /// Объект передачи данных для создания Паспорта СИ
    /// </summary>
    public class PasportDTO
    {
        public EnumPasportVersion Ver { get; set; }

        /// <summary>
        /// Имя файла, в который сохраняем паспорт
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// СИ
        /// </summary>
        public MeasuringInstrument? MI { get; set;}

        /// <summary>
        /// Список, содержащий информацию о ремоснта СИ
        /// </summary>
        public List<Repair>? Repairs { get; set; }

    }
}