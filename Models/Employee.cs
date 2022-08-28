using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee : Person
    {
        //Поле
        private string contract;
        private int salary;

        //Свойство
        public string Contract { get { return contract; } set { contract = value; } }
        public int Salary { get { return salary; } set { salary = value; } }
    }

}
