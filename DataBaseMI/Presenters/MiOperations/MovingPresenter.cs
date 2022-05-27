using CommonClassLibrary;
using ConteinerLibrary;
using DbClassLibrary;
using Microsoft.EntityFrameworkCore;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces;

namespace Presenters
{
    /// <summary>
    /// Presenter для Перемещение СИ
    /// </summary>
    public class MovingPresenter : BasePresenter<Moving>
    {
        MeasuringInstrument _measuringInstrument;

        public MovingPresenter(IDbBaseView<Moving> view,
                                    DbContextOptions dbOption,
                                    MeasuringInstrument measuringInstrument) :
            base(view, dbOption)
        {
            _measuringInstrument = measuringInstrument;
        }

        public override void Run()
        {
            var view = _view as IMIMovingView;
            if (view is null) throw new FormatException("View должен быть " + nameof(IMIMovingView));
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
                if (selectedObject != null) db.Set<Moving>().Attach(selectedObject);
                _repositiry = db;

                //todo сделать свой метод чтения из БД с условием
                var list = await _repositiry.ReadFromDbAsync<Moving>();
                _view.PrintData(list.Where(x => x.MeasuringInstrumentId == _measuringInstrument.Id).ToList());
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }

        public override void AddNew(object? sender, EventArgs args)
        {
            IMovingAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<IMovingAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IMovingAddOrEditView));

            var addOrEditPresenter = new MovingAddOrEditPresenter(view, _repositiry, EnumOperation.AddNew, null, _measuringInstrument);
            selectedObject = addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);
        }


        public override void EditRecordInDB(object sender, Moving data)
        {
            
            //IDbBaseViewForAddOrEdit<T> _viewForAddOrEdit =
            //Conteiner.GetInstance().GetAddOrEditViewInstance<T>();

            IMovingAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<IMovingAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IMovingAddOrEditView));

            //var addOrEditPresenter = new BasePresenterForAddOrEdit<T>
            //    (_viewForAddOrEdit, _repositiry, EnumOperation.Edit, data);

            var addOrEditPresenter = new MovingAddOrEditPresenter(view, _repositiry, EnumOperation.Edit, data, _measuringInstrument);
            selectedObject = addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);

            //RefreshAllDatas(this, EventArgs.Empty);
            //_repositiry.EditRecord(data);
        }
    }
}
