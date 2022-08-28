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

            Currency currency = new Currency();
            currency.code = 240;
            currency.value = "EUR";

            NewContact(emp1);

            Console.WriteLine("Наш контракт: " + emp1.Contract);

            currency = UpdateCurrency(currency); // меняет свойства валюты
            Console.WriteLine("Изначально используется валюта EUR, пробуем поменять. Результат " + currency.value);

        }
        public static void NewContact(Employee newEmployee)
        {
            Console.WriteLine("Введите новое значение контракта");
            newEmployee.Contract = Console.ReadLine();
        }

        static Currency UpdateCurrency(Currency currency)
        {
            Console.WriteLine("Введите новый код валюты");
            //currency.code = 120;
            currency.code = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите валюту");
            //currency.value = "USD";
            currency.value = Console.ReadLine();

            return currency;
        }

    }
}