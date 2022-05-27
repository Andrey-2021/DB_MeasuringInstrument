using CommonClassLibrary;

namespace ViewInterfaces
{
    /// <summary>
    /// Интерфейс окна, в котором выводится информация о произведённом ремонте СИ
    /// </summary>
    public interface IRepairView : IView, IDbBaseView<Repair>
    {
        /// <summary>
        /// Показать шапку формы, содержащую информацию о СИ
        /// </summary>
        /// <param name="measuringInstrument">СИ, о котором выводим информацию</param>
        public void ShowHead(MeasuringInstrument measuringInstrument);
    }
}
