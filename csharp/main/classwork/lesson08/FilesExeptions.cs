using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson08
{
    class FilesExeptions
    {
        public static void TextReader() {
            string path = "C:\\projects\\MyTest.txt";
            string s = "";

            path = @"C:\projectds\MyTest.txt1"; //Что бы не экранировать символы

             

            try
            {
                StreamReader sr = File.OpenText(path);

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("This is an exeption message" + e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("This is an generic exeption message" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("This is an exeption message" + e.StackTrace);
            }
            finally {
                Console.WriteLine("This is final block");
            }

            
            Console.ReadLine();
        }


        public static int GetNumber(int index)
        {

            int[] nums = { 300, 600, 900 };

            if (index > nums.Length || index <= 0)
            {

                throw new IndexOutOfRangeException("My message");

            }

            return nums[index];

        }

        public static void ShowNumber() {
            try
            {
                Console.WriteLine(GetNumber(3  ));
            }
            catch (Exception e)
            {
                Console.WriteLine("You got exeption " + e.Message);
            }
        }

        static void FileWriter()
        {
            string path = "C:\\projects\\MyTest.txt";
            path = @"c:\Temp\MyTest.txt";

            try
            {

                StreamWriter sw = new StreamWriter(path);

                sw.WriteLine("Hello, ");

                sw.WriteLine("Welcome");
            }

            catch (FileNotFoundException e)
            {

                Console.WriteLine(e.Message);

            }

            finally {
                

            }

            }


        }
}
