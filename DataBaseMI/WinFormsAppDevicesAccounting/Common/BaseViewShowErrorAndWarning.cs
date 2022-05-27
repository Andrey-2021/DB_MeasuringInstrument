using System.ComponentModel;
using ViewInterfaces;

namespace WinFormsAppDevicesAccounting.Windows
{
    /// <summary>
    /// Базовый класс. Содержит базовае методы.
    /// (методы: показа View(Формы); закрытие окна;  вывода сообщений предупреждения, ошибки, информации , окна с выбором)
    /// </summary>
    [DesignTimeVisible(false)]
    public class BaseViewShowErrorAndWarning : Form, IView
    {
        public EnumWhoClosingWindow WhoClosingWindow { get; set; } = EnumWhoClosingWindow.empty;
        public event EventHandler? ClosingMyWindow;

        /// <summary>
        /// Показать предупреждение
        /// </summary>
        /// <param name="text"></param>
        public void ShowWarning(string? text)
        {
            MessageBox.Show(text, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Показать ошибку
        /// </summary>
        /// <param name="text"></param>
        public void ShowError(string? text)
        {
            MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Показать информационное сообщение
        /// </summary>
        /// <param name="text"></param>
        public void ShowInfo(string? text)
        {
            MessageBox.Show(text, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Показать окно с кнопками выбора
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool ShowChoice(string? text)
        {
            var result = MessageBox.Show(text, "Внимание, выберите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) return true;
            return false;
        }

        /// <summary>
        /// Показать окно
        /// </summary>
        public virtual void ShowView()
        {
            WhoClosingWindow = EnumWhoClosingWindow.empty;
            this.ShowDialog();
        }

        /// <summary>
        /// Закрыть окно
        /// </summary>
        public void CloseView()
        {
            if (WhoClosingWindow == EnumWhoClosingWindow.empty)
            {
                WhoClosingWindow = EnumWhoClosingWindow.presener;
                this.Close();
            }
        }

        /// <summary>
        /// Вызвать срабатываеие события закрытия окна
        /// </summary>
        public void OnClosingMyWindow(object sender, EventArgs e)
        {
            if (ClosingMyWindow != null)
            {
                ClosingMyWindow(this, EventArgs.Empty);
            }
            else
            {
                //ShowError("В программе нет возможности закрыть это окно!");
                throw new NullReferenceException("Закрытие окна не обрабатывается");
            }
        }


        /// <summary>
        /// Выполняем обработку события "Закрытие формы"
        /// </summary>
        public void ExecuteFormClosingEvent(object? sender, FormClosingEventArgs e)
        {
            switch (WhoClosingWindow)
            {
                case EnumWhoClosingWindow.window:
                    break;
                case EnumWhoClosingWindow.presener:
                    break;
                case EnumWhoClosingWindow.empty:
                    WhoClosingWindow = EnumWhoClosingWindow.window;
                    OnClosingMyWindow(this, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }
    }
}
