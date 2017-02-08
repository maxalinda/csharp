using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class CircleRadius
    {
        static double radius, pi, circleArea;       

        public static void CalculateCicleArea() {
            Console.Clear();
            Console.WriteLine("Type radius value: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type pi value: ");
            pi = Convert.ToDouble(Console.ReadLine());

            circleArea =    pi * radius * radius;
            Console.WriteLine("Area is " + circleArea);
            Console.ReadLine();
        }
    }
}
