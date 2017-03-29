using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson07
{
    class Lesson07String
    {
        public Boolean IsPalindrome01(string s)
        {
            string lower = s.ToLower();
            int k = lower.Length - 1;
            int l = lower.Length;

            for (int i = 0; i < l / 2; i++)
            {
                if (lower[i] == lower[k])
                {
                    k--;
                }
                else return false;
            }
            return true;
        }

        public Boolean IsPalindrome02(string s)
        {
            char[] charArray = s.ToLower().ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);          

            if (s.ToLower().SequenceEqual(reverse)) return true;
            else return false;           
        }

        public Boolean IsPalindrome03(string myString) {
            return myString.ToLower().SequenceEqual(myString.ToLower().Reverse());
        }
    }
}
