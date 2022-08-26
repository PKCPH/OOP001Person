using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP001Person
{
    internal class Person
    {

        ////////Properties////////
        public string? Name { get; set; }

        public DateTime DoB { get; set; }

        //set is GetAgeFromDoB();
        public int Age { get { return GetAgeFromDoB(); } }

        public string Email { get; set; }

        public string Password { get; set; }

        ////////Methods////////
        //Gets age from DoB and subtracts it from Current DateTime.Today
        public int GetAgeFromDoB()
        {
            DateTime dateToday = DateTime.Today;
            int age = dateToday.Year - DoB.Year;
            return age;
        }
    }
}
