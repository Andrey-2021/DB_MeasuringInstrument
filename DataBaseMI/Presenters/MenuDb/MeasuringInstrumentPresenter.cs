using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces;
using CommonInterface;
using RepositoryInterfaces;
using CommonClassLibrary;
using ConteinerLibrary;
using Microsoft.EntityFrameworkCore;
using DbClassLibrary;

namespace Presenters
{
    internal class MeasuringInstrumentPresenter : BasePresenter<MeasuringInstrument>
    {
        IMeasuringInstrumentView _view;
       // IRepository _repositiry;
       // DbContextOptions _dbOption;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MeasuringInstrumentPresenter(IMeasuringInstrumentView view, DbContextOptions? dbOption)
            :base(view, dbOption)
        {
            _view = view;

            //_repositiry = repositiry;
            _dbOption = dbOption;

            _view.Calibrating += Calibrating;
            _view.Repairing += Repairing;
            _view.Moving += Moving;
            _view.Certificating += Certificating;
            _view.Unsuitable += Unsuitable;
            
            _view.RefreshingAllFilteringMI += RefreshAllDatas;

        }
        
         public override void Run()
        {

            //RefreshAllDatas(this, EventArgs.Empty);
            RefreshAllDatas(this, null);
            _view.ShowView();
            _repositiry?.Dispose();
        }

        public async void RefreshAllDatas(object? sender, FilterMiDTO? data)
        {
            try
            {
                var db = new MyDbContext(_dbOption);
                //db.Attach(_measuringInstrument); //прикрепили СИ, т.к. сдесь новый контекст БД
                if (selectedObject != null) db.Set<MeasuringInstrument>().Attach(selectedObject);
                _repositiry = db;



                List<MeasuringInstrument>? list = null;

                if (data == null) list = await _repositiry.ReadFromDbAsync<MeasuringInstrument>();
                else
                {
                    var calibrations = _repositiry.ReadFromDbAsync<Calibration>();
                    await calibrations;

                    list = _repositiry.ReadFromDb<MeasuringInstrument>(data.Predicate);
                }
                

                var departments = _repositiry.ReadFromDbAsync<Department>();
                await departments;
                var deviceType = _repositiry.ReadFromDbAsync<DeviceType>();
                await deviceType;
                var deviceState = _repositiry.ReadFromDbAsync<DeviceState>();
                await deviceState;

                //_view.PrintData(list);
                _view.PrintData(list, departments.Result, deviceType.Result, deviceState.Result, selectedObject);
            }
            catch (Exception ex)
            {
                _view.ShowError(ex.Message);
            }
        }



        public override void AddNew(object? sender, EventArgs args)
        {
            IMeasuringInstrumentAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<IMeasuringInstrumentAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IMeasuringInstrumentAddOrEditView));

            var addOrEditPresenter = new MeasuringInstrumentAddOrEditPresenter(view, _repositiry, EnumOperation.AddNew, null);
            selectedObject = addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, null);
            //RefreshAllDatas(this, EventArgs.Empty);
        }


        public override void EditRecordInDB(object? sender, MeasuringInstrument data)
        {
            IMeasuringInstrumentAddOrEditView? view = Conteiner.GetInstance().GetFormInstance<IMeasuringInstrumentAddOrEditView>();
            if (view is null) throw new NullReferenceException("Нет View с интерфейсом: " + nameof(IMeasuringInstrumentAddOrEditView));

            var addOrEditPresenter = new MeasuringInstrumentAddOrEditPresenter(view, _repositiry, EnumOperation.Edit, data);
            selectedObject = addOrEditPresenter.Run();

            if (_repositiry.IsDbAvailable) RefreshAllDatas(this, null);
        }











        public void Calibrating(object? sender, MeasuringInstrument data)
        {
            var view = Conteiner.GetInstance().GetFormInstance<ICalibrationView>();
            if (view == null)throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(ICalibrationView));
            CalibrationPresenter calibrationPresenter = new CalibrationPresenter(view, _dbOption, data);
            calibrationPresenter.Run();
        }

        public void Repairing(object? sender, MeasuringInstrument data)
        {
            var view = Conteiner.GetInstance().GetFormInstance<IRepairView>();
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IRepairView));
            RepairPresenter repairPresenter = new RepairPresenter(view, _dbOption, data);
            repairPresenter.Run();
        }


        /// <summary>
        /// Перемещение СИ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        /// <exception cref="NullReferenceException"></exception>
        public void Moving(object? sender, MeasuringInstrument data)
        {
            var view = Conteiner.GetInstance().GetFormInstance<IMIMovingView>();
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IMIMovingView));
            MovingPresenter movingPresenter = new MovingPresenter(view, _dbOption, data);
            movingPresenter.Run();
        }


        public void Certificating(object? sender, MeasuringInstrument data)
        {
            var view = Conteiner.GetInstance().GetFormInstance<IСertificateWorkView>();
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IСertificateWorkView));
            СertificateWorkPresenter presenter = new СertificateWorkPresenter(view, _dbOption, data);
            presenter.Run();
        }

        public void Unsuitable(object? sender, MeasuringInstrument data)
        {
            var view = Conteiner.GetInstance().GetFormInstance<IUnsuitabilityWorkView>();
            if (view == null) throw new NullReferenceException("Отсутствует зарегистрированная форма для" + nameof(IUnsuitabilityWorkView));
            UnsuitabilityWorkPresenter presenter = new UnsuitabilityWorkPresenter(view, _dbOption, data);
            presenter.Run();
        }


    }
}
