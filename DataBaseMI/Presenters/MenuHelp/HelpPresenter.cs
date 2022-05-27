using CommonInterface;
using HelpAndAboutModelInterface;
using ViewInterfaces;

namespace Presenters
{
    /// <summary>
    /// Presenter для подменю "Помощь" и "О программе", основного меню "Справка"
    /// </summary>
    internal class HelpPresenter : IPresenter
    {
        /// <summary>
        /// Окно, выводимое пользователю
        /// </summary>
        IHelpView _view;

        /// <summary>
        /// Model - класс, из которого берём справочные данные при выборе пользователем меню "Помощь" или "О программе"
        /// </summary>
        IHelpAndAboutModel _model;

        /// <summary>
        /// Конструктор
        /// </summary>
        public HelpPresenter(IHelpView view, IHelpAndAboutModel model, WorkMode workMode)
        {
            _model = model;
            _view = view;
            this._view.GettingParagraphList += GetParagraphList;
            this._view.GettingText += GetText;
            _view.ClosingMyWindow += CloseViewWindow;

            switch (workMode)
            {
                case WorkMode.help:
                    _view.SetTitle("Помощь");
                    break;
                case WorkMode.about:
                    _view.SetTitle("О программе");
                    break;
                default:
                    _view.SetTitle("");
                    break;
            }
        }

        public void Run()
        {
            _view.ShowView();
        }

        /// <summary>
        /// Запрос у модели списка параграфов 
        /// </summary>
        void GetParagraphList(object? parObject, EventArgs parArgs)
        {
            var list = _model.GetParagraphNamesList();
            _view.ShowParagraphList(list);
        }

        /// <summary>
        /// Запрос у модели содержимого параграфа
        /// </summary>
        void GetText(object? parObject, string parParagraphName)
        {
            var text = _model.GetParagraphText(parParagraphName);
            _view.ShowText(text);
        }

        /// <summary>
        /// Закрыть окно
        /// </summary>
        public void CloseViewWindow(object? sender, EventArgs args)
        {
            _view.CloseView();
        }
    }
}
