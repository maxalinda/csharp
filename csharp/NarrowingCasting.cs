using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class NarrowingCasting
    {
        int int1 = 127;
        float float1 = 3.14159F;

        public void Narrowing() {
            int1 = (int) float1;  
            Console.WriteLine(int1);
        }

    }
}
