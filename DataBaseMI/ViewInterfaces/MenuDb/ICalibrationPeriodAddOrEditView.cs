using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;

namespace ViewInterfaces
{
    /// <summary>
 /// Интерфейс окна, в котором редактируются данные выбранного поверителя или вводятся данные о новом поверителе
 /// </summary>
    public interface ICalibrationPeriodAddOrEditView : IView, IDbBaseViewForAddOrEdit<CalibrationPeriod>
    {
    }
}
