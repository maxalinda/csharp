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

        public static double CalculateCicleArea(string r, double pi) {
            Regex reg = new Regex("^[0-9]([.][0-9]{1,3})?$");
            if (!reg.IsMatch(r))
            {               
                return 1.0403;
            }
            radius = Convert.ToDouble(r);           

            circleArea =    pi * radius * radius;            
            return circleArea;
        }
    }
}
