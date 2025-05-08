using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool exit = false;

            do
            {
                Console.WriteLine("Choose : 1-6");

                Console.WriteLine("1. Sgan mishne");
                Console.WriteLine("2. Sgan");
                Console.WriteLine("3. Seren");
                Console.WriteLine("4. Rav seren");
                Console.WriteLine("5. Sgan aluf");
                Console.WriteLine("6. Yetzia");
                Console.Write("Katzin yakar, ana bachar achat meha'efsharuyot: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Kol hakavod le'sgan mishne, be'od 8 dargot tihye Ramatkal");
                            break;
                        case 2:
                            Console.WriteLine("Kol hakavod le'sgan, be'od 7 dargot tihye Ramatkal");
                            break;
                        case 3:
                            Console.WriteLine("Kol hakavod le'seren, be'od 6 dargot tihye Ramatkal");
                            break;
                        case 4:
                            Console.WriteLine("Kol hakavod le'rav seren, be'od 5 dargot tihye Ramatkal");
                            break;
                        case 5:
                            Console.WriteLine("Kol hakavod le'sgan aluf, be'od 4 dargot tihye Ramatkal");
                            break;
                        case 6:
                            Console.WriteLine("Toda ve'shalom, yalla bye");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Hala ta'ut ba'erech she'natan, ana nasa shuv");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Hala ta'ut ba'erech she'natan, ana nasa shuv");
                }

                Console.WriteLine();

            } while (!exit);
        }
    }
    }

