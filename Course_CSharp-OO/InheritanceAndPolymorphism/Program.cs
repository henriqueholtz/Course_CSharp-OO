using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of products: ");
            int qtd = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();
            for (int i = 1; i <= qtd; i++ )
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported? (c/u/i) ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                switch (type)
                {
                    case 'c': //Common
                        Product c = new Product(name, price);
                        list.Add(c);
                        break;
                    case 'u': //Used
                        Console.Write("Manufacture Date (DD/MM/YYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        Product u = new UsedProduct(name, price, manufactureDate);
                        list.Add(u);
                        break;

                    case 'i': //Imported
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        Product pi = new ImportedProduct(name, price, customsFee);
                        list.Add(pi);
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach(Product product in list)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
