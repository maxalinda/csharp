using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class TriangleCalculation
    {
        public static void isTriangleRightAngled() {
            Console.Clear();
            Console.WriteLine("Enter side A ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side C ");
            double sideC = Convert.ToDouble(Console.ReadLine());


            double a2 = Math.Pow(sideA, 2);
            double b2 = Math.Pow(sideB, 2);
            double c2 = Math.Pow(sideC, 2);

            if (c2 > 0 && b2 > 0 && a2 > 0 &&  c2 == a2 + b2 || a2 == b2 + c2 || b2 == a2 + c2) {
                Console.WriteLine("Triangle is right-angled");
            }
            else {
                Console.WriteLine("Not right-angled triagle");
            }
            Console.ReadLine();
        }
    }
}
