using CommonClassLibrary;
using System.ComponentModel;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting.Documents
{
    [DesignTimeVisible(false)]
    [DesignerCategory("Form")]
    public class BaseFormFindMI : BaseViewForDbForms
    {
        public event EventHandler<FindMeasuringInstrumentDTO>? RefreshingAllMeasuringInstruments;

        /// <summary>
        /// Вызов исключения, сообщающего о том, что необходимо обновить данные о СИ из БД
        /// </summary>
        public void OnRefreshAll(object sender,
            TextBox textBox1DeviceName,
            TextBox textBox2ManufacturerNumber,
            TextBox textBox3InventoryNumber)
        {
            if (RefreshingAllMeasuringInstruments != null)
            {
                FindMeasuringInstrumentDTO dto = new FindMeasuringInstrumentDTO()
                {
                    DeviceName = textBox1DeviceName.Text,
                    ManufacturerNumber = textBox2ManufacturerNumber.Text,
                    InventoryNumber = textBox3InventoryNumber.Text
                };

                RefreshingAllMeasuringInstruments(sender, dto);
            }
            else
            {
                throw new NullReferenceException("Нет обработчика поиска информации");
                //ShowError("В программе нет возможности обновить данные из БД!");
            }
        }
    }
}
