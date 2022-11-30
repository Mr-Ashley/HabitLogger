using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitLogger
{
    public class Utils
    {
        public static void getUserInput()
        {
            Console.Clear();
            bool endApp = false;

            while (!endApp)
            {
                Console.WriteLine("MAIN MENU\n");
                Console.WriteLine("What would you like to do?\n");

                Console.WriteLine("Type 0 to View All Records");
                Console.WriteLine("Type 1 Insert Record");
                Console.WriteLine("Type 2 Delete Record");
                Console.WriteLine("Type 3 to Update Record");
                Console.WriteLine("Type 4 to Close Application\n");

                Console.WriteLine("-----------------------------");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        break;
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        break;
                }
            }
        }

    }
}


