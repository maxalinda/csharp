using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class CircleArea
    {
        public const double PI = 3.14d;

        public static void CalculateBiggerCicleArea() {
            Console.Clear();
            Console.WriteLine("Enter radius 1 ");
            string r1 = Console.ReadLine();

            Console.WriteLine("Enter radius 2 ");
            string r2 = Console.ReadLine();

            double r1Double = Convert.ToDouble(r1);
            double r2Double = Convert.ToDouble(r2);

            double area1 = PI * r1Double * r1Double;
            double area2 = PI * r2Double * r2Double;

            if (area1 > area2)
            {
                Console.WriteLine("Area1 is bigger");
            }
            else if (area1 == area2) {
                Console.WriteLine("Area1 is equal to Area2");
            }
            else {
                Console.WriteLine("Area2 is bigger");
            }
        }
    }
}
