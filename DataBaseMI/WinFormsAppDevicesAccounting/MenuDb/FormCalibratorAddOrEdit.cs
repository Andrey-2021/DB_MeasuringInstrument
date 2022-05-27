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
    public partial class FormCalibratorAddOrEdit
        :BaseViewShowErrorAndWarning, ICalibratorAddOrEditView
    {
        Calibrator _data = null!;
        public event EventHandler<Calibrator>? SavingNewData;

        public FormCalibratorAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;
        }


        public void PrintData(Calibrator? data, string message, List<Department>? departments)
        {
            label3Topic.Text = message;

            if (data == null)
            {
                throw new NullReferenceException("Для вывода на экран нет данных");
            }

            _data = data;
            textBox1Surname.Text = _data.Surname;
            textBox2Name.Text = _data.Name;
            textBox3MiddleName.Text = _data.MiddleName;
            
            //todo добавить - что делать если нет списка Department


            comboBox1Department.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1Department.DisplayMember = nameof(Department.Name);// "Name";
            comboBox1Department.ValueMember = nameof(Department.Id); // "Id";
            comboBox1Department.DataSource = departments;
            if (comboBox1Department.Items.Count > 0) comboBox1Department.SelectedIndex = 0;

            //todo !!! добавить выбор нужного Department при редактировании данных!!!
            //сделать двы столбца в comboBox
            int n = comboBox1Department.Items.IndexOf(data.Department);
            if (n >= 0) comboBox1Department.SelectedIndex = n; ;

            //todo Доделать
            //comboBox1Department
        }




        void OnSaveNewData()
        {
            _data.Surname = textBox1Surname.Text;
            _data.Name = textBox2Name.Text;
            _data.MiddleName = textBox3MiddleName.Text;

            Object selectedItem = comboBox1Department.SelectedItem;
            Department? dp = selectedItem as Department;
            _data.Department = dp;
            if (dp != null) _data.DepartmentId = dp.Id;

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
