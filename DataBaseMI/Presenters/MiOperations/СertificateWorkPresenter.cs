using CommonClassLibrary;
using ConteinerLibrary;
using DbClassLibrary;
using Microsoft.EntityFrameworkCore;
using ViewInterfaces;

namespace Presenters
{
    /// <summary>
    /// Presenter для Свидетельство о поверке
    /// </summary>
    public class СertificateWorkPresenter : BasePresenter<Сertificate>
    {
        MeasuringInstrument _measuringInstrument;
        public СertificateWorkPresenter(IDbBaseView<Сertificate> view,
                                    DbContextOptions dbOption,
                                    MeasuringInstrument measuringInstrument) :
            base(view, dbOption)
        {
            _measuringInstrument = measuringInstrument;
        }

        public override void Run()
        {
            var view = _view as IСertificateWorkView;
            if (view is null) throw new FormatException("View должен быть " + nameof(IСertificateWorkView));
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
                if (selectedObject != null) db.Set<Сertificate>().Attach(selectedObject);
                _repositiry = db;

                //todo сделать свой метод чтения из БД с условием
                var list = await _repositiry.ReadFromDbAsync<Сertificate>();
                _view.PrintData(list.Where(x => x.MeasuringInstrumentId == _measuringInstrument.Id).ToList(), selectedObject);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public override void AddNew(object? sender, EventArgs args)
        {

            IСertificateWorkAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<IСertificateWorkAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IСertificateWorkAddOrEditView));

            var addOrEditPresenter = new СertificateWorkAddOrEditPresenter(view, _repositiry, EnumOperation.AddNew, null, _measuringInstrument);
            selectedObject = addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);
        }


        public override void EditRecordInDB(object? sender, Сertificate data)
        {
            //IDbBaseViewForAddOrEdit<T> _viewForAddOrEdit =
            //Conteiner.GetInstance().GetAddOrEditViewInstance<T>();

            IСertificateWorkAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<IСertificateWorkAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IСertificateWorkAddOrEditView));

            //var addOrEditPresenter = new BasePresenterForAddOrEdit<T>
            //    (_viewForAddOrEdit, _repositiry, EnumOperation.Edit, data);

            var addOrEditPresenter = new СertificateWorkAddOrEditPresenter(view, _repositiry, EnumOperation.Edit, data, _measuringInstrument);
            selectedObject = addOrEditPresenter.Run();
            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);

            //RefreshAllDatas(this, EventArgs.Empty);

            //_repositiry.EditRecord(data);

        }
    }
}
