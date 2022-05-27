using CommonClassLibrary;
using ConteinerLibrary;
using DbClassLibrary;
using Microsoft.EntityFrameworkCore;
using ViewInterfaces;

namespace Presenters
{
    /// <summary>
    /// Presenter для История поверок/калибровок
    /// </summary>
    public class CalibrationPresenter : BasePresenter<Calibration>
    {
        MeasuringInstrument _measuringInstrument;

        public CalibrationPresenter(IDbBaseView<Calibration> view,
                                    DbContextOptions dbOption,
                                    MeasuringInstrument measuringInstrument)
            : base(view, dbOption)
        {
            _measuringInstrument = measuringInstrument;
        }

        public override void Run()
        {
            var view = _view as ICalibrationView;
            if (view is null) throw new FormatException("View должен быть " + nameof(ICalibrationView));
            view.ShowHead(_measuringInstrument);

            //base.Run();
            RefreshAllDatas(this, EventArgs.Empty);
            _view.ShowView();
        }

        public override async void RefreshAllDatas(object? sender, EventArgs args)
        {
            try
            {
                var db = new MyDbContext(_dbOption);
                db.Attach(_measuringInstrument); //прикрепили СИ, т.к. сдесь новый контекст БД
                if (selectedObject != null) db.Set<Calibration>().Attach(selectedObject);
                _repositiry = db;

                //todo сделать свой метод чтения из БД с условием
                var list = await _repositiry.ReadFromDbAsync<Calibration>();
                _view.PrintData(list.Where(x => x.MeasuringInstrumentId == _measuringInstrument.Id).ToList(), selectedObject);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public override void AddNew(object? sender, EventArgs args)
        {
            ICalibrationAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<ICalibrationAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(ICalibrationAddOrEditView));

            var addOrEditPresenter = new CalibrationAddOrEditPresenter(view, _repositiry, EnumOperation.AddNew, null, _measuringInstrument);
            selectedObject = addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);
        }


        public override void EditRecordInDB(object? sender, Calibration data)
        {

            //IDbBaseViewForAddOrEdit<T> _viewForAddOrEdit =
            //Conteiner.GetInstance().GetAddOrEditViewInstance<T>();

            ICalibrationAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<ICalibrationAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IRepairAddOrEditView));

            //var addOrEditPresenter = new BasePresenterForAddOrEdit<T>
            //    (_viewForAddOrEdit, _repositiry, EnumOperation.Edit, data);

            var addOrEditPresenter = new CalibrationAddOrEditPresenter(view, _repositiry, EnumOperation.Edit, data, _measuringInstrument);
            selectedObject = addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);

            //RefreshAllDatas(this, EventArgs.Empty);
            //_repositiry.EditRecord(data);
        }
    }
}
