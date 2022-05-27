using CommonClassLibrary;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;

namespace Presenters
{
    public class RapairAddOrEditPresenter: BasePresenterForAddOrEdit<Repair>
    {
        MeasuringInstrument _measuringInstrument;
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="view">Форма пользовательского интерфейса</param>
        /// <param name="repositiry">Контекст БД</param>
        /// <param name="operation">Выполняемая опрерация: добавление новых данных или редактирование старых</param>
        /// <param name="data">Редактируемые данные</param>
        /// <param name="measuringInstrument">СИ, информацию о ремонте которого добавляем/редактируем</param>
        public RapairAddOrEditPresenter
           ( IDbBaseViewForAddOrEdit<Repair> view,
            IRepository repositiry,
            EnumOperation operation,
            Repair? data,
            MeasuringInstrument measuringInstrument): base(view,repositiry,operation,data)
            {
            _measuringInstrument = measuringInstrument;
            }


        protected override string ConfigeAddOrEdit()
        {
            string message;

            if (_operation == EnumOperation.Edit)
            {
                message = "Редактирование данных";

                //todo убрать if, он тут лишний.И тогда Избавиться от Предупреждения
                if (_data != null) objectСlone = (Repair)_data.Clone();
            }
            else
            {
                message = "Ввод новых данных";
                _data = new Repair(); //(T?)Activator.CreateInstance(typeof(T));
                _data.MeasuringInstrumentId = _measuringInstrument.Id;
                _data.MeasuringInstrument = _measuringInstrument;
                //_data.Date = DateTime.Now;
            }
            return message;
        }

    }
}
