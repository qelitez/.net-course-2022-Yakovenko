using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models

{
    public class BankService
    {
        public int GetSalary(int bankIncome, int countWorkers, int expenses)
        {
            return ((bankIncome - expenses) / countWorkers);
        }
        public object ClientToEmloyee(Client client)
        {
            Employee employee = new Employee();
            employee.Name = client.Name;
            employee.BirthDate = client.BirthDate;
            employee.PassNumber = client.PassNumber;
            return employee;
        }
    }
}


