using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewInterfaces.Common;
using CommonClassLibrary;

namespace ViewInterfaces
{
    public interface IMeasuringInstrumentAddOrEditView : IView, IDbBaseViewForAddOrEdit<MeasuringInstrument>
    {
        /// <summary>
        /// Выбор картинки с изображением СИ
        /// </summary>
        public event EventHandler SelectingPicture;

        /// <summary>
        /// Показать данные на форме (экране)
        /// </summary>
        /// <param name="data">Исходный объект</param>
        /// <param name="message">Вводим сообщение</param>
        /// <param name="departments">Список, содержащий возможные местоположения СИ</param>
        /// <param name="calibrationPeriod">Спосок, содержит возможные значения для периодичности калибровки</param>
        /// <param name="manufacturer"></param>
        /// <param name="deviceType"></param>
        /// <param name="measurementUnit"></param>
        /// <param name="deviceState"></param>
        public void PrintData(MeasuringInstrument? data, string message,
            List<Department>? departments,
            List<CalibrationPeriod>? calibrationPeriod,
            List<Manufacturer>? manufacturer,
            List<DeviceType>? deviceType,
            List<MeasurementUnit>? measurementUnit,
            List<DeviceState>? deviceState
            );

        /// <summary>
        /// Выбрана картинка для СИ 
        /// </summary>
        /// <param name="photo">Объект, содержащий картинку</param>
        public void TakePhoto(Photo photo);
    }
}
