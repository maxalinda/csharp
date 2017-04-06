using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Pixel
    {
        private int x;
        private int y;

        public Pixel(int x, int y) {
            this.x = x;
            this.y = y;
        }  

        public int[] getCoords() {
            int[] res = new int[] { x, y };
            return res;
        }
    }
}
