using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Вывод информации о СИ
    /// </summary>
    internal class FormManualShowInfoAboutMI
    {
        /// <summary>
        /// Вывод информации о СИ в RichTextBox
        /// </summary>
        /// <param name="box"></param>
        /// <param name="mi"></param>
        internal static void ShowInfo(RichTextBox box, MeasuringInstrument mi)
        {
            box.Clear();
            box.Text += "Наименованиеие прибора:" + mi.DeviceName + Environment.NewLine;
            ShowDeviceStateInfo(box, mi.DeviceState);
            box.Text += "Дата поступления прибора в эксплуатацию:" + mi.UseDate + Environment.NewLine;
            box.Text += "Заводской номер:" + mi.ManufacturerNumber + Environment.NewLine;
            box.Text += "Инвентарный номер:" + mi.InventoryNumber + Environment.NewLine;
            ShowDepartmentInfo(box, mi.Department);
            ShowCalibrationPeriodInfo(box, mi.CalibrationPeriod);
            ShowDeviceTypeInfo(box, mi.DeviceType);

            box.Text += "Пределы измерения:" + mi.WorkRange + Environment.NewLine;
            ShowMeasurementUnitInfo(box,mi.MeasurementUnit);
            box.Text += "Цена деления шкалы:" + mi.ScaleStep + Environment.NewLine;
            box.Text += "Класс или допускаемая погрешность:" + mi.Error + Environment.NewLine;
            box.Text += "Перечень основных частей комплекта:" + mi.MainPartsList + Environment.NewLine;

            ShowManufacturerInfo(box, mi.Manufacturer);
        }

        /// <summary>
        /// Вывод информации о Местоположение
        /// </summary>
        /// <param name="dp"></param>
        static void ShowDepartmentInfo(RichTextBox box, Department? dp)
        {
            if (dp == null)
            {
                box.Text += "Нет информации о местоположение. " + Environment.NewLine;
            }
            else
            {
                box.Text += "Местоположение: " + dp.Name + Environment.NewLine;
                box.Text += "Номер подразделения: " + dp.SubdevisionNumber + Environment.NewLine;
            }
        }

        /// <summary>
        /// Вывод информации о периодичности калибровки прибора.
        /// </summary>
        /// <param name="cp"></param>
        static void ShowCalibrationPeriodInfo(RichTextBox box, CalibrationPeriod? cp)
        {
            if (cp == null)
            {
                box.Text += "Нет информации о периодичности калибровки прибора. " + Environment.NewLine;
            }
            else
            {
                box.Text += "Период калибровки: " + cp.Period + Environment.NewLine;
            }
        }

        /// <summary>
        /// Вывод информации о Типе СИ
        /// </summary>
        /// <param name="dt"></param>
        static void ShowDeviceTypeInfo(RichTextBox box, DeviceType? dt)
        {
            if (dt == null)
            {
                box.Text += "Нет информации о типе СИ. " + Environment.NewLine;
            }
            else
            {
                box.Text += "Название типа СИ: " + dt.TypeName + Environment.NewLine;
            }
        }

        /// <summary>
        /// Вывод информации о единице измерения
        /// </summary>
        /// <param name="mu"></param>
        static void ShowMeasurementUnitInfo(RichTextBox box, MeasurementUnit? mu)
        {
            if (mu == null)
            {
                box.Text += "Нет информации о единице измерения. " + Environment.NewLine;
            }
            else
            {
                box.Text += "единицы измерения: " + mu.Value + Environment.NewLine;
            }
        }

        /// <summary>
        /// Вывод информации о производителе
        /// </summary>
        /// <param name="mf"></param>
        static void ShowManufacturerInfo(RichTextBox box, Manufacturer? mf)
        {
            if (mf == null)
            {
                box.Text += "Нет информации о производителе. " + Environment.NewLine;
            }
            else
            {
                box.Text += "Производитель: " + mf.Name + Environment.NewLine;
                box.Text += "Страна: " + mf.Country + Environment.NewLine;
                box.Text += "Город: " + mf.City + Environment.NewLine;
                box.Text += "Адрес:" + mf.Address + Environment.NewLine;
                box.Text += "Адрес страницы в интернете:" + mf.UrlAddress + Environment.NewLine;

                box.Text += "e-mail:" + mf.EMail + Environment.NewLine;
                box.Text += "Описание:" + mf.Description + Environment.NewLine;
            }
        }

        /// <summary>
        /// Вывод информации о Текущем состояние прибора
        /// </summary>
        /// <param name="ds"></param>
        static void ShowDeviceStateInfo(RichTextBox box, DeviceState? ds)
        {
            if (ds == null)
            {
                box.Text += "Нет информации о текущем состояние прибора. " + Environment.NewLine;
            }
            else
            {
                box.Text += "Текущее состояние прибора: " + ds.State + Environment.NewLine;
            }
        }
    }
}
