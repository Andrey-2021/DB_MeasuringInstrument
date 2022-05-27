using CommonClassLibrary;
using ConteinerLibrary;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// Регистрация репозиториев в контейнере
    /// </summary>
    public class RepositiryRegistration
    {

        public static void RegistrationInContainer(Conteiner conteiner)
        {
            //Conteiner.GetInstance().RepRegister<IBaseRepository<CalibrationPeriod>, DbRepository<CalibrationPeriod>>();
            //Conteiner.GetInstance().RepRegister<IBaseRepository<Department>, DbRepository<Department>>();
            //Conteiner.GetInstance().RepRegister<IBaseRepository<DeviceType>, DbRepository<DeviceType>>();
            //Conteiner.GetInstance().RepRegister<IBaseRepository<MeasurementUnit>, DbRepository<MeasurementUnit>>();
            //Conteiner.GetInstance().RepRegister<IBaseRepository<CalibrationPeriod>, DbRepository<CalibrationPeriod>>();
            //Conteiner.GetInstance().RepRegister<IBaseRepository<Manufacturer>, DbRepository<Manufacturer>>();
            //Conteiner.GetInstance().RepRegister<IBaseRepository<DeviceState>, DbRepository<DeviceState>>();

            //Conteiner.GetInstance().RepRegister<IBaseRepository<MeasuringInstrument>, DbRepository<MeasuringInstrument>>();
            //Conteiner.GetInstance().RepRegister<IBaseRepository<User>, DbRepository<User>>();
         
        }



    }
}
