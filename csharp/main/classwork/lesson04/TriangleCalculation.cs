using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp
{
    class TriangleCalculation
    {
        public Boolean isTriangleRightAngled(string a, string b, string c) {
            Regex reg = new Regex("^[0-9]*$");
            if (!reg.IsMatch(a) || !reg.IsMatch(b) || !reg.IsMatch(c))
            {
                Console.WriteLine("Seems like You type wrong data type. Press Enter to continue.");
                Console.ReadLine();
                Menu.programMenu();
                return false;
            }

            double sideA = Convert.ToDouble(a);
            double sideB = Convert.ToDouble(b);
            double sideC = Convert.ToDouble(c);


            double a2 = Math.Pow(sideA, 2);
            double b2 = Math.Pow(sideB, 2);
            double c2 = Math.Pow(sideC, 2);

            if (c2 > 0 && b2 > 0 && a2 > 0 && c2 == a2 + b2 || a2 == b2 + c2 || b2 == a2 + c2)
            {
                Console.WriteLine("Triangle is right-angled");
                Console.ReadLine();
                Menu.programMenu();
                return true;
            }
            else
            {
                Console.WriteLine("Not right-angled triagle");
                Console.ReadLine();
                Menu.programMenu();
                return false;
            }
        }
    }
}
