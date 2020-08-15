
using System;

namespace StartProjects
{
    class StartProjects
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("         Projects created in course");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Select the project: ");
                Console.WriteLine("-> (A) Abastract");
                Console.WriteLine("-> (B) Abstract 2 ");
                Console.WriteLine("-> (C) Exceptions ");
                Console.WriteLine("-> (D) Interface ");
                //Console.WriteLine("-> (E) Xadrez ");
                Console.Write("\n Opção: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Clear();
                string[] x = new string[2];
                
                switch (ch)
                {
                    case 'A': //Abastract
                        Abstract.Abstract.Main(x);
                        break;
                    case 'B': //Abastract 2
                        Abstract_02.Abstract_02.Main(x);
                        break;
                    case 'C': //Exceptions
                        Exceptions.Exceptions.Main(x);
                        break;
                    case 'D': //Interface
                        Interface.ProgramInterface.Main(x);
                        break;
                    //case 'E': //Xadrez
                    //    break;
                    default:
                        throw new Exception("Invalid option!");
                }
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}
