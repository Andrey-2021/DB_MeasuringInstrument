
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;
using CommonClassLibrary;

namespace ViewInterfaces
{
    public interface IDeviceTypeAddOrEditView : IView, IDbBaseViewForAddOrEdit<DeviceType>
    {
    }
}
