using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp
{
    class CircleArea
    {
        public const double PI = 3.14d;

        public static String CalculateBiggerCicleArea(string r1, string r2) {
            Regex reg = new Regex("^[0-9].*$");
            if (!reg.IsMatch(r1) || !reg.IsMatch(r2))
            {
                Console.WriteLine("Seems like You type wrong data type. Press Enter to continue.");
                Console.ReadLine();
                Menu.programMenu();
                return "Error type";               
            }

            double r1Double = Convert.ToDouble(r1);
            double r2Double = Convert.ToDouble(r2);

            double area1 = PI * r1Double * r1Double;
            double area2 = PI * r2Double * r2Double;

            if (area1 > area2)
            {
                Console.WriteLine("Area1 is bigger");
                Console.ReadLine();
                Menu.programMenu();
                return "Area1";
            }
            else if (area1 == area2) {
                Console.WriteLine("Area1 is equal to Area2");
                Console.ReadLine();
                Menu.programMenu();
                return "Areas are equal";
            }
            else {
                Console.WriteLine("Area2 is bigger");
                Console.ReadLine();
                Menu.programMenu();
                return "Area2";
            }
        }
    }
}
