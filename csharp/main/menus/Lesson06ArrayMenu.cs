using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.menus
{
    class Lesson06ArrayMenu
    {
        public static void programMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("              NextGen Production v.1.06");
            Console.WriteLine("        Select Home Tak number end press ENTER.");
            Console.WriteLine("        Menu:");
            Console.WriteLine("        ===========================================");
            Console.WriteLine("        == 1. Task 01                            ==");
            Console.WriteLine("        == Create array with even numbers from 2 to 20. Write them in line using spaces, and then in column ==");
            Console.WriteLine("        == 2. Task 02                            ==");
            Console.WriteLine("        == Create array with odd numbers from 1 to 99. Write them in line using spaces, after write array in line by desc order ==");
            Console.WriteLine("        == 3. Task 03                            ==");
            Console.WriteLine("        == Create array with 15 random number in range [0 - 9]. Write array in line. Calculate how much even numbers are in array and write the count of it. ==");
            Console.WriteLine("        == 4. Task 04                            ==");
            Console.WriteLine("        == Create array with 15 random number in range [0 - 999]. Write array in line. After write max and min value of array. ==");
            Console.WriteLine("        == 5. Task 05                            ==");
            Console.WriteLine("        == Create multi-demension array with 8 strings and 5 column, and with random number in range [10 - 99]. Write array in console. ==");
            Console.WriteLine("        == 0. Exit                               ==");
            Console.WriteLine("        ===========================================");

            string menuNumber = Console.ReadLine();

            programSelect(menuNumber);

        }

        public static void programSelect(string menuNumber)
        {
            if (menuNumber == "1")
            {
                Console.Clear();

            
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
            else if (menuNumber == "0")
            {
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

