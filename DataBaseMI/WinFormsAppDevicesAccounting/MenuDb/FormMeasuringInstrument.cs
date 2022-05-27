using CommonClassLibrary;
using ViewInterfaces;


namespace WinFormsAppDevicesAccounting.Windows
{
    /// <summary>
    /// Окно, в котором выводится информация о средствах измерения (СИ)
    /// </summary>
    public partial class FormMeasuringInstrument : BaseViewForDbForms, IMeasuringInstrumentView
    {

        public event EventHandler<FilterMiDTO?>? RefreshingAllFilteringMI;

        public event EventHandler? RefreshAll;
        public event EventHandler? Adding;
        public event EventHandler<MeasuringInstrument>? Deleting;
        public event EventHandler<MeasuringInstrument>? Editing;
        public event EventHandler<MeasuringInstrument>? Calibrating;
        public event EventHandler<MeasuringInstrument>? Repairing;
        public event EventHandler<MeasuringInstrument>? Moving;
        public event EventHandler<MeasuringInstrument>? Certificating;
        public event EventHandler<MeasuringInstrument>? Unsuitable;

        //MeasuringInstrument _data = null!;

        public FormMeasuringInstrument()
        {
            InitializeComponent();
            IntitDatGridView(dataGridView1Data);
            this.FormClosing += ExecuteFormClosingEvent;

            numericUpDown1Year.Minimum = 1900;
            numericUpDown1Year.Maximum = 2150;
            numericUpDown1Year.Value = DateTime.Now.Year;
            checkBox2Year.Checked = false;
            checkBox2Year_CheckedChanged(this, EventArgs.Empty);

            comboBox3Month.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3Month.DataSource = FilterMiDTO.GetMonths();
            if (comboBox3Month.Items.Count > 0) comboBox3Month.SelectedIndex = 0;

        }


        //public void PrintData(List<MeasuringInstrument> list)
        //{
        //    dataGridView1Data.DataSource = list;
        //}

        public void PrintData(List<MeasuringInstrument> list, MeasuringInstrument? entity = null)
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<MeasuringInstrument>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();
        }


        public void PrintData(List<MeasuringInstrument> list,
            List<Department>? departments,
            List<DeviceType>? deviceType,
            List<DeviceState>? deviceState,
            MeasuringInstrument? entity = null
            )
        {
            dataGridView1Data.DataSource = list;
            if (entity != null) SelectRowInDataGrid<MeasuringInstrument>(dataGridView1Data, entity);
            label3RecordNumber.Text = list.Count.ToString();

            FormMeasuringInstrumentAddOrEdit.ShowDepartments(comboBox1Department, null, departments);
            FormMeasuringInstrumentAddOrEdit.ShowDeviceType(comboBox4DeviceType, null, deviceType);
            FormMeasuringInstrumentAddOrEdit.ShowDeviceState(comboBox6DeviceState, null, deviceState);
            comboBox1Department.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox4DeviceType.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox6DeviceState.DropDownStyle = ComboBoxStyle.DropDown;

            comboBox1Department.SelectedIndex = -1;
            comboBox4DeviceType.SelectedIndex = -1;
            comboBox6DeviceState.SelectedIndex = -1;
        }






        private void button2AddNew_Click(object sender, EventArgs e)
        {
            OnAdding(this, Adding);
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1Data);

            if (data != null) OnEditing<MeasuringInstrument>(this, Editing, data);
        }

        private void button4Del_Click(object sender, EventArgs e)
        {
            var data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1Data);

            if (data != null) OnDeleting<MeasuringInstrument>(this, Deleting, data);
        }

        private void button5Refresh_Click(object sender, EventArgs e)
        {
            ClearFilterFields();
            OnRefreshingAllFilteringMI(this, null);
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6Calibration_Click(object sender, EventArgs e)
        { //калибровка
            var data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1Data);
            if (data != null) OnCalibration(data);
        }

        private void button7Repair_Click(object sender, EventArgs e)
        {   //ремонт
            var data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1Data);
            if (data != null) OnRepair(data);
        }

        private void button8Moving_Click(object sender, EventArgs e)
        {
            //перемещение СИ
            var data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1Data);
            if (data != null) OnMoving(data);
        }


        /// <summary>
        /// Вызов исключения, сообщающего о том, что необходимо откалибровать прибор
        /// </summary>
        public void OnCalibration(MeasuringInstrument data)
        {
            if (Calibrating != null)
            {
                Calibrating(this, data);
            }
            else
            { //todo поменять на Exception
                ShowError("В программе нет возможности откалибровать прибор!");
            }
        }


        /// <summary>
        /// Вызов исключения, сообщающего о том, что необходимо отремонтировать прибор
        /// </summary>
        public void OnRepair(MeasuringInstrument data)
        {
            if (Repairing != null)
            {
                Repairing(this, data);
            }
            else
            { //todo поменять на Exception
                ShowError("В программе нет возможности отремонтировать прибор!");
            }
        }


        /// <summary>
        /// Вызов исключения, сообщающего о том, что необходимо переместить СИ
        /// </summary>
        public void OnMoving(MeasuringInstrument data)
        {
            if (Moving != null)
            {
                Moving(this, data);
            }
            else
            { //todo поменять на Exception
                ShowError("В программе нет возможности переместить прибор!");
            }
        }

        private void button9Unsuitability_Click(object sender, EventArgs e)
        {//Извещение о непригодности
            OnUnsuitability();
        }

        private void button10Certificate_Click(object sender, EventArgs e)
        {//Свидетельство о поверке
            OnCertificate();
        }


        /// <summary>
        /// Вызов исключения, сообщающего о том, что необходимо работать с "Извещениями о непригодности к применению
        /// </summary>
        public void OnUnsuitability()
        {
            var data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1Data);
            if (data != null)
            {
                if (Unsuitable != null)
                {
                    Unsuitable(this, data);
                }
                else
                { //todo поменять на Exception
                    ShowError("В программе нет возможности работать с извещениями о непригодности к применению!");
                }
            }
        }

        /// <summary>
        /// Вызов исключения, сообщающего о том, что необходимо работать со "Свидетельствами о поверке"
        /// </summary>
        public void OnCertificate()
        {
            var data = GetDataFromSelectedRow<MeasuringInstrument>(dataGridView1Data);
            if (data != null)
            {

                if (Certificating != null)
                {
                    Certificating(this, data);
                }
                else
                { //todo поменять на Exception
                    ShowError("В программе нет возможности работать со свидетельствами о поверке!");
                }
            }
        }

        private void button9Clear_Click(object sender, EventArgs e)
        {
            ClearFilterFields();
        }

        /// <summary>
        /// Очистка полей фильтрации
        /// </summary>
        void ClearFilterFields()
        {
            textBox1DeviceName.Clear();
            textBox2ManufacturerNumber.Clear();
            textBox3InventoryNumber.Clear();

            comboBox4DeviceType.SelectedIndex = -1;
            comboBox6DeviceState.SelectedIndex = -1;
            comboBox1Department.SelectedIndex = -1;

            dateTimePicker1Now.Checked = false;
            dateTimePicker2Next.Checked = false;
            checkBox2Year.Checked = false;
            checkBox3Month.Checked = false;
        }

        private void button10Refresh_Click(object sender, EventArgs e)
        {
            //найти
            CreateFilterDTO();
        }




        public void CreateFilterDTO()
        {
            FilterMiDTO dto = new FilterMiDTO()
            {
                DeviceName = textBox1DeviceName.Text,
                ManufacturerNumber = textBox2ManufacturerNumber.Text,
                InventoryNumber = textBox3InventoryNumber.Text,

                DeviceType = comboBox4DeviceType.SelectedItem as DeviceType,
                //DeviceTypeId = DeviceType.Id,

                DeviceState = comboBox6DeviceState.SelectedItem as DeviceState,
                //DeviceStateId = DeviceState?.Id,

                Department = comboBox1Department.SelectedItem as Department
                //DepartmentId = Department?.Id
            };

            dto.DeviceTypeId = dto.DeviceType?.Id;
            dto.DeviceStateId = dto.DeviceState?.Id;
            dto.DepartmentId = dto.Department?.Id;


            if (dateTimePicker1Now.Checked)
                dto.Date = dateTimePicker1Now.Value;
            else dto.Date = null;

            if (dateTimePicker2Next.Checked)
                dto.NextCalibrationDate = dateTimePicker2Next.Value;
            else dto.NextCalibrationDate = null;

            if (checkBox2Year.Checked)
            {
                dto.Year = (uint)numericUpDown1Year.Value;
                if (checkBox3Month.Checked) dto.Month = comboBox3Month.SelectedItem as string;
                else dto.Month = null;
            }
            else
            {
                dto.Year = null;
                dto.Month = null;
            }

            OnRefreshingAllFilteringMI(this, dto);
        }

        void OnRefreshingAllFilteringMI(Object sender, FilterMiDTO? dto)
        {
            RefreshingAllFilteringMI?.Invoke(sender, dto);
        }

        private void checkBox2Year_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2Year.Checked)
            {
                numericUpDown1Year.Enabled = true;
                checkBox3Month.Enabled = true;
                checkBox3Month.Checked = false;
                //comboBox3Month.Enabled = true;

            }
            else
            {
                numericUpDown1Year.Enabled = false;
                checkBox3Month.Enabled = false;
                checkBox3Month.Checked = false;
                //comboBox3Month.Enabled = false;
            }
        }

        private void checkBox3Month_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3Month.Checked)
                comboBox3Month.Enabled = true;
            else comboBox3Month.Enabled = false;
        }
    }
}
