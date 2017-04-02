using csharp.main.homework.lesson07;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson08
{
    class Lesson08FilesExeptions
    {
        public static void Task01()
        {
            string path = @"d:\homework\Array.txt";

            String input = File.ReadAllText(path);

            int i = 0, j = 0;
            
            string[,] result = new string[5, 5];

            foreach (var row in input.Split('\n')) {
                j = 0;
                foreach (var col in row.Trim().Split(',')) {
                    result[i, j] = col.Trim();
                    j++;                   
                }               
                i++;
            }           

            ///Fill the table

            List<string> linesToWrite = new List<string>();

            for (int rowIndex = 0; rowIndex < 5; rowIndex++)
            {
                StringBuilder line = new StringBuilder();
                for (int colIndex = 0; colIndex < 5; colIndex++)
                    line.Append(result[rowIndex, colIndex]).Append(",");
                linesToWrite.Add(line.ToString());
            }

            System.IO.File.WriteAllLines(@"D:\homework\ArrayResult.txt", linesToWrite.ToArray());

        }

        public static void Task02() {

            string path = @"d:\homework\StringPalindrome.txt";
            string output = @"d:\homework\PalindromeResult.txt";
            string s = "";

            String input = File.ReadAllText(path);

            int i = 0;

            string[] result = new string[5];

            foreach (var row in input.Split('\n'))
            {
                Lesson07String pal = new Lesson07String();
                bool palindrome = pal.IsPalindrome01(row.Trim());

                if (palindrome)
                {
                    result[i] = row.Trim() + " The word is Palindrome";                                      
                }
                else
                {
                    result[i] = row.Trim() + " The word is Not Palindrome";
                }
                             
                i++;
            }

            foreach (var row in result) {
                System.IO.File.WriteAllLines(output, result.ToArray());
            }
            //Result output
            StreamReader sr = File.OpenText(output);

            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        public static void Task03()
        {
            Console.WriteLine("Type File name");
            string name = Console.ReadLine();
            string output = @"d:\homework\" + name +".txt";           

            List<string> linesToWrite = new List<string>();          
            bool exit = false;

            while (!exit) {
                Console.WriteLine("Write any word and press Enter OR type Exit");
                string word = Console.ReadLine();

                if (word == "Exit")                {
                    
                    exit = true;                    
                }
                else
                {                   
                    linesToWrite.Add(word.ToString());
                }               
            }
            System.IO.File.WriteAllLines(output, linesToWrite.ToArray());

        }

    }
}
