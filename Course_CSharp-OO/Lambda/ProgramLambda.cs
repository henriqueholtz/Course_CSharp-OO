using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Lambda.Entities;

namespace Lambda
{
    public static class ProgramLambda
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("                  LAMBDA");
            Console.WriteLine("-----------------------------------------------");

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salaryMin = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] data = sr.ReadLine().Split(','); //Name,name@email.com,4500.00
                    list.Add(new Employee(data[0], data[1], double.Parse(data[2], CultureInfo.InvariantCulture)));
                }
            }

            Console.WriteLine("Email of people whose salary is more than {0} : ",salaryMin.ToString("F2",CultureInfo.InvariantCulture));
            var list2 = list.Where(e => e.Salary > salaryMin).OrderBy(o => o.Email).Select(e => e.Email);
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            var list3 = list.Where(x => x.Name.StartsWith("M")).Select(e => e.Salary);
            double sum = list3.Sum();
            Console.WriteLine("Sum of salary of people whose name starts with 'M' : " + sum.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
