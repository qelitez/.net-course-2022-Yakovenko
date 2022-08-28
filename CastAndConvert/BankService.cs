using Models;

namespace CastAndConvert
{
    public class BankService
    {
        public BankService()
        {

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
    }
}