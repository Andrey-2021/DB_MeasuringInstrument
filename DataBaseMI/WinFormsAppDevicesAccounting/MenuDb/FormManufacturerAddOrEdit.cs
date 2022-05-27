using CommonClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewInterfaces;

namespace WinFormsAppDevicesAccounting.Windows
{
    public partial class FormManufacturerAddOrEdit :
        BaseViewShowErrorAndWarning, IManufacturerAddOrEditView
    {
        Manufacturer _data = null!;

        public event EventHandler<Manufacturer>? SavingNewData;

        public FormManufacturerAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }


        public void PrintData(Manufacturer? data, string message)
        {
            label3Topic.Text = message;

            if (data == null)
                throw new NullReferenceException("Для вывода на экран нет данных");

            _data = data;
            textBox1Name.Text = _data.Name;
            textBox2Country.Text = _data.Country;
            textBox3City.Text = _data.City;
            textBox4Address.Text = _data.Address;
            textBox5UrlAddress.Text = _data.UrlAddress;
            textBox6EMail.Text = _data.EMail;
            textBox7Description.Text = _data.Description;
        }

        void OnSaveNewData()
        {
            _data.Name = textBox1Name.Text;
             _data.Country= textBox2Country.Text;
             _data.City= textBox3City.Text;
            _data.Address= textBox4Address.Text;
             _data.UrlAddress= textBox5UrlAddress.Text;
            _data.EMail= textBox6EMail.Text;
            _data.Description= textBox7Description.Text;

            SavingNewData?.Invoke(this, _data);
        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            OnSaveNewData();
        }

        private void button2Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
