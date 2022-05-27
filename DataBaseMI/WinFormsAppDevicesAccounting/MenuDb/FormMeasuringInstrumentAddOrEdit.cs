using CommonClassLibrary;
using ViewInterfaces;

namespace WinFormsAppDevicesAccounting.Windows
{

    /// <summary>
    /// Окно для ввода данных нового СИ или редактирования старых данных у выбранного СИ
    /// </summary>
    public partial class FormMeasuringInstrumentAddOrEdit : BaseViewShowErrorAndWarning, IMeasuringInstrumentAddOrEditView
    {
        MeasuringInstrument _data = null!;
        public event EventHandler<MeasuringInstrument>? SavingNewData;
        public event EventHandler? SelectingPicture;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormMeasuringInstrumentAddOrEdit()
        {
            InitializeComponent();
            this.FormClosing += ExecuteFormClosingEvent;

            dateTimePicker1UseDate.MinDate = new DateTime(1900, 01, 01); //минимальная дата, которую можно выбрать
            dateTimePicker1UseDate.MaxDate = DateTime.Today.AddDays(1); //наибольшая дата, которую можно выбрать
        }

        public void PrintData(MeasuringInstrument? data, string message,
            List<Department>? departments,
            List<CalibrationPeriod>? calibrationPeriod,
            List<Manufacturer>? manufacturer,
            List<DeviceType>? deviceType,
            List<MeasurementUnit>? measurementUnit,
            List<DeviceState>? deviceState)
        {
            label3Topic.Text = message;

            if (data == null)
                throw new NullReferenceException("Для вывода на экран нет данных");

            _data = data;
            textBox1Name.Text = _data.DeviceName;
            textBox2Country.Text = _data.ManufacturerNumber;
            textBox3City.Text = _data.InventoryNumber;
            textBox4Address.Text = _data.WorkRange;
            textBox5UrlAddress.Text = _data.ScaleStep;
            textBox6EMail.Text = _data.Error;
            textBox7Description.Text = _data.MainPartsList;

            ShowDepartments(comboBox1Department, _data, departments);
            ShowCalibrationPeriod(comboBox2CalibrationPeriod, _data, calibrationPeriod);
            ShowManufacturer(comboBox3Manufacturer, _data, manufacturer);
            ShowDeviceType(comboBox4DeviceType, _data, deviceType);
            ShowMeasurementUnit(comboBox5MeasurementUnit, _data, measurementUnit);
            ShowDeviceState(comboBox6DeviceState, _data, deviceState);

            dateTimePicker1UseDate.Value = _data.UseDate;
            pictureBox1.Image = _data.Photo?.Image;
        }


        public static void ShowDepartments(ComboBox comboBox, MeasuringInstrument? mi, List<Department>? departments)
        {
            //todo добавить - что делать если нет списка Department
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DisplayMember = nameof(Department.Name);// "Name";
            comboBox.ValueMember = nameof(Department.Id); // "Id";
            comboBox.DataSource = departments;
            if (comboBox.Items.Count > 0) comboBox.SelectedIndex = 0;

            //todo !!! сделать двы столбца в comboBox

            if (mi != null)
            {
                int n = comboBox.Items.IndexOf(mi.Department);
                if (n >= 0) comboBox.SelectedIndex = n; ;
            }
        }


        void ShowCalibrationPeriod(ComboBox comboBox, MeasuringInstrument mi, List<CalibrationPeriod>? calibrationPeriod)
        {
            //todo добавить - что делать если нет списка CalibrationPeriod
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DisplayMember = nameof(CalibrationPeriod.Period);
            comboBox.ValueMember = nameof(CalibrationPeriod.Id);
            comboBox.DataSource = calibrationPeriod;
            if (comboBox.Items.Count > 0) comboBox.SelectedIndex = 0;

            int n = comboBox.Items.IndexOf(mi.CalibrationPeriod);
            if (n >= 0) comboBox.SelectedIndex = n; ;

        }


        void ShowManufacturer(ComboBox comboBox, MeasuringInstrument mi, List<Manufacturer>? manufacturer)
        {
            //todo добавить - что делать если нет списка CalibrationPeriod
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DisplayMember = nameof(Manufacturer.Name);
            comboBox.ValueMember = nameof(Manufacturer.Id);
            comboBox.DataSource = manufacturer;
            if (comboBox.Items.Count > 0) comboBox.SelectedIndex = 0;

            int n = comboBox.Items.IndexOf(mi.Manufacturer);
            if (n >= 0) comboBox.SelectedIndex = n; ;
        }


        public static void ShowDeviceType(ComboBox comboBox, MeasuringInstrument? mi, List<DeviceType>? deviceType)
        {
            //todo добавить - что делать если нет списка CalibrationPeriod
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DisplayMember = nameof(DeviceType.TypeName);
            comboBox.ValueMember = nameof(DeviceType.Id);
            comboBox.DataSource = deviceType;
            if (comboBox.Items.Count > 0) comboBox.SelectedIndex = 0;

            if (mi != null)
            {
                int n = comboBox.Items.IndexOf(mi.DeviceType);
                if (n >= 0) comboBox.SelectedIndex = n; ;
            }
        }


        void ShowMeasurementUnit(ComboBox comboBox, MeasuringInstrument mi, List<MeasurementUnit>? measurementUnit)
        {
            //todo добавить - что делать если нет списка CalibrationPeriod
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DisplayMember = nameof(MeasurementUnit.Value);
            comboBox.ValueMember = nameof(MeasurementUnit.Id);
            comboBox.DataSource = measurementUnit;
            if (comboBox.Items.Count > 0) comboBox.SelectedIndex = 0;

            int n = comboBox.Items.IndexOf(mi.MeasurementUnit);
            if (n >= 0) comboBox.SelectedIndex = n; ;
        }

        public static void ShowDeviceState(ComboBox comboBox, MeasuringInstrument? mi, List<DeviceState>? deviceState)
        {
            //todo добавить - что делать если нет списка CalibrationPeriod
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DisplayMember = nameof(DeviceState.State);
            comboBox.ValueMember = nameof(DeviceState.Id);
            comboBox.DataSource = deviceState;
            if (comboBox.Items.Count > 0) comboBox.SelectedIndex = 0;

            if (mi != null)
            {
                int n = comboBox.Items.IndexOf(mi.DeviceState);
                if (n >= 0) comboBox.SelectedIndex = n; ;
            }
        }


        void OnSaveNewData()
        {
            _data.DeviceName = textBox1Name.Text;
            _data.ManufacturerNumber = textBox2Country.Text;
            _data.InventoryNumber = textBox3City.Text;
            _data.WorkRange = textBox4Address.Text;
            _data.ScaleStep = textBox5UrlAddress.Text;
            _data.Error = textBox6EMail.Text;
            _data.MainPartsList = textBox7Description.Text;

            _data.Department = comboBox1Department.SelectedItem as Department;
            _data.DepartmentId = _data.Department?.Id;
            _data.CalibrationPeriod = comboBox2CalibrationPeriod.SelectedItem as CalibrationPeriod;
            _data.CalibrationPeriodId = _data.CalibrationPeriod?.Id;
            _data.Manufacturer = comboBox3Manufacturer.SelectedItem as Manufacturer;
            _data.ManufacturerID = _data.Manufacturer?.Id;
            _data.DeviceType = comboBox4DeviceType.SelectedItem as DeviceType;
            _data.DeviceTypeId = _data.DeviceType?.Id;
            _data.MeasurementUnit = comboBox5MeasurementUnit.SelectedItem as MeasurementUnit;
            _data.MeasurementUnitId = _data.MeasurementUnit?.Id;
            _data.DeviceState = comboBox6DeviceState.SelectedItem as DeviceState;
            _data.DeviceStateId = _data.DeviceState?.Id;
            _data.UseDate = dateTimePicker1UseDate.Value;
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

        private void button1_Click(object sender, EventArgs e)
        {
            OnSelectPicture();
        }


        void OnSelectPicture()
        {
            SelectingPicture?.Invoke(this, EventArgs.Empty);
        }

        public void TakePhoto(Photo photo)
        {
            Image image = photo.Image;
            if (image != null)
            {
                pictureBox1.Image = image; //Выводим картинку на экран
                _data.Photo = photo;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
