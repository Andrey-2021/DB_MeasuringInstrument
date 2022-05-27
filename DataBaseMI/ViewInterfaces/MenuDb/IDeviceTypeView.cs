using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс окна, в котором выводится информация о типе СИ
    /// </summary>
    public interface IDeviceTypeView : IView, IDbBaseView<DeviceType>
    {
    }
}
