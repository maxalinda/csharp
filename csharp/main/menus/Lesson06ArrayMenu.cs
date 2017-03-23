using csharp.main.homework.lesson06;
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
            Console.Clear();
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
            Console.WriteLine("        == Create multi-demension array with 8 strings and 5 column, and with random even number in range [10 - 99]. Write array in console in matrix view. ==");
            Console.WriteLine("        == 6. Task 06                            ==");
            Console.WriteLine("        == Create multi-demension array with 8 strings and 5 column, and with random even number in range [1 - 999]. Write array in console in matrix view and right justified. ==");
            Console.WriteLine("        == 7. Task 07                            ==");
            Console.WriteLine("        == Ask User to type Int numbers till he wrote Exit to stop. After Write in Console all numbers with comma, and then Sum of it.==");
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
                Lesson06Array hom = new Lesson06Array();
                hom.Task01();
                programMenu();

            }
            else if (menuNumber == "2")
            {
                Console.Clear();
                Lesson06Array hom = new Lesson06Array();
                hom.Task02();
                programMenu();
            }
            else if (menuNumber == "3")
            {
                Console.Clear();
                Lesson06Array hom = new Lesson06Array();
                hom.Task03();
                programMenu();
            }
            else if (menuNumber == "4")
            {
                Console.Clear();
                Lesson06Array hom = new Lesson06Array();
                hom.Task04();
                programMenu();
            }
            else if (menuNumber == "5")
            {
                Console.Clear();
                Lesson06Array hom = new Lesson06Array();
                hom.Task05();
                programMenu();
            }
            else if (menuNumber == "6")
            {
                Console.Clear();
                Lesson06Array hom = new Lesson06Array();
                hom.Task06();
                programMenu();
            }
            else if (menuNumber == "7")
            {
                Console.Clear();
                Lesson06Array hom = new Lesson06Array();
                hom.Task07();
                programMenu();
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

