using csharp.main.homework.lesson08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.menus
{
    class Lesson08FilesMenu
    {
        public static void programMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;           
            Console.WriteLine("        Select  Task and press ENTER.");
            Console.WriteLine("        Menu:");
            Console.WriteLine("        ===========================================");
            Console.WriteLine("        == 1. Task 01 Read file with 2d array separated by comas. And Write another file with that array ==");
            Console.WriteLine("        == 2. Task 02 Read file with 5 words in column and write to another this words with Palindrome detection ==");
            Console.WriteLine("        == 3. Task 03 Write a program that ask Filename and then ask user to type words till user write Exit. Write all words to file ==");
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
                Lesson08FilesExeptions.Task01();
                programMenu();
            }
            else if (menuNumber == "2")
            {
                Console.Clear();
                Lesson08FilesExeptions.Task02();
                programMenu();
            }
            else if (menuNumber == "3")
            {
                Console.Clear();
                Lesson08FilesExeptions.Task03();
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
