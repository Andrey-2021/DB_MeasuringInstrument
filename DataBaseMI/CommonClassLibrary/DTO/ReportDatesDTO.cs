using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClassLibrary.DTO
{
    public enum ReportTypeEnum
    {
        yearReport,
        quarterReport,
        monthReport,
        weekReport
    }

    public class ReportDatesDTO
    {
        public int year;
        public int quarter;
        public int month;
        public DateTime monday; //понедельник
        public DateTime sunday; //воскресение
        public ReportTypeEnum reportType;
    }

}
