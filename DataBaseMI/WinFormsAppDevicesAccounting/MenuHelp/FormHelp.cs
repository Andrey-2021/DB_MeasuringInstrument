using ViewInterfaces;

namespace WinFormsAppDevicesAccounting.Windows
{
    /// <summary>
    /// Окно, которое видит пользователь при выборе меню "Помощь" или "О программе"
    /// </summary>
    public partial class FormHelp : BaseViewShowErrorAndWarning, IHelpView
    {
        public event EventHandler? GettingParagraphList;
        public event EventHandler<string>? GettingText;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormHelp()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
            this.Shown += OnGettingParagraphList;
            listBoxParagraphList.SelectedIndexChanged += ListBoxParagraphListSelectedIndexChanged;
        }

        public void SetTitle(string? winTitle)
        {
            this.Text = winTitle;
        }

        /// <summary>
        /// Метод события. Используемый для создания события запроса текста выбранного параграфа
        /// </summary>
        void OnGettingText(string? parParagraphName)
        {
            if (!string.IsNullOrEmpty(parParagraphName)) GettingText?.Invoke(this, parParagraphName);
        }

        /// <summary>
        /// Метод события. Используемый для создания события запроса списка параграфов
        /// </summary>
        void OnGettingParagraphList(object? sender, EventArgs e)
        {
            GettingParagraphList?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Показать список параграфов
        /// </summary>
        public void ShowParagraphList(List<string?> paragraphsNames)
        {
            listBoxParagraphList.Items.Clear();
            foreach (var item in paragraphsNames)
            {
                if (!string.IsNullOrEmpty(item)) listBoxParagraphList.Items.Add(item);
            }

            //если в списке есть данные, выбираем первую строку
            if (listBoxParagraphList.Items.Count > 0) listBoxParagraphList.SelectedIndex = 0;
        }

        /// <summary>
        /// Показать текст/описание
        /// </summary>
        public void ShowText(string? text)
        {
            textBoxText.Text = text;
        }

        /// <summary>
        /// Метод, обрабатывает событие "выбрано новое поле в ListBox"
        /// </summary>
        private void ListBoxParagraphListSelectedIndexChanged(object? sender, EventArgs e)
        {
            OnGettingText(listBoxParagraphList.SelectedItem.ToString());
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
