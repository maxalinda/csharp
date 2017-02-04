using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class PrimitiveConvector
    {

        public char floatToChar(float myFloat)
        {
            char myChar = '!';
            myChar = (char)myFloat;
            return myChar;
        }

        public char intToChar(int myInt)
        {
            char myChar = '^';
            myChar = (char)myInt;
            return myChar;

        }

        public int charToInt(char myChar)
        {
            int myInt = 1488;
            myInt = (int)myChar;
            return myInt;
        }

        public int doubleToInt(double myDouble)
        {
            int myInt = 9090;
            myInt = (int)myDouble;
            return myInt;
        }
    }
}
