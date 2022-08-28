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

        //Свойство
        public string Contract { get { return contract; } set { contract = value; } }
    }

}
