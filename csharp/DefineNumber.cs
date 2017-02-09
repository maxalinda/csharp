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

        public static Boolean evenOrOdd(string myNumber) {
            Regex reg = new Regex("^[0-9]*$");
            if (!reg.IsMatch(myNumber))
            {
                Console.WriteLine("Seems like You type wrong data type. Press Enter to continue.");
                Console.ReadLine();
                Menu.programMenu();
                return false;
            }
            double myNumb = Convert.ToDouble(myNumber);
            bool isEven = DefineNumber.isEven(myNumb);

            if (isEven)
            {
                Console.WriteLine("NumberYou Type - " + myNumber + "  is EVEN.");
                Console.ReadLine();
                Menu.programMenu();
                return true;
            }
            else
            {
                Console.WriteLine("NumberYou Type - " + myNumber + "  is ODD.");
                Console.ReadLine();
                Menu.programMenu();
                return false;
                
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
