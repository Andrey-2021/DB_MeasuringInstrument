using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс окна, в котором выводится информация о текущем состоянии СИ
    /// </summary>
    public interface IDeviceStateView : IView, IDbBaseView<DeviceState>
    {
    }
}
