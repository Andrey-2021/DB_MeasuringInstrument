using CommonClassLibrary;
using ConteinerLibrary;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces;
using Microsoft.EntityFrameworkCore;
using DbClassLibrary;

namespace Presenters
{
    /// <summary>
    /// Presenter для Произведённый ремонт
    /// </summary>
    public class RepairPresenter : BasePresenter<Repair>
    {
        MeasuringInstrument _measuringInstrument;

        public RepairPresenter(IDbBaseView<Repair> view,
                                    DbContextOptions dbOption,
                                    MeasuringInstrument measuringInstrument) 
            :base(view, dbOption)
        {
            _measuringInstrument = measuringInstrument;
        }


        public override void Run()
        {
            var view = _view as IRepairView;
            if (view is null) throw new FormatException("View должен быть " + nameof(IRepairView));
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
                if (selectedObject != null) db.Set<Repair>().Attach(selectedObject);
                _repositiry = db;

                //todo сделать свой метод чтения из БД с условием
                var list = await _repositiry.ReadFromDbAsync<Repair>();
                _view.PrintData(list.Where(x => x.MeasuringInstrumentId == _measuringInstrument.Id).ToList(), selectedObject);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }



        public override void AddNew(object? sender, EventArgs args)
        {
            IRepairAddOrEditView? view =Conteiner.GetInstance().GetFormInstance<IRepairAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IRepairAddOrEditView));

            var addOrEditPresenter = new RapairAddOrEditPresenter(view, _repositiry, EnumOperation.AddNew, null, _measuringInstrument);

            selectedObject=addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);
            //RefreshAllDatas(this, EventArgs.Empty);
        }


        public override void EditRecordInDB(object? sender, Repair data)
        {

                //IDbBaseViewForAddOrEdit<T> _viewForAddOrEdit =
                //Conteiner.GetInstance().GetAddOrEditViewInstance<T>();
            
            IRepairAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<IRepairAddOrEditView>();

            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IRepairAddOrEditView));
            //var addOrEditPresenter = new BasePresenterForAddOrEdit<T>
            //    (_viewForAddOrEdit, _repositiry, EnumOperation.Edit, data);

            var addOrEditPresenter = new RapairAddOrEditPresenter(view, _repositiry, EnumOperation.Edit, data, _measuringInstrument);
            selectedObject = addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, EventArgs.Empty);

            //RefreshAllDatas(this, EventArgs.Empty);

            //_repositiry.EditRecord(data);
        }

    }
}
