using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp
{
    class DefineNumber
    {

        public static string evenOrOdd(string myNumber) {
            Regex reg = new Regex("^[0-9]*$");
            if (!reg.IsMatch(myNumber))
            {               
                return "WrongData";
            }
            double myNumb = Convert.ToDouble(myNumber);
            bool isEven = DefineNumber.isEven(myNumb);

            if (isEven)
            {              
                return "isEven";
            }
            else
            {              
                return "isOdd";                
            }
           
        }

        public static bool isEven(double val)
        {
            if ((int)val / 2 == (double)val / 2)
            {
                return true;
            }
            else return false;
        }
    }
}
