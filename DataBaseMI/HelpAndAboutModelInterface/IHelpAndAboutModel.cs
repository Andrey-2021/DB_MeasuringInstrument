namespace HelpAndAboutModelInterface
{
    /// <summary>
    /// Model - класс, предоставляет данные, которые будут выводится пользователю при выборе меню "Помощь" и "О программе"
    /// </summary>
    public interface IHelpAndAboutModel
    {
        /// <summary>
        /// Получить список названий параграфов
        /// </summary>
        /// <returns></returns>
        public List<string?> GetParagraphNamesList();

        /// <summary>
        /// Получить содержимое/текст параграфа
        /// </summary>
        /// <param name="parParagraphName">Название параграфа</param>
        /// <returns>Текс, содержащийся в параграфе</returns>
        string? GetParagraphText(string? parParagraphName);
    }
}
