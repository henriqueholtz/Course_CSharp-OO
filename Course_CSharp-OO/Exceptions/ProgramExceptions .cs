using System;
using System.Diagnostics;
using System.Globalization;

namespace Exceptions
{
    public static class Exceptions
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("                  Exceptions");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("\nEnter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number, holder, balance, withdrawLimit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance);
            }
            catch (DomainException dom) //Custom Exception
            {
                Console.WriteLine(dom.Message);
            }
            catch (Exception genericEx)
            {
                Console.WriteLine(genericEx.Message);
            }

        }
    }
}
