using System;
using Models;


namespace PracticeWithTypes
{
    public class PracticeWithTypes
    {
        
        public static void Main()
        {
            CastAndConvert.BankService bankService = new CastAndConvert.BankService();

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

            Client client = new Client();
            client.CodeClient = $"244";
            client.Name = "Alex";
            client.PassNumber = 24355;
            client.BirthDate = DateTime.Now;

            object result = bankService.ClientToEmloyee(client);

            if (result is Employee)
            {
                Console.WriteLine("Преобразование клиента в работаника прошло успешно");
            }
            else
            {
                Console.WriteLine("Преобразование клиента в работника не удалось");
            }


        }
        public static void NewContact(Employee newEmployee)
        {
            Console.WriteLine("Введите новое значение контракта");
            newEmployee.Contract = Console.ReadLine();
        }

        static Currency UpdateCurrency(Currency currency)
        {
            Console.WriteLine("Введите новый код валюты");

            object temp_value = Console.ReadLine();
            if (temp_value is int)
            {
                currency.code = (int)temp_value;
            }

            Console.WriteLine("Введите валюту");

            currency.value = Console.ReadLine();

            return currency;
        }

    }
}