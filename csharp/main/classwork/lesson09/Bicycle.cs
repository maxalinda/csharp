using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson09
{
    class Bicycle
    {
        private int wheelSize;
        private string color;
        private int frameSize;
        private string groupSet;
        //private string type;
        //private string breakType;

        public Bicycle(int wheelSize, string color) {
            this.color = color; this.wheelSize = wheelSize;
        }

        public Bicycle(int frameSize, int wheelSize)
        {
            this.frameSize = frameSize;
            this.wheelSize = wheelSize;
        }
        public Bicycle(string groupSet, int wheelSize)
        {
            this.groupSet = groupSet;
            this.wheelSize = wheelSize;
        }

        public Bicycle(int wheelSize)
            : this()
        {
            this.wheelSize = wheelSize;
        }
        public Bicycle()
        {
            wheelSize = 26;
            color = "red";
        }
        public string Ride() {           
            Console.WriteLine("Wheelsize is " + wheelSize);
            Console.WriteLine("Group Set is " + groupSet);
            Console.WriteLine("Color is " + color);
            Console.WriteLine("Frame Size is " + frameSize    );
            Console.ReadLine();
            return "Whoohoom";
        }
    
    }
}
