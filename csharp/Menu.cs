using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Menu
    {
        public static void programMenu() {
            Console.WriteLine("                                                           NextGen Production v.1.01");
            Console.WriteLine("Select program number end press ENTER.");          
            Console.WriteLine("Menu:");
            Console.WriteLine("===========================================");
            Console.WriteLine("== 1. Odd or Even analizator.            ==");
            Console.WriteLine("== 2. Is Triangle right-angled debugger. ==");
            Console.WriteLine("== 3. Calculate bigger cicle area.       ==");
            Console.WriteLine("== 4. Calculate cicle area.              ==");
            Console.WriteLine("== 0. Exit                               ==");
            Console.WriteLine("===========================================");

            string menuNumber = Console.ReadLine();

            programSelect(menuNumber);

        }

        public static void programSelect(string menuNumber) {
            if (menuNumber == "1")
            {
                Console.Clear();
                Console.WriteLine("Type any Integer Number ");
                string number = Console.ReadLine();
                DefineNumber.evenOrOdd(number);
            }
            else if (menuNumber == "2")
            {
                Console.Clear();
                Console.WriteLine("Enter side A Integer");
                string a = Console.ReadLine();
                Console.WriteLine("Enter side B Integer");
                string b = Console.ReadLine();
                Console.WriteLine("Enter side C Integer");
                string c = Console.ReadLine();

                TriangleCalculation tri = new TriangleCalculation();
                tri.isTriangleRightAngled(a, b, c);
            }
            else if (menuNumber == "3")
            {
                Console.Clear();
                Console.WriteLine("Enter radius 1 ");
                string r1 = Console.ReadLine();

                Console.WriteLine("Enter radius 2 ");
                string r2 = Console.ReadLine();
                CircleArea.CalculateBiggerCicleArea(r1, r2);
            }
            else if (menuNumber == "4")
            {
                Console.Clear();
                Console.WriteLine("Type radius value: ");
                string r = Console.ReadLine();
                double pi = 3.14;
                CircleRadius.CalculateCicleArea(r, pi);
            }
            else if (menuNumber == "0") {
                exitMenu();
            }
            else
            {
                Console.WriteLine("You selected unexistance program. Press Enter to continue.");
                Console.ReadLine();
                programMenu();
            }
            
        }
        public static void exitMenu()
        {
           
        }

    }
}
