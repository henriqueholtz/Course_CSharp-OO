using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    public static class ProgramSet
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("                    Set");
            Console.WriteLine("-----------------------------------------------");
            HashSet<int> listSet = new HashSet<int>();
            Console.Write("How many students for course A ? ");
            int quantityA = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantityA; i++)
            {
                int item = int.Parse(Console.ReadLine());
                listSet.Add(item);
            }
            Console.Write("How many students for course B ? ");
            int quantityB = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantityB; i++)
            {
                int item = int.Parse(Console.ReadLine());
                listSet.Add(item);
            }
            Console.Write("How many students for course C ? ");
            int quantityC = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantityC; i++)
            {
                int item = int.Parse(Console.ReadLine());
                listSet.Add(item);
            }

            Console.WriteLine("Total stutents: " + listSet.Count);
            Console.ReadKey();
        }
    }
}
