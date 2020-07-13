using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_02
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    double healthExpenditure = double.Parse(Console.ReadLine());
                    listPerson.Add(new PhysicalPesron(healthExpenditure, name, anualIncome));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach(Person person in listPerson)
            {
                //print
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: ");
        }
    }
}
