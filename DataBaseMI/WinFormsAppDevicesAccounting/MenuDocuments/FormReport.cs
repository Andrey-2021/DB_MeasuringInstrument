using CommonClassLibrary.DTO;
using System.Text;
using ViewInterfaces.Documents;
using WinFormsAppDevicesAccounting.Windows;

namespace WinFormsAppDevicesAccounting
{
    /// <summary>
    /// Окно "Отчёт", в котором выбирается вид создаваемого отчёта по СИ
    /// </summary>
    public partial class FormReport : BaseViewShowErrorAndWarning, IReportsView
    {
        public event EventHandler<ReportDatesDTO>? SavingReportInDocxFile;

        public FormReport()
        {
            InitializeComponent();
            radioButton3month.Select();
            monthCalendar1.SelectionStart = DateTime.Now;
        }

        public void PrintInfo(StringBuilder text)
        {
            textBox1.Text = text.ToString();
        }


        private void radioButton3month_CheckedChanged(object sender, EventArgs e)
        {
            label5week.Visible = false;
            textBox6Week.Visible = false;
        }

        private void radioButton4week_CheckedChanged(object sender, EventArgs e)
        {
            label5week.Visible = true;
            textBox6Week.Visible = true;
            ChangeDate();
        }

        private void button1SaveVer1_Click(object sender, EventArgs e)
        {
            CreateReport();
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            //закрыть
            this.Close();
        }

        /// <summary>
        /// Создать отчёт
        /// </summary>
        /// <param name="recipies"></param>
        void CreateReport()
        {
            if (SavingReportInDocxFile == null)
            {
                throw new NullReferenceException("Нет обработчика для того, чтобы создать отчёт по СИ в .docx файл");
            }

            ReportDatesDTO reportDTO = new();
            reportDTO.year = selectedDate.Year;

            if (radioButton3month.Checked)
            {
                reportDTO.reportType = ReportTypeEnum.monthReport;
                reportDTO.month = selectedDate.Month;// (string)comboBox3Month.SelectedItem;
                SavingReportInDocxFile?.Invoke(this, reportDTO);
                return;
            }

            if (radioButton4week.Checked)
            {
                reportDTO.reportType = ReportTypeEnum.weekReport;
                reportDTO.monday = monday;
                reportDTO.sunday = sunday;
                SavingReportInDocxFile?.Invoke(this, reportDTO);
                return;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ChangeDate();
        }
        
        private void ChangeDate()
        {
            var date = monthCalendar1.SelectionStart;
            selectedDate = date;

            if (radioButton4week.Checked)
            {
                var dayofweek = (int)date.DayOfWeek;

                if (dayofweek == 0) //если кликнули воскресение (номер 0)
                {
                    sunday = date;
                    monday = date.AddDays(-6);
                }
                else //если другие дни
                {
                    monday = date.AddDays(-(dayofweek - 1));
                    sunday = date.AddDays(7 - dayofweek);
                }

                var array = new System.DateTime[7];
                for (int i = 0; i < 7; i++)
                    array[i] = monday.AddDays(i);

                this.monthCalendar1.BoldedDates = array;
            }
            else
            {
                this.monthCalendar1.BoldedDates = null;
            }

            ShowInfo(date);
        }





        DateTime selectedDate=DateTime.Now;
        DateTime monday; //понедельник
        DateTime sunday; //воскресение

        private void ShowInfo(DateTime date)
        {
            //selectedDate = date;
            textBox4Year.Text = selectedDate.Year.ToString();
            textBox5Month.Text = selectedDate.ToString("MMMM");

            if (radioButton4week.Checked)
            {
                textBox6Week.Text = "c: " + monday.Day + " по: " + sunday.Day;
            }
        }
    }
}
