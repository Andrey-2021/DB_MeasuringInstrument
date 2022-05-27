using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;

namespace ViewInterfaces
{
    public interface ICalibrationAddOrEditView : IView, IDbBaseViewForAddOrEdit<Calibration>
    {
        public void PrintData(Calibration? data, string message, List<Calibrator>? calibrator);
    }
}
