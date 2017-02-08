using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class DefineNumber
    {

        public static void evenOrOdd() {
            Console.Clear();
            Console.WriteLine("Type any Integer Number ");
            double myNumber = Convert.ToDouble(Console.ReadLine());
            bool isEven = DefineNumber.isEven(myNumber);

            if (isEven)
            {
                Console.WriteLine("NumberYou Type - " + myNumber + "  is EVEN.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("NumberYou Type - " + myNumber + "  is ODD.");
                Console.ReadLine();
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
