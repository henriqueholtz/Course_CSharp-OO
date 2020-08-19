using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public static class ProgramDictionary
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("                Dictionary");
            Console.WriteLine("-----------------------------------------------");

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Dictionary<string, int> x = new Dictionary<string, int>();

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    if (x.ContainsKey(line[0]))
                    {
                        x[line[0]] += int.Parse(line[1]);
                    }
                    else
                    {
                        x.Add(line[0], int.Parse(line[1]));
                    }
                }
            }

            foreach (var item in x)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
