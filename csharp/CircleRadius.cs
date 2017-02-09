using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp
{
    public class CircleRadius
    {
        static double radius, circleArea;       

        public static string CalculateCicleArea(string r, double pi) {
            Regex reg = new Regex("^[0-9].*$");
            if (!reg.IsMatch(r))
            {
                Console.WriteLine("Seems like You type wrong data type. Press Enter to continue.");
                Console.ReadLine();
                Menu.programMenu();
                return "Error type";
            }
            radius = Convert.ToDouble(r);           

            circleArea =    pi * radius * radius;
            Console.WriteLine("Area is " + circleArea);
            Console.ReadLine();
            Menu.programMenu();
            return "Done";
        }
    }
}
