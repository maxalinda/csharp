using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.menus
{
    class MainMenu
    {
        public static void programMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("              NextGen Production v.1.03");
            Console.WriteLine("        Select Home Work               ");
            Console.WriteLine("        Menu:");
            Console.WriteLine("        ===========================================");
            Console.WriteLine("        == 1. Lesson 04 Homework                 ==");
            Console.WriteLine("        == 2. Lesson 06 Array Homework           ==");
            Console.WriteLine("        == 3. Lesson 07 String Homework          ==");
            Console.WriteLine("        == 0. Exit                               ==");
            Console.WriteLine("        ===========================================");

            string menuNumber = Console.ReadLine();

            programSelect(menuNumber);

        }

        public static void programSelect(string menuNumber)
        {
            if (menuNumber == "1")
            {
                Lesson04Menu.programMenu();
            }
            else if (menuNumber == "2")
            {
                Lesson06ArrayMenu.programMenu();
            }
            else if (menuNumber == "3")
            {
                Lesson07StringMenu.programMenu();
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
