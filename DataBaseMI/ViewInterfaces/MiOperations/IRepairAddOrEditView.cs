using CommonClassLibrary;
using ViewInterfaces.Common;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс окно, в котором редактируются данные о выбранном произведённом ремонте или вводятся новые данные о произведённом ремонте СИ
    /// </summary>
    public interface IRepairAddOrEditView : IView, IDbBaseViewForAddOrEdit<Repair>
    {
    }
}
