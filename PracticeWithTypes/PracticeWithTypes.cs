using System;
using Models;

namespace PracticeWithTypes
{
    public class PracticeWithTypes
    {
        public static void Main()
        {
            Employee fedor = new Employee();
            fedor.Name = "Fedor";
            fedor.BirthDate = DateTime.Now;
            fedor.PassNumber = 123456;

            Currency currency = new Currency();
            currency.code = 240;
            currency.value = "EUR";

            UpdateContract(fedor);

            Console.WriteLine("Наш контракт: " + fedor.Contract);

            currency = UpdateCurrency(currency);
            Console.WriteLine("Изначально используется валюта EUR, пробуем поменять. Результат " + currency.value);

        }
        public static void UpdateContract(Employee newEmployee)
        {
            Console.WriteLine("Введите новое значение контракта");
            newEmployee.Contract = Console.ReadLine();
        }

        static Currency UpdateCurrency(Currency currency)
        {
            Console.WriteLine("Введите новый код валюты");
            currency.code = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите валюту");
            currency.value = Console.ReadLine();

            return currency;
        }

    }
}