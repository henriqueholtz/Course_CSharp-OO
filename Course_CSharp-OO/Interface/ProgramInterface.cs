using Interface.Service;
using System;
using System.Globalization;

namespace Interface
{
    public static class ProgramInterface
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("                 Interface");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(myContract, months);
            Console.WriteLine();
            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
