using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Line
    {
        public Pixel[] point = new Pixel[2];

        public Line(Pixel point0, Pixel point1) {
            this.point[0] = point0;
            this.point[1] = point1;
        }

        public void AddPixel(Pixel pix) {
            int l = point.Length;
            Pixel[] newPoint = new Pixel[l + 1];

            for (int i = 0; i < l; i++) {
                newPoint[i] = point[i];
            }
            newPoint[l] = pix;
            point = newPoint;            
        }
        public int GetSize() {
            return point.Length;
        }
    }
}
