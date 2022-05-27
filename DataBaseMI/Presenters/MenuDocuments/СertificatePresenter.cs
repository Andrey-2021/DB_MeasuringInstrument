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
    /// Presenter для "Свидетельство о поверке"
    /// </summary>
    internal class СertificatePresenter : IPresenter
    {
        IСertificateView _view;
        protected IRepository _repositiry;

        /// <summary>
        /// Конструктор
        /// </summary>
        public СertificatePresenter(IСertificateView view, IRepository repositiry)
        {
            _view = view;
            _repositiry = repositiry;

            _view.RefreshingAllMeasuringInstruments += RefreshAllDatas;
            _view.ClosingMyWindow += CloseViewWindow;

            _view.FindingСertificate += FindСertificateDocuments;
            _view.SavingСertificateInDocxFile += SaveСertificateDoc;
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


        public async void FindСertificateDocuments(object? sender, MeasuringInstrument data)
        {
            try
            {
                //todo сделать свой метод чтения из БД  асинхронным

                var list = _repositiry.ReadFromDb<Сertificate>(x => x.MeasuringInstrumentId == data.Id); //Условие отбора записей в БД
                _view.PrintСertificateData(list);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }




        /// <summary>
        /// Создать "Свидетельство о поверке"
        /// </summary>
        public void SaveСertificateDoc(Сertificate? cr, EnumСertificateVersion vers)
        {
            var saveClass = Conteiner.GetInstance().GetClassInstance<ISelectFile>();
            if (saveClass == null) throw new NullReferenceException("Нет класса , реализующего интерфейс " + nameof(ISelectFile));


            string? fileName = null;
            switch (vers)
            {
                case EnumСertificateVersion.ver1:
                    fileName = saveClass.SelectFileForSave("Свидетельство о поверке (вер.1)");
                    if (String.IsNullOrEmpty(fileName)) return;
                    break;
                case EnumСertificateVersion.ver2:
                    fileName = saveClass.SelectFileForSave("Свидетельство о поверке (вер.2)");
                    if (String.IsNullOrEmpty(fileName)) return;
                    break;
                default:
                    throw new ArgumentException("Необрабатываемое (неизвестное) значение " + nameof(EnumСertificateVersion) + ": " + vers);
                    //break;
            }

            try
            {
                СertificateDTO dto = new СertificateDTO() { Сertificate = cr, Ver = vers };
                dto.FileName = fileName;
                MainDoc.CreateСertificate(dto);
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
