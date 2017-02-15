using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Lesson04Menu
    {
        public static void programMenu() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("              NextGen Production v.1.03");
            Console.WriteLine("        Select program number end press ENTER.");          
            Console.WriteLine("        Menu:");            
            Console.WriteLine("        ===========================================");
            Console.WriteLine("        == 1. Odd or Even analizator.            ==");
            Console.WriteLine("        == 2. Is Triangle right-angled debugger. ==");
            Console.WriteLine("        == 3. Calculate bigger cicle area.       ==");
            Console.WriteLine("        == 4. Calculate cicle area.              ==");
            Console.WriteLine("        == 0. Exit                               ==");
            Console.WriteLine("        ===========================================");

            string menuNumber = Console.ReadLine();

            programSelect(menuNumber);

        }

        public static void programSelect(string menuNumber) {
            if (menuNumber == "1")
            {
                Console.Clear();
                Console.WriteLine("Type any Integer Number ");
                string number = Console.ReadLine();
                string result = DefineNumber.evenOrOdd(number);
                if (result == "WrongData")
                {
                    Console.WriteLine("Seems like You type wrong data type. Press Enter to continue.");
                    Console.ReadLine();
                    programMenu();
                }
                else if (result == "isEven") {
                    Console.WriteLine("NumberYou Type - " + number + "  is EVEN.");
                    Console.ReadLine();
                    programMenu();
                }
                else if (result == "isOdd") {
                    Console.WriteLine("NumberYou Type - " + number + "  is ODD.");
                    Console.ReadLine();
                    programMenu();
                }

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
                string result = tri.isTriangleRightAngled(a, b, c);

                if (result == "WrongData")
                {
                    Console.WriteLine("Seems like You type wrong data type. Press Enter to continue.");
                    Console.ReadLine();
                    programMenu();
                }
                else if (result == "RightAngle")
                {
                    Console.WriteLine("Triangle is right-angled");
                    Console.ReadLine();
                    programMenu();
                }
                else if (result == "NotRightAngle")
                {
                    Console.WriteLine("Not right-angled triagle");
                    Console.ReadLine();
                    programMenu();
                }
            }
            else if (menuNumber == "3")
            {
                Console.Clear();
                Console.WriteLine("Enter radius 1 ");
                string r1 = Console.ReadLine();

                Console.WriteLine("Enter radius 2 ");
                string r2 = Console.ReadLine();
                string result = CircleArea.CalculateBiggerCicleArea(r1, r2);

                if (result == "WrongData")
                {
                    Console.WriteLine("Seems like You type wrong data type. Press Enter to continue.");
                    Console.ReadLine();
                    programMenu();
                }
                else if (result == "Area1")
                {
                    Console.WriteLine("Area1 is bigger");
                    Console.ReadLine();
                    programMenu();
                }
                else if (result == "AreasEqual")
                {
                    Console.WriteLine("Area1 is equal to Area2");
                    Console.ReadLine();
                    programMenu();
                }
                else if (result == "Area2")
                {
                    Console.WriteLine("Area2 is bigger");
                    Console.ReadLine();
                    programMenu();
                }
            }
            else if (menuNumber == "4")
            {
                Console.Clear();
                Console.WriteLine("Type radius value: ");
                string r = Console.ReadLine();
                double pi = 3.14;
                double result = CircleRadius.CalculateCicleArea(r, pi);

                if (result == 1.0403)
                {
                    Console.WriteLine("Seems like You type wrong data type. Press Enter to continue.");
                    Console.ReadLine();
                    programMenu();
                }
                else 
                {
                    Console.WriteLine("Area is " + result);
                    Console.ReadLine();
                    Lesson04Menu.programMenu();
                }
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
