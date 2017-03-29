using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson07
{
    class StringLesson
    {
        string myResult;

        public void Practise01()
        {
            char[] charArray = { 'F', 'r', 'i', 'd', 'a', 'y' };
          
            foreach (char c in charArray)
            {
                myResult += c;
            }
            Console.WriteLine(myResult);
            Console.ReadLine();
        }

        public Boolean IsPalindrome(string s) {
            string lower = s.ToLower();
            int k = lower.Length - 1;
            int l = lower.Length;

            for (int i = 0; i < l/2; i++) {
                if (lower[i] == lower[k])
                {
                    k--;
                }
                else return false;
            }
            return true;
        }

        public void StringToInt() {
            string before = "89";
            Console.WriteLine(before.GetType() + " " + before);            

            int c = Convert.ToInt16(before);
            Console.WriteLine(c.GetType() + " " + c);           

            string after = Convert.ToString(c);
            Console.WriteLine(after.GetType() + " " + after);
            Console.ReadLine();

        }

        public void StringToDouble()
        {
            string before = "8998.98";
            Console.WriteLine(before.GetType() + " " + before);

            double c = Convert.ToDouble(before);
            Console.WriteLine(c.GetType() + " " + c);

            string after = Convert.ToString(c);
            Console.WriteLine(after.GetType() + " " + after);
            Console.ReadLine();

        }

        public void StringToLong()
        {
            string before = "89986465645";
            Console.WriteLine(before.GetType() + " " + before);

            long c = Convert.ToInt64(before);
            Console.WriteLine(c.GetType() + " " + c);

            string after = Convert.ToString(c);
            Console.WriteLine(after.GetType() + " " + after);
            Console.ReadLine();

        }

        public void StringToBoolean()
        {
            string before = "true";
            Console.WriteLine(before.GetType() + " " + before);

            bool c = Convert.ToBoolean(before);
            Console.WriteLine(c.GetType() + " " + c);

            string after = Convert.ToString(c);
            Console.WriteLine(after.GetType() + " " + after);
            Console.ReadLine();

        }



    }
}
