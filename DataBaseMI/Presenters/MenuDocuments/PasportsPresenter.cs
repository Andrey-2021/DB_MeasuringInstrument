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
    /// Presenter для составления документа "Паспорт СИ"
    /// </summary>
    internal class PasportsPresenter : IPresenter
    {
        IPasportsView _view;
        protected IRepository _repositiry;

        /// <summary>
        /// Конструктор
        /// </summary>
        public PasportsPresenter(IPasportsView view, IRepository repositiry)
        {
            _view = view;
            _repositiry = repositiry;

            _view.RefreshingAllMeasuringInstruments += RefreshAllDatas;
            _view.ClosingMyWindow += CloseViewWindow;
            _view.SavingPasportInDocxFile += SavePasport;
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
        /// Создать паспорт СИ
        /// </summary>
        public async void SavePasport(MeasuringInstrument mi, EnumPasportVersion vers)
        {
            string? fileName = null;

            var saveClass = Conteiner.GetInstance().GetClassInstance<ISelectFile>();
            if (saveClass == null) throw new NullReferenceException("Нет класса , реализующего интерфейс " + nameof(ISelectFile));

            try
            {
                var list = await _repositiry.ReadFromDbAsync<Repair>();
                List<Repair>? repairs = list.Where(x => x.MeasuringInstrumentId == mi.Id).ToList();
                var calibration = await _repositiry.ReadFromDbAsync<Calibration>();
                //_view.PrintData(list.Where(x => x.MeasuringInstrumentId == _measuringInstrument.Id).ToList(), selectedObject);

                PasportDTO dto = new PasportDTO() { MI = mi, Ver = vers, Repairs = repairs };
                
                switch (vers)
                {
                    case EnumPasportVersion.ver1:
                        fileName = saveClass.SelectFileForSave("Паспорт на СИ (вер.1)");
                        if (String.IsNullOrEmpty(fileName)) return;
                        break;
                    case EnumPasportVersion.ver2:
                        fileName = saveClass.SelectFileForSave("Паспорт на СИ (вер.2)");
                        if (String.IsNullOrEmpty(fileName)) return;
                        break;
                    default:
                        throw new ArgumentException("Необрабатываемое (неизвестное) значение " + nameof(EnumPasportVersion) + ": " + vers);
                        //break;
                }
                dto.FileName = fileName;
                MainDoc.CreatePasport(dto);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
                return;
            }
            RunWordDocInWindows.RunDoc(fileName,_view );
        }

        /// <summary>
        /// Закрыть окно
        /// </summary>
        public void CloseViewWindow(object sender, EventArgs args)
        {
            _view.CloseView();
        }
    }
}
