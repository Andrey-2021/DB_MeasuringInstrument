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
    /// Presenter для составления документа "Извещения о непригодности к применению"
    /// </summary>
    internal class UnsuitabilityPresenter : IPresenter
    {
        IUnsuitabilityView _view;
        protected IRepository _repositiry;

        /// <summary>
        /// Конструктор
        /// </summary>
        public UnsuitabilityPresenter(IUnsuitabilityView view, IRepository repositiry)
        {
            _view = view;
            _repositiry = repositiry;

            _view.RefreshingAllMeasuringInstruments += RefreshAllDatas;
            _view.ClosingMyWindow += CloseViewWindow;

            _view.FindingUnsuitability += FindUnsuitabilityDocuments;
            _view.SavingUnsuitabilityInDocxFile += SaveUnsuitability;
        }

        public void Run()
        {
            _view.ShowView();
        }


        public async void RefreshAllDatas(object sender, FindMeasuringInstrumentDTO data)
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
        public void CloseViewWindow(object sender, EventArgs args)
        {
            _view.CloseView();
        }



        public async void FindUnsuitabilityDocuments(object sender, MeasuringInstrument data)
        {
            try
            {
                //todo сделать свой метод чтения из БД  асинхронным

                var list = _repositiry.ReadFromDb<Unsuitability>(x => x.MeasuringInstrumentId == data.Id); //Условие отбора записей в БД
                _view.PrintUnsuitabilityData(list);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }







        /// <summary>
        /// Создать "Извещение о непригодности к применению"
        /// </summary>
        public void SaveUnsuitability(Object sender, Unsuitability unsuitability)
        {
            var saveClass = Conteiner.GetInstance().GetClassInstance<ISelectFile>();
            if (saveClass == null) throw new NullReferenceException("Нет класса , реализующего интерфейс " + nameof(ISelectFile));

            string? fileName = null;
            fileName = saveClass.SelectFileForSave("Извещение о непригодности к применению");
            if (String.IsNullOrEmpty(fileName)) return;

            try
            {
                UnsuitabilityDTO dto = new UnsuitabilityDTO() { Unsuitability = unsuitability, FileName = fileName };
                MainDoc.CreateUnsuitability(dto);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
                return;
            }
            RunWordDocInWindows.RunDoc(fileName, _view);
        }
    }
}
