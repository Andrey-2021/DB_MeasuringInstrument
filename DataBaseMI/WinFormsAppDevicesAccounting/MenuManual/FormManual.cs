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
    /// <summary>
    /// Окно, в котором выводится справочная информация о СИ
    /// </summary>
    public partial class FormManual : BaseViewForDbForms, IManualView
    {
        public event EventHandler<FindMeasuringInstrumentDTO>? RefreshingAllMeasuringInstruments;
    
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormManual()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;
        }

        public void PrintData(List<MeasuringInstrument> list, MeasuringInstrument? entity = null)
        {
            richTextBox1Info.Clear();
            dataGridView1Data.DataSource = list;
            // SelectRowInDataGrid<MeasuringInstrument>(dataGridView1Data, entity);
            
            if (list==null || list.Count==0)
            {
                richTextBox1Info.Text = "Нет данных";
            }
            
            if (list!=null)
            {
                //делаем все столбцы невидимыми
                for (int i = 0; i < dataGridView1Data.Columns.Count; i++)
                    dataGridView1Data.Columns[i].Visible = false;
                
                //показать столбцы
                dataGridView1Data.Columns[nameof(MeasuringInstrument.DeviceName)].Visible = true;
                dataGridView1Data.Columns[nameof(MeasuringInstrument.ManufacturerNumber)].Visible = true;
                dataGridView1Data.Columns[nameof(MeasuringInstrument.InventoryNumber)].Visible = true;
            }
        }

        /// <summary>
        /// Вызов исключения, сообщающего о том, что необходимо обновить данные о СИ из БД
        /// </summary>
        public void OnRefreshAll()
        {
            if (RefreshingAllMeasuringInstruments != null)
            {
                FindMeasuringInstrumentDTO dto = new FindMeasuringInstrumentDTO()
                {
                    DeviceName = textBox1DeviceName.Text,
                    ManufacturerNumber = textBox2ManufacturerNumber.Text,
                    InventoryNumber = textBox3InventoryNumber.Text
                };

                RefreshingAllMeasuringInstruments(this, dto);
            }
            else
            {
                throw new NullReferenceException("Нет обработчика поиска информации");
                //ShowError("В программе нет возможности обновить данные из БД!");
            }
        }

        private void button5Find_Click(object sender, EventArgs e)
        {
            OnRefreshAll();
        }
        
        private void button1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Событие, выбрана строка в таблице
        private void dataGridView1Data_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1Data.SelectedRows.Count>0)
            {
                MeasuringInstrument? data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1Data);
                if (data != null)
                {
                    pictureBox1Photo.Image = data.Photo?.Image;
                    FormManualShowInfoAboutMI.ShowInfo(richTextBox1Info, data);
                }
            }
        }
    }
}
