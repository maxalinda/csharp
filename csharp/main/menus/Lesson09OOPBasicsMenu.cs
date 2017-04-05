using csharp.main.homework.lesson09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.menus
{
    class Lesson09OOPBasicsMenu
    {
        public static void programMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("        Select  Task and press ENTER.");
            Console.WriteLine("        Menu:");
            Console.WriteLine("        ===========================================");
            Console.WriteLine("        == 1. Task 01 Class Human with 2 parameters. Age, Name. Add getter and setter. Age valid 1-120 ==");            
            Console.WriteLine("        == 2. Task 02 Add class WhiteCollar with is extend from Human class. Constructor with age, name, company name params. ==");
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
                Console.WriteLine("Type Your Name.");
                String name = Console.ReadLine();

                Console.WriteLine("Type age between 1-120 values.");
                int age = Convert.ToInt32(Console.ReadLine());

                Human human = new Human(name, age);
               
                programMenu();
            }
            else if (menuNumber == "2")
            {
                Console.Clear();
                Console.WriteLine("Type Your Name.");
                String name = Console.ReadLine();

                Console.WriteLine("Type age between 1-120 values.");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type Your Company Name in A-z, a-z.");
                String companyName = Console.ReadLine();

                WhiteCollar white = new WhiteCollar(name, age, companyName);
                programMenu();
            }           
            else if (menuNumber == "0")
            {
                exitMenu();
            }
            else
            {
                Console.WriteLine("You selected unexistance Task. Press Enter to continue.");
                Console.ReadLine();
                programMenu();
            }

        }
        public static void exitMenu()
        {

        }
    }
}

