using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClassLibrary
{
    public class FindUserDTO
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string? Surname { get; set; } //(2)

        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string? Login { get; set; }



        //public Func<MeasuringInstrument, bool> GetFunc()
        //{

        //}

        /// <summary>
        /// Условие отбора записей в БД
        /// </summary>
        public Func<User, bool> Predicate => 
            x => x.Surname.ToUpper().Contains(this.Surname.ToUpper()) == true
            && x.Name.ToUpper().Contains(this.Name.ToUpper()) == true
            && x.Login.ToUpper().Contains(this.Login.ToUpper()) == true;
    }
}
