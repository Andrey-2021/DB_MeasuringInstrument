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
using CommonClassLibrary;

namespace WinFormsAppDevicesAccounting.Documents
{
    public partial class FormMovement : BaseFormFindMI, IMovementView
    {
        public event EventHandler<Moving>? SavingMovingInDocxFile;
        public event EventHandler<MeasuringInstrument>? FindingMovment;


        public FormMovement()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView2MovingDocuments);
            IntitDatGridView(dataGridView1MI);

            this.FormClosing += ExecuteFormClosingEvent;
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            //закрыть
            this.Close();
        }

        private void button1SaveVer1_Click(object sender, EventArgs e)
        {
            OnSavingMovingInDocxFile(EnumPasportVersion.ver1);
        }

        private void button10Refresh_Click(object sender, EventArgs e)
        {
            //найти
            OnRefreshAll(this, textBox1DeviceName, textBox2ManufacturerNumber, textBox3InventoryNumber);
        }


        public void PrintData(List<MeasuringInstrument> list, MeasuringInstrument? entity = null)
        {
            //-- richTextBox1Info.Clear();
            dataGridView1MI.DataSource = list;
            // SelectRowInDataGrid<MeasuringInstrument>(dataGridView1Data, entity);

            if (list == null || list.Count == 0)
            {
                //--   richTextBox1Info.Text = "Нет данных";
            }

            if (list != null)
            {
                //делаем все столбцы невидимыми
                for (int i = 0; i < dataGridView1MI.Columns.Count; i++)
                    dataGridView1MI.Columns[i].Visible = false;

                //показать столбцы
                dataGridView1MI.Columns[nameof(MeasuringInstrument.Id)].Visible = true;
                dataGridView1MI.Columns[nameof(MeasuringInstrument.DeviceName)].Visible = true;
                dataGridView1MI.Columns[nameof(MeasuringInstrument.ManufacturerNumber)].Visible = true;
                dataGridView1MI.Columns[nameof(MeasuringInstrument.InventoryNumber)].Visible = true;
            }
        }



        public void PrintMovmentData(List<Moving> list)
        {
            //-- richTextBox1Info.Clear();
            dataGridView2MovingDocuments.DataSource = list;
            // SelectRowInDataGrid<MeasuringInstrument>(dataGridView1Data, entity);

            if (list == null || list.Count == 0)
            {
                //--   richTextBox1Info.Text = "Нет данных";
            }
            /*
            if (list != null)
            {
                //делаем все столбцы невидимыми
                for (int i = 0; i < dataGridView2MovingDocuments.Columns.Count; i++)
                    dataGridView2MovingDocuments.Columns[i].Visible = false;

                //показать столбцы
                dataGridView2MovingDocuments.Columns[nameof(Moving.Id)].Visible = true;
                dataGridView2MovingDocuments.Columns[nameof(Moving.Date)].Visible = true;
                dataGridView2MovingDocuments.Columns[nameof(Moving.WhatSeeInsteadGiveDepartment)].Visible = true;
                dataGridView2MovingDocuments.Columns[nameof(Moving.WhatSeeInsteadTakeDepartment)].Visible = true;
                
            }*/
        }



        /// <summary>
        /// Сохранить накладную на перемещение в файл
        /// </summary>
        /// <param name="recipies"></param>
        void OnSavingMovingInDocxFile(EnumPasportVersion ver)
        {
            var data = GetDataFromSelectedRow<Moving>(dataGridView2MovingDocuments);

            if (data != null)
            {
                if (SavingMovingInDocxFile== null)
                {
                    throw new NullReferenceException("Нет обработчика для того, чтобы создать накладную на перемещение для СИ в .docx файл");
                    //MessageBox.Show("В программе нет возможности сохранять паспорт!");
                    //return;
                }
                SavingMovingInDocxFile?.Invoke(this, data);
            }
        }


        //Событие, выбрана строка в таблице, содержащей данные о СИ
        private void dataGridView1MI_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1MI.SelectedRows.Count > 0)
            {
                MeasuringInstrument? data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1MI);
                if (data != null)
                {
                    FindingMovment?.Invoke(this, data);
                }
            }
        }


    }
}
