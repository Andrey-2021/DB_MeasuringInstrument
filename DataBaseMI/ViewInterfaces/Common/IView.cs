namespace ViewInterfaces
{
    /// <summary>
    /// Общий (базовый) интерфейс для всех окон
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Показать окно
        /// </summary>
        public void ShowView();

        /// <summary>
        /// Закрыть окно
        /// </summary>
        public void CloseView();

        /// <summary>
        /// Показать предупреждение (Warning)
        /// </summary>
        /// <param name="text"></param>
        public void ShowWarning(string? text);

        /// <summary>
        /// Показать ошибку (Error)
        /// </summary>
        /// <param name="text"></param>
        public void ShowError(string? text);

        /// <summary>
        /// Показать сообщение
        /// </summary>
        /// <param name="text"></param>
        public void ShowInfo(string? text);

        /// <summary>
        /// Диалоговое окно с выбором вариантов для пользователя 
        /// </summary>
        /// <param name="text"></param>
        public bool ShowChoice(string? text);

        /// <summary>
        /// Закрытие окна
        /// </summary>
        public event EventHandler? ClosingMyWindow;

        /// <summary>
        /// Показывает кто инициатор закрытия окна
        /// </summary>
        public EnumWhoClosingWindow WhoClosingWindow { get; set; }

        /// <summary>
        /// Закрытие окна.
        /// Вызывает исключение, сообщающего о том, что необходимо закрыть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnClosingMyWindow(object sender, EventArgs e);
    }
}
