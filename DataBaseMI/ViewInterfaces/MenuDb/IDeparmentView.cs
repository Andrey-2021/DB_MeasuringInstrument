using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейис окна, в котором выводится информация о местоположении/подразделении СИ
    /// </summary>
    public interface IDeparmentView:IView, IDbBaseView<Department>
    {
    }
}
