using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        { 
            var employee = new Employee
            {
                Name = "Sanzhar",
                Vacancy = Vacancies.Boss,
                Salary = 500000,
                EnterDate = new int[3] { 24, 07, 2019 }
            };
            Console.WriteLine("Имя: " + employee.Name);
            Console.WriteLine("Должность: " + employee.Vacancy);
            Console.WriteLine("Зарплата = " + employee.Salary);
            Console.WriteLine($"Дата приема на работу - {employee.EnterDate[0]}/{employee.EnterDate[1]}/{employee.EnterDate[2]}");
            Console.ReadLine();
        }
    }
}
