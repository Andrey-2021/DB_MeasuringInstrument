using CommonClassLibrary.DTO;
using System.Text;
using ViewInterfaces.Documents;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting.Documents
{
    /// <summary>
    /// Окно "Сводка", для выбора варианта создаваемой сводки по СИ
    /// </summary>
    public partial class FormSummaries : BaseViewShowErrorAndWarning, ISummariesView
    {
        public event EventHandler<ReportDatesDTO>? SavingReportInDocxFile;
        public FormSummaries()
        {
            InitializeComponent();
            PrintData();
            radioButton1year.Select();
        }

        public void PrintData()
        {
            numericUpDown1Year.Minimum = 1950;
            numericUpDown1Year.Maximum = 2100;
            numericUpDown1Year.Value = DateTime.Now.Year;

            comboBox2Quarter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2Quarter.DataSource = new int[] { 1, 2, 3, 4 };
            if (comboBox2Quarter.Items.Count > 0) comboBox2Quarter.SelectedIndex = 0;
        }

        public void PrintInfo(StringBuilder text)
        {
            textBox1.Text = text.ToString();
        }

        private void radioButton1year_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2Quarter.Enabled = false;
        }

        private void radioButton2quarter_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2Quarter.Enabled = true;
        }
        private void button1SaveVer1_Click(object sender, EventArgs e)
        {
            CreateSummaries();
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            //закрыть
            this.Close();
        }


        /// <summary>
        /// Создать сводку
        /// </summary>
        /// <param name="recipies"></param>
        void CreateSummaries()
        {
            if (SavingReportInDocxFile == null)
            {
                throw new NullReferenceException("Нет обработчика для того, чтобы создать сводку по СИ в .docx файл");
            }

            ReportDatesDTO reportDTO = new();
            reportDTO.year = (int)numericUpDown1Year.Value;

            if (radioButton1year.Checked)
            {
                reportDTO.reportType = ReportTypeEnum.yearReport;
                SavingReportInDocxFile?.Invoke(this, reportDTO);
                return;
            }

            if (radioButton2quarter.Checked)
            {
                reportDTO.reportType = ReportTypeEnum.quarterReport;
                reportDTO.quarter = (int)comboBox2Quarter.SelectedItem;
                SavingReportInDocxFile?.Invoke(this, reportDTO);
                return;
            }
        }
    }
}
