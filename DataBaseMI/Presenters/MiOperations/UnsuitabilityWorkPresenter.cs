using CommonClassLibrary;
using ConteinerLibrary;
using DbClassLibrary;
using Microsoft.EntityFrameworkCore;
using ViewInterfaces;

namespace Presenters
{
    /// <summary>
    /// Presentor для Извещения о непригодности к применению
    /// </summary>
    public class UnsuitabilityWorkPresenter : BasePresenter<Unsuitability>
    {
        MeasuringInstrument _measuringInstrument;
        public UnsuitabilityWorkPresenter(IDbBaseView<Unsuitability> view,
                                    DbContextOptions dbOption,
                                    MeasuringInstrument measuringInstrument) :
            base(view, dbOption)
        {
            _measuringInstrument = measuringInstrument;
        }

        public override void Run()
        {
            var view = _view as IUnsuitabilityWorkView;
            if (view is null) throw new FormatException("View должен быть " + nameof(IUnsuitabilityWorkView));
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
                if (selectedObject != null) db.Set<Unsuitability>().Attach(selectedObject);
                _repositiry = db;

                //todo сделать свой метод чтения из БД с условием
                var list = await _repositiry.ReadFromDbAsync<Unsuitability>();
                _view.PrintData(list.Where(x => x.MeasuringInstrumentId == _measuringInstrument.Id).ToList(), selectedObject);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public override void AddNew(object? sender, EventArgs args)
        {
            IUnsuitabilityWorkAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<IUnsuitabilityWorkAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IUnsuitabilityWorkAddOrEditView));

            var addOrEditPresenter = new UnsuitabilityWorkAddOrEditPresenter(view, _repositiry, EnumOperation.AddNew, null, _measuringInstrument);
            selectedObject = addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);
        }


        public override void EditRecordInDB(object? sender, Unsuitability data)
        {
            //IDbBaseViewForAddOrEdit<T> _viewForAddOrEdit =
            //Conteiner.GetInstance().GetAddOrEditViewInstance<T>();

            IUnsuitabilityWorkAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<IUnsuitabilityWorkAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IUnsuitabilityWorkAddOrEditView));

            //var addOrEditPresenter = new BasePresenterForAddOrEdit<T>
            //    (_viewForAddOrEdit, _repositiry, EnumOperation.Edit, data);

            var addOrEditPresenter = new UnsuitabilityWorkAddOrEditPresenter(view, _repositiry, EnumOperation.Edit, data, _measuringInstrument);
            selectedObject = addOrEditPresenter.Run();
            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);

            //RefreshAllDatas(this, EventArgs.Empty);
            //_repositiry.EditRecord(data);
        }
    }
}
