using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;

namespace ViewInterfaces
{
    public interface IDepartmentAddOrEditView: IView, IDbBaseViewForAddOrEdit<Department> 
    {
    }
}
