using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using Models;
using System.Threading.Tasks;

namespace BankService
{
    public partial class BankService : ServiceBase
    {

        public BankService()
        {
            InitializeComponent();
        }
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

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }

}
