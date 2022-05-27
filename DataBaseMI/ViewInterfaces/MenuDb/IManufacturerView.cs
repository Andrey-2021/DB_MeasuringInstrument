using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс окна, в котором выводится информация о заводе изготовителе
    /// </summary>
    public interface IManufacturerView : IView, IDbBaseView<Manufacturer>
    {
    }
}
