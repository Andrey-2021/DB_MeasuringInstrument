using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbClassLibrary
{
    /// <summary>
    /// Класс, который предоставляет данные для создания Отчёта и Сводки
    /// </summary>
    public class GetDatesForReport
    {
        /// <summary>
        /// получаем список СИ, поверка которых ЗАПЛАНИРОВАНА на выбранный период
        /// </summary>
        /// <param name="_dbOption"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static List<ReportRecord> GetCalibrationPlan(DbContextOptions _dbOption, DateTime beginDate, DateTime endDate)
        {
            using (var db = new MyDbContext(_dbOption))
            {
                var plan = (from mi in db.MeasuringInstruments
                            join depatment in db.Departments on mi.DepartmentId equals depatment.Id
                            join calibration in db.Calibrations on mi.Id equals calibration.MeasuringInstrumentId
                            where (calibration.NextCalibrationDate >= beginDate
                                    && calibration.NextCalibrationDate <= endDate)

                            select new ReportRecord
                            {
                                MIDeviceName = mi.DeviceName + " (инв.№: " + mi.InventoryNumber + ")",
                                DepartmentSubdevisionNumber = depatment.SubdevisionNumber,
                                NextCalibrationDate = calibration.NextCalibrationDate
                            }).ToList();
                return plan;
            }
        }

        /// <summary>
        /// получаем список СИ поверка которых ФАКТИЧЕСКИ выполнена в выбранный период
        /// </summary>
        /// <param name="_dbOption"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static List<ReportRecord> GetCalibrationInFact(DbContextOptions _dbOption, DateTime beginDate, DateTime endDate)
        {
            using (var db = new MyDbContext(_dbOption))
            {
                var plan = (from mi in db.MeasuringInstruments
                            join depatment in db.Departments on mi.DepartmentId equals depatment.Id
                            join calibration in db.Calibrations on mi.Id equals calibration.MeasuringInstrumentId
                            where (calibration.Date >= beginDate
                                    && calibration.Date <= endDate)

                            select new ReportRecord
                            {
                                MIDeviceName = mi.DeviceName + " (инв.№: " + mi.InventoryNumber + ")",
                                DepartmentSubdevisionNumber = depatment.SubdevisionNumber,
                                CalibrationDate = calibration.Date
                            }).ToList();
                return plan;
            }
        }

        /// <summary>
        /// получаем список СИ РЕМОНТ которых ФАКТИЧЕСКИ выполнен в выбранный период
        /// </summary>
        /// <param name="_dbOption"></param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static List<ReportRecord> GetrRepairInFact(DbContextOptions _dbOption, DateTime beginDate, DateTime endDate)
        {
            using (var db = new MyDbContext(_dbOption))
            {
                var plan = (from mi in db.MeasuringInstruments
                            join depatment in db.Departments on mi.DepartmentId equals depatment.Id
                            join repair in db.Repairs on mi.Id equals repair.MeasuringInstrumentId
                            where (repair.Date >= beginDate
                                    && repair.Date <= endDate)

                            select new ReportRecord
                            {
                                MIDeviceName = mi.DeviceName + " (инв.№: " + mi.InventoryNumber + ")",
                                DepartmentSubdevisionNumber = depatment.SubdevisionNumber,
                                RepairDate = repair.Date
                            }).ToList();
                return plan;
            }
        }

        public static List<ReportRecord> GetTable(DbContextOptions _dbOption, DateTime beginDate, DateTime endDate)
        {
            using (var db = new MyDbContext(_dbOption))
            {
                var plan = (from mi in db.MeasuringInstruments
                            join depatment in db.Departments on mi.DepartmentId equals depatment.Id
                            join calibration in db.Calibrations on mi.Id equals calibration.MeasuringInstrumentId
                            where (calibration.NextCalibrationDate >= beginDate
                                    && calibration.NextCalibrationDate <= endDate)
                                    ||
                                    (calibration.Date >= beginDate
                                    && calibration.Date <= endDate)
                            join repair in db.Repairs on mi.Id equals repair.MeasuringInstrumentId
                            where (repair.Date >= beginDate 
                                    && repair.Date <= endDate)
                            //        && repair.Date <= endDate)
                            //where (calibration.NextCalibrationDate >= beginDate
                            //        && calibration.NextCalibrationDate <= endDate)
                            //        ||
                            //        (calibration.Date >= beginDate
                            //        && calibration.Date <= endDate)
                            //        ||
                            //        (repair.Date >= beginDate
                            //        && repair.Date <= endDate)

                            select new ReportRecord
                            {
                                MIDeviceName = mi.DeviceName + " (инв.№: " + mi.InventoryNumber + ")",
                                DepartmentSubdevisionNumber = depatment.SubdevisionNumber,

                                CalibrationDate = calibration.Date,
                                NextCalibrationDate = calibration.NextCalibrationDate,
                                RepairDate = repair.Date
                            }).ToList();
                return plan;
            }
        }
    }
}
