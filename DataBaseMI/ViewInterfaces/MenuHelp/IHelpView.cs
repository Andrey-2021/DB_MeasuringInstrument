namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс окна, в которое выводится справочная информация, при выборе пользователем подменю "Помощь" и "О программе" основного меню "Справка"
    /// </summary>
    public interface IHelpView : IView
    {
        /// <summary>
        /// Событие. Предоставить список параграфов.
        /// </summary>
        public event EventHandler GettingParagraphList;

        /// <summary>
        /// Событие. Предоставить текст для параграфа с заданным именем
        /// </summary>
        public event EventHandler<string> GettingText;

        /// <summary>
        /// Показать пользователю список параграфов
        /// </summary>
        public void ShowParagraphList(List<string?> paragraphsNames);

        /// <summary>
        /// Показать пользователю текст/описание
        /// </summary>
        public void ShowText(string? text);

        /// <summary>
        /// Задать заголовок окна
        /// </summary>
        /// <param name="winTitle">Текст для заголовка окна</param>
        public void SetTitle(string? winTitle);
    }
}
