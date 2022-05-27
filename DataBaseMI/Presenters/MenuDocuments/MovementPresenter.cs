using CommonClassLibrary;
using CommonInterface;
using ConteinerLibrary;
using Presenters.MenuDocuments;
using RepositoryInterfaces;
using ViewInterfaces.Common;
using ViewInterfaces.Documents;
using WordDocClassLibraryOpenXml;
using WordDocDTO;

namespace Presenters
{
    /// <summary>
    /// Presenter для "Накладная на внутреннее перемещение"
    /// </summary>
    internal class MovementPresenter : IPresenter
    {
        IMovementView _view;
        protected IRepository _repositiry;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MovementPresenter(IMovementView view, IRepository repositiry)
        {
            _view = view;
            _repositiry = repositiry;

            _view.RefreshingAllMeasuringInstruments += RefreshAllDatas;
            _view.ClosingMyWindow += CloseViewWindow;

            _view.FindingMovment += FindMovmentDocuments;
            _view.SavingMovingInDocxFile += SaveMovingDoc;
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


        public async void FindMovmentDocuments(object? sender, MeasuringInstrument data)
        {
            try
            {
                //todo сделать свой метод чтения из БД  асинхронным

                var list = _repositiry.ReadFromDb<Moving>(x => x.MeasuringInstrumentId == data.Id); //Условие отбора записей в БД
                _view.PrintMovmentData(list);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }


        /// <summary>
        /// Создать "Накладная на внутреннее перемещение"
        /// </summary>
        public void SaveMovingDoc(Object? sender, Moving moving)
        {
            var saveClass = Conteiner.GetInstance().GetClassInstance<ISelectFile>();
            if (saveClass == null) throw new NullReferenceException("Нет класса , реализующего интерфейс " + nameof(ISelectFile));

            string? fileName = null;
            fileName = saveClass.SelectFileForSave("Накладная на внутреннее перемещение");
            if (String.IsNullOrEmpty(fileName)) return;

            try
            {
                MovementDTO dto = new MovementDTO() { Moving = moving, FileName = fileName };
                MainDoc.CreateMovement(dto);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
                return;
            }
            RunWordDocInWindows.RunDoc(fileName,_view );
        }
    }
}
