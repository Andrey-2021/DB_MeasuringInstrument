using CommonClassLibrary;
using Microsoft.EntityFrameworkCore;

namespace DbClassLibrary
{
    public class SaveInitializationDataInDB
    {
        public static void SaveData(DbContextOptions<MyDbContext> options)
        {
            //using (MyDbContext db = new MyDbContext(options))
            //{
            //    db.CreateNewDB();
            //}

            using (MyDbContext db = new MyDbContext(options))
            {
                CalibrationPeriod period1 = new CalibrationPeriod { Period = "1 раз в год" };
                CalibrationPeriod period2 = new CalibrationPeriod { Period = "1 раз в 2 года" };
                CalibrationPeriod period3 = new CalibrationPeriod { Period = "1 раз в 3 года" };
                CalibrationPeriod period4 = new CalibrationPeriod { Period = "1 раз в 4 года" };
                CalibrationPeriod period5 = new CalibrationPeriod { Period = "1 раз в 5 лет" };
                db.CalibrationPeriods.AddRangeAsync(period1, period2, period3,period4,period5);
                db.SaveChanges();


                DeviceType type1 = new DeviceType { TypeName = "Генератор" };
                DeviceType type2 = new DeviceType { TypeName = "Частотомер" };
                DeviceType type3 = new DeviceType { TypeName = "Ваттметр" };
                DeviceType type4 = new DeviceType { TypeName = "Анализатор" };
                db.DeviceTypes.AddRangeAsync(type1, type2, type3, type4);
                db.SaveChanges();


                Manufacturer manufacturer1 = new Manufacturer 
                { Name = "ОАО «Электроприбор»", 
                    Country = "Россия",
                City="Чебоксары",
                Address= "проспект И.Я. Яковлева, дом 3",
                EMail= "op@elpribor.ru",
                UrlAddress= "www.elpribor.ru",
                };
                
                Manufacturer manufacturer2 = new Manufacturer 
                { Name = "Минский научно-исследовательский приборостроительный институт (МНИПИ)",
                    Country = "Беларусь",
                    City="Минск",
                    Address= "ул. Я. Коласа, 73",
                    EMail= "mnipi@mnipi.by",
                    UrlAddress= "http://mnipi.com/",
                    Description= "ОАО  'МНИПИ'"
                };
                Manufacturer manufacturer3 = new Manufacturer 
                { Name = "MCP lab electronics", 
                    Country = "Китай",
                City="Shanghai",
                UrlAddress="mcp-sh.com",
                EMail= "jason@mcpsh.com"
                };
                db.Manufacturers.AddRangeAsync(manufacturer1, manufacturer2, manufacturer3);
                db.SaveChanges();




                MeasurementUnit unit1 = new MeasurementUnit { Value = "Ватт/ДБ" };
                MeasurementUnit unit2 = new MeasurementUnit { Value = "Ватт" };
                MeasurementUnit unit3 = new MeasurementUnit { Value = "Гц" };
                MeasurementUnit unit4 = new MeasurementUnit { Value = "Ом" };
                MeasurementUnit unit5 = new MeasurementUnit { Value = "А" };

                db.MeasurementUnits.AddRangeAsync(unit1, unit2, unit3, unit4, unit5);
                db.SaveChanges();


                DeviceState deviceState1 = new DeviceState { State = "Годен" };
                DeviceState deviceState2 = new DeviceState { State = "Брак" };
                DeviceState deviceState3 = new DeviceState { State = "Не поверен" };
                DeviceState deviceState4 = new DeviceState { State = "На ремонте" };
                db.DeviceStates.AddRangeAsync(deviceState1, deviceState2, deviceState3, deviceState4);
                db.SaveChanges();





                Department department1 = new Department { Name = "Лаборатория СВЧ", SubdevisionNumber = "о. 147" };
                Department department2 = new Department { Name = "Лаборатория теплороиборов", SubdevisionNumber = "ц. 192" };
                Department department3 = new Department { Name = "Лаборатория радиоаппаратуры", SubdevisionNumber = "ц. 156" };
                Department department4 = new Department { Name = "Отдел ремонта", SubdevisionNumber = "ц. 116" };
                Department department5 = new Department { Name = "Отдел сборки гвч", SubdevisionNumber = "о. 146" };

                db.Departments.AddRangeAsync(department1, department2, department3, department4, department5);
                db.SaveChanges();
            

                

                User user1 = new User 
                { Surname = "Воробьев", 
                    Name = "Егор", 
                    MiddleName = "Викторович", 
                    Login = "Egor2142", 
                    Password = "21422012", 
                    Department = department1 ,
                  //  DepartmentId=department1.Id
               };
                User user2 = new User
                {
                    Surname = "Захарова",
                    Name = "Татьяна",
                    MiddleName = "Викторовна",
                    Login = "Tat43",
                    Password = "1234",
                    Department = department1,
                };
                
                User user3 = new User
                {
                    Surname = "Назаркин",
                    Name = "Игорь",
                    MiddleName = "Иванович",
                    Login = "QWER",
                    Password = "3421",
                    Department = department1
                };
                User user4 = new User
                {
                    Surname = "Кочетков",
                    Name = "Борис",
                    MiddleName = "Анатольевич",
                    Login = "ASD",
                    Password = "098L",
                    Department = department1
                };
                User user5 = new User
                {
                    Surname = "Максимович",
                    Name = "Максим",
                    MiddleName = "Алексеевич",
                    Login = "Zet",
                    Password = "2387a",
                    Department = department1
                };
                User user6 = new User
                {
                    Surname = "Пушкина",
                    Name = "Людмила	",
                    MiddleName = "Алексеевич",
                    Login = "Tex4444",
                    Password = "44321fnf",
                    Department = department2
                };
                User user7 = new User
                {
                    Surname = "Оладушков",
                    Name = "Егор",
                    MiddleName = "Викторович",
                    Login = "RUT",
                    Password = "RUT22",
                    Department = department3

                };
                User user8 = new User
                {
                    Surname = "Димитров",
                    Name = "Сергей"	,
                    MiddleName = "Александрович",
                    Login = "Alex123",
                    Password = "Alex123",
                    Department = department4
                };
                User user9 = new User
                {
                    Surname = "Малышева",
                    Name = "Марина",
                    MiddleName = "Юрьевна",
                    Login = "MAX",
                    Password = "max23",
                    Department = department5
                };
                User user10 = new User
                {
                    Surname = "	Баранов",
                    Name = "Алексей",
                    MiddleName = "Сергеевич",
                    Login = "Admin",
                    Password = "admin123",
                    Department = department1
                };
                

                db.Users.AddRange(user1,user2,user3,user4,user5,user6,user7,user8,user9,user10);
                db.SaveChanges();






                Calibrator calibrator1 = new Calibrator
                {
                    Surname = "Сталинн",
                    Name = "Егор",
                    MiddleName = "Викторович",
                    Department = department1
                    //  DepartmentId=department1.Id
                };

                Calibrator calibrator2 = new Calibrator
                {
                    Surname = "Ленин",
                    Name = "Егор2",
                    MiddleName = "Викторович2",
                    Department = department2
                    //  DepartmentId=department1.Id
                };

                Calibrator calibrator3 = new Calibrator
                {
                    Surname = "Ельцин",
                    Name = "Егор3",
                    MiddleName = "Викторович3",
                    Department = department3
                    //  DepartmentId=department1.Id
                };

                db.Calibrators.AddRange(calibrator1, calibrator2, calibrator3);
                db.SaveChanges();







                MeasuringInstrument instrument1 = new MeasuringInstrument()
                {
                    DeviceName = "Г4-78",
                    Department = department1,
                    DepartmentId = department1.Id,
                    UseDate = DateTime.Now,
                    CalibrationPeriod = period1,
                    CalibrationPeriodId = period1.Id,
                    Manufacturer = manufacturer1,
                    ManufacturerID = manufacturer1.Id,
                    ManufacturerNumber = "12364",
                    InventoryNumber = "001",
                    DeviceType = type1,
                    DeviceTypeId = type1.Id,
                    WorkRange = "1,16 - 1,78 Ггц",
                    MeasurementUnit = unit3,
                    MeasurementUnitId = unit3.Id,
                    ScaleStep = "0,1",
                    Error = "5*10^-6",
                    MainPartsList = "Паспорт, упаковка",
                    DeviceState= deviceState1
                };
                db.MeasuringInstruments.Add(instrument1);
                db.SaveChanges();



                MeasuringInstrument instrument2 = new MeasuringInstrument()
                {
                    DeviceName = "Ч3-66",
                    Department = department2,
                    DepartmentId = department2.Id,
                    UseDate = DateTime.Now,
                    CalibrationPeriod = period2,
                    CalibrationPeriodId = period2.Id,
                    Manufacturer = manufacturer2,
                    ManufacturerID = manufacturer2.Id,
                    ManufacturerNumber = "7788",
                    InventoryNumber = "002",
                    DeviceType = type2,
                    DeviceTypeId = type2.Id,
                    WorkRange = "10 Гц - 37,75 Ггц",
                    MeasurementUnit = unit3,
                    MeasurementUnitId = unit3.Id,
                    ScaleStep = "0,1",
                    Error = "±5·10-7",
                    MainPartsList = "Инструкция, упаковка",
                    DeviceState = deviceState2
                };
                db.MeasuringInstruments.Add(instrument2);
                db.SaveChanges();



                Calibration calibration1 = new Calibration()
                {
                    MeasuringInstrumentId = instrument1.Id,
                    MeasuringInstrument = instrument1,
                    Date = new DateTime(2020, 11, 01),
                    Rezult = "Откалиброван",
                    Calibrator = calibrator1,
                    NextCalibrationDate = new DateTime(2021, 04, 11)
                };

                Calibration calibration2 = new Calibration()
                {
                    MeasuringInstrumentId = instrument1.Id,
                    MeasuringInstrument = instrument1,
                    Date = new DateTime(2021, 04, 13),
                    Rezult = "Откалиброван",
                    Calibrator = calibrator1,
                    NextCalibrationDate = new DateTime(2022, 04, 14)
                };

                db.Calibrations.AddRange(calibration1, calibration2);
                db.SaveChanges();

                Calibration calibration3 = new Calibration()
                {
                    MeasuringInstrumentId = instrument2.Id,
                    MeasuringInstrument = instrument2,
                    Date = new DateTime(2001, 03, 01),
                    Rezult = "Откалиброван",
                    Calibrator = calibrator2,
                    NextCalibrationDate = new DateTime(2002, 03, 02)
                };

                Calibration calibration4 = new Calibration()
                {
                    MeasuringInstrumentId = instrument2.Id,
                    MeasuringInstrument = instrument2,
                    Date = new DateTime(2002, 03, 05),
                    Rezult = "Откалиброван",
                    Calibrator = calibrator2,
                    NextCalibrationDate = new DateTime(2003, 03, 06)
                };

                Calibration calibration5 = new Calibration()
                {
                    MeasuringInstrumentId = instrument2.Id,
                    MeasuringInstrument = instrument2,
                    Date = new DateTime(2003, 03, 06),
                    Rezult = "Списан",
                    Calibrator = calibrator2,
                    NextCalibrationDate = null
                };

                db.Calibrations.AddRange(calibration3, calibration4, calibration5);
                db.SaveChanges();


                Repair repair1 = new Repair()
                {
                    MeasuringInstrumentId = instrument2.Id,
                    MeasuringInstrument = instrument2,
                    Date = new DateTime(2003, 03, 06),
                    Description = "Замена микросхемы ИР155"
                };

                Repair repair2 = new Repair()
                {
                    MeasuringInstrumentId = instrument2.Id,
                    MeasuringInstrument = instrument2,
                    Date = new DateTime(2004, 07, 02),
                    Description = "Замена шнура питания"
                };

                db.Repairs.AddRange(repair1, repair2);
                db.SaveChanges();


                Repair repair3 = new Repair()
                {
                    MeasuringInstrumentId = instrument1.Id,
                    MeasuringInstrument = instrument1,
                    Date = new DateTime(2021, 01, 12),
                    Description = "Замена индикатора"
                };

                Repair repair4 = new Repair()
                {
                    MeasuringInstrumentId = instrument1.Id,
                    MeasuringInstrument = instrument1,
                    Date = new DateTime(2022, 01, 03),
                    Description = "Замена резистора 100КОм"
                };

                db.Repairs.AddRange(repair3, repair4);
                db.SaveChanges();






                //перемещения СИ
                Moving moving1 = new Moving()
                {
                    MeasuringInstrumentId = instrument1.Id,
                    MeasuringInstrument = instrument1,
                    Date = new DateTime(2003, 03, 06),
                    GiveDepartment = department1,
                    GiveDepartmentId = department1.Id,
                    TakeDepartment = department2,
                    TakeDepartmentId = department2.Id,
                    GiveName = "Петров С.И",
                    TakeName = "Смиронов С.М."
                };


                Moving moving2 = new Moving()
                {
                    MeasuringInstrumentId = instrument1.Id,
                    MeasuringInstrument = instrument1,
                    Date = new DateTime(2009, 03, 06),
                    GiveDepartment = department2,
                    GiveDepartmentId = department2.Id,
                    TakeDepartment = department3,
                    TakeDepartmentId = department3.Id,
                    GiveName = "Смиронов С.М.",
                    TakeName = "Печкин В.В."
                };
                db.Movings.AddRange(moving1, moving2);
                db.SaveChanges();



                //Свидетельства о поверке
                Сertificate certificate1 = new Сertificate()
                {
                    Businessman="ИП Гаврилов",
                    Number = "02-2",
                    MeasuringInstrumentId = instrument2.Id,
                    MeasuringInstrument = instrument2,
                    Info = "рег.№ 77=99",
                    Values="Гц, 1гц-100МГц",
                    Document = "Приказ №99-01",
                    Job = "Заместитель главного инженера",
                    Director = "Главный С.С.",
                    Calibrator = calibrator2,
                    CalibratorId = calibrator2.Id,
                    Date = new DateTime(2011, 01, 03),
                    ActiveDate= new DateTime(2012, 01, 03),
                    Standard="Эталон Р-123",
                    Factors="Повышенная влажность",
                    Mark="123-11"
                };
                db.Сertificates.AddRange(certificate1);
                db.SaveChanges();




                //Извещения о непригодности к применению
                Unsuitability unsuitability1 = new Unsuitability()
                {
                    Number="01-1",
                    MeasuringInstrumentId = instrument1.Id,
                    MeasuringInstrument = instrument1,
                    Info="рег.№ 123455",
                    Document="Приказ №12-01",
                    Job="Заместитель главного инженера",
                    Director="Главный С.С.",
                    Calibrator=calibrator3,
                    CalibratorId=calibrator3.Id,
                    Date = new DateTime(2010, 01, 03),
                    UnsuitabilityReasons = "Не включается"
                };
                db.Unsuitabilities.AddRange(unsuitability1);
                db.SaveChanges();

            }
        }
    }
}
