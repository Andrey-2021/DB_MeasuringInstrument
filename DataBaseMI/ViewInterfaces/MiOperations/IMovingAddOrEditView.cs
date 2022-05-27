using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;

namespace ViewInterfaces
{
    public interface IMovingAddOrEditView : IView, IDbBaseViewForAddOrEdit<Moving>
    {
        //public void PrintData(Moving? data, string message, List<Calibrator>? calibrator);
        public void PrintData(Moving? data, string message,
            List<User>? users,
            List<Department>? departments);
    }
}
