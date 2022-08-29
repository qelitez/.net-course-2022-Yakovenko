using System;
using System.Data;
using Models;

namespace PracticeWithTypes
{
    public class PracticeWithTypes
    {
        public static void Main()
        {
            BankService bankService = new BankService();

            Employee fedor = new Employee();
            fedor.Name = "Fedor";
            fedor.BirthDate = DateTime.Now;
            fedor.PassNumber = 123456;

            Currency currency = new Currency();
            currency.code = 123;
            currency.value = "EUR";

            UpdateContract(fedor);
            Console.WriteLine("Контракт обновлен на:" + fedor.Contract);

            fedor.Contract = CreateNewContract("Fedor", DateTime.Now, 654321);
            Console.WriteLine("Создан новый контракт: " + fedor.Contract);

            currency = UpdateCurrency(currency);
            Console.WriteLine("Изначально используется валюта EUR, пробуем поменять. Результат " + currency.value);

            Client client = new Client();
            client.CodeClient = $"244";
            client.Name = "Alex";
            client.PassNumber = 24355;
            client.BirthDate = DateTime.Now;

            object result = bankService.ClientToEmloyee(client);

            if (result is Employee)
            {
                Console.WriteLine("Преобразование клиента в работника прошло успешно");
            }
            else
            {
                Console.WriteLine("Преобразование клиента в работника не удалось");
            }

        }
        public static void UpdateContract(Employee newEmployee)
        {
            Console.WriteLine("Введите новое значение контракта");
            newEmployee.Contract = Console.ReadLine();
        }

        public static string CreateNewContract (string name, DateTime dataTime, int passNumber)
        {
            return $" Сотрудник {name}, родился {dataTime}, номер паспорта: {passNumber}";
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