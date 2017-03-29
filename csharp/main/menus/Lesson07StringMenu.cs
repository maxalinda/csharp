using csharp.main.homework.lesson07;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.menus
{
    class Lesson07StringMenu
    {
        public static void programMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("              NextGen Production v.1.03");
            Console.WriteLine("        Select Palindrome analizator and press ENTER.");
            Console.WriteLine("        Menu:");
            Console.WriteLine("        ===========================================");
            Console.WriteLine("        == 1. Variant 01 to detect Palindrome    ==");
            Console.WriteLine("        == 2. Variant 02 to detect Palindrome    ==");
            Console.WriteLine("        == 3. Variant 03 to detect Palindrome    ==");
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
                Console.WriteLine("Type any world You want to check for Palindrome.");
                string number = Console.ReadLine();
                Lesson07String str = new Lesson07String();

                bool result = str.IsPalindrome01(number);
                if (result)
                {
                    Console.WriteLine("The word You Type is Palindrome");
                    Console.ReadLine();
                    programMenu();
                }
                else {
                    Console.WriteLine("The word You Type is Not a Palindrome");
                    Console.ReadLine();
                    programMenu();
                } 
             

            }
            else if (menuNumber == "2")
            {
                Console.Clear();
                Console.WriteLine("Type any world You want to check for Palindrome.");
                string number = Console.ReadLine();
                Lesson07String str = new Lesson07String();

                bool result = str.IsPalindrome02(number);
                if (result)
                {
                    Console.WriteLine("The word You Type is Palindrome");
                    Console.ReadLine();
                    programMenu();
                }
                else
                {
                    Console.WriteLine("The word You Type is Not a Palindrome");
                    Console.ReadLine();
                    programMenu();
                }
            }
            else if (menuNumber == "3")
            {
                Console.Clear();
                Console.WriteLine("Type any world You want to check for Palindrome.");
                string number = Console.ReadLine();
                Lesson07String str = new Lesson07String();

                bool result = str.IsPalindrome03(number);
                if (result)
                {
                    Console.WriteLine("The word You Type is Palindrome");
                    Console.ReadLine();
                    programMenu();
                }
                else
                {
                    Console.WriteLine("The word You Type is Not a Palindrome");
                    Console.ReadLine();
                    programMenu();
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
