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
using ViewInterfaces.Documents;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting.Documents
{
    public partial class FormPasports : BaseFormFindMI, IPasportsView
    {
       public event Action<MeasuringInstrument, EnumPasportVersion>? SavingPasportInDocxFile;

        public FormPasports()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;
        }


        public void PrintData(List<MeasuringInstrument> list, MeasuringInstrument? entity = null)
        {
           //-- richTextBox1Info.Clear();
            dataGridView1Data.DataSource = list;
            // SelectRowInDataGrid<MeasuringInstrument>(dataGridView1Data, entity);

            if (list == null || list.Count == 0)
            {
             //--   richTextBox1Info.Text = "Нет данных";
            }

            if (list != null)
            {
                //делаем все столбцы невидимыми
                for (int i = 0; i < dataGridView1Data.Columns.Count; i++)
                    dataGridView1Data.Columns[i].Visible = false;

                //показать столбцы
                dataGridView1Data.Columns[nameof(MeasuringInstrument.Id)].Visible = true;
                dataGridView1Data.Columns[nameof(MeasuringInstrument.DeviceName)].Visible = true;
                dataGridView1Data.Columns[nameof(MeasuringInstrument.ManufacturerNumber)].Visible = true;
                dataGridView1Data.Columns[nameof(MeasuringInstrument.InventoryNumber)].Visible = true;
            }
        }



        private void button1Exit_Click(object sender, EventArgs e)
        {
            //закрыть
            this.Close();
        }

        private void button10Refresh_Click(object sender, EventArgs e)
        {
            //найти
            OnRefreshAll(this, textBox1DeviceName, textBox2ManufacturerNumber,textBox3InventoryNumber);
        }

        private void button1SaveVer1_Click(object sender, EventArgs e)
        {
            OnSavingPasportInDocxFile(EnumPasportVersion.ver1);
        }
        private void button2SaveVer2_Click(object sender, EventArgs e)
        {
            OnSavingPasportInDocxFile(EnumPasportVersion.ver2);
        }



        /// <summary>
        /// Сохранить паспорт в файл
        /// </summary>
        /// <param name="recipies"></param>
        void OnSavingPasportInDocxFile(EnumPasportVersion ver)
        {
            var data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1Data);

            if (data != null)
            {
                if (SavingPasportInDocxFile == null)
                {
                    throw new NullReferenceException("Нет обработчика для того, чтобы сохранить паспорт СИ в .docx файл");
                    //MessageBox.Show("В программе нет возможности сохранять паспорт!");
                    //return;
                }
                SavingPasportInDocxFile?.Invoke(data, ver);
            }
        }

        private void button9Clear_Click(object sender, EventArgs e)
        {
            ClearFindFields();
        }

        /// <summary>
        /// Очистка полей поиска
        /// </summary>
        void ClearFindFields()
        {
            textBox1DeviceName.Clear();
            textBox2ManufacturerNumber.Clear();
            textBox3InventoryNumber.Clear();
        }

    }
}
