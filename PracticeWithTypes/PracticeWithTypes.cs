using System;
using Models;

namespace PracticeWithTypes
{
    public class PracticeWithTypes
    {
        public static void Main()
        {
            Employee emp1 = new Employee();
            emp1.Name = "Fedor";
            emp1.BirthDate = DateTime.Now;
            emp1.PassNumber = 123456;

            NewContact(emp1);

            Console.WriteLine("Наш контракт: " + emp1.Contract);

        }
        public static void NewContact(Employee newEmployee)
        {
            newEmployee.Contract = Console.ReadLine();
        }
    }


}