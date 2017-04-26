using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Result
    {
        public void DrawLine() {
            Pixel pixel0 = new Pixel(2, 5);
            Pixel pixel1 = new Pixel(6, 8);
            Line line = new Line(pixel0, pixel1);

            Console.WriteLine("Array Size  " + line.GetSize());

            Pixel pixel3 = new Pixel(2, 8);

            line.AddPixel(pixel3);

            Console.WriteLine("Array Size " + line.GetSize());

            Console.ReadLine();
        }
    }
}
