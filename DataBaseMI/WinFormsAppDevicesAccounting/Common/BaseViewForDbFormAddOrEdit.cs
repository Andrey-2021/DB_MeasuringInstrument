using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting.Common
{
    [DesignTimeVisible(false)]
    [DesignerCategory("Form")]
    public class BaseViewForDbFormAddOrEdit : BaseViewShowErrorAndWarning
    {
/*
        public void OnAdding(object sender, EventHandler? Adding)
        {
            if (Adding != null)
            {
                Adding(sender, EventArgs.Empty);
            }
            else
            {
                ShowError("В программе нет возможности добавить новые данные в БД!");
            }
        }

            

        void OnSaveNewData(object sender, EventHandler? SavingNewData)
        {
            _data.Period = textBox1Period.Text;
            SaveNewData?.Invoke(this, _data);
        }
*/
    }
}
