using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstract_02
{
    public static class Abstract_02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("                Abstract_02");
            Console.WriteLine("-----------------------------------------------");
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Person> listPerson = new List<Person>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'c') //Company
                {
                    Console.Write("Number of Employees: ");
                    int employeesQuantity = int.Parse(Console.ReadLine());
                    listPerson.Add(new LegalPerson(employeesQuantity, name, anualIncome));
                }
                else
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listPerson.Add(new PhysicalPesron(healthExpenditure, name, anualIncome));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double total = 0;
            foreach(Person person in listPerson)
            {
                Console.WriteLine(person.Name + ": $ " + person.Taxes().ToString("F2",CultureInfo.InvariantCulture)); 
                total += person.Taxes();
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + total.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
