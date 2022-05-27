using CommonClassLibrary;
using CommonInterface;
using RepositoryInterfaces;
using ViewInterfaces;

namespace Presenters
{
    /// <summary>
    /// Presenter для окна "Справочник"
    /// </summary>
    internal class ManualPresenter : IPresenter
    {
        IManualView _view;
        protected IRepository _repositiry;

        /// <summary>
        /// Конструктор
        /// </summary>
        public ManualPresenter(IManualView view, IRepository repositiry)
        {
            _view = view;
            _repositiry = repositiry;

            _view.RefreshingAllMeasuringInstruments += RefreshAllDatas;
            _view.ClosingMyWindow += CloseViewWindow;
        }

        public void Run()
        {
            _view.ShowView();
        }


        public async void RefreshAllDatas(object? sender, FindMeasuringInstrumentDTO data)
        {
            try
            {
                //todo сделать свой метод чтения из БД  асинхронным

                var list = _repositiry.ReadFromDb<MeasuringInstrument>(data.Predicate);
                _view.PrintData(list);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
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
