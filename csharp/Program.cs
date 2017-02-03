using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Program
    {
        static void Main(string[] args){

            WideningCasting wideningCasting = new WideningCasting();
            wideningCasting.Conversion();
            Console.ReadLine();

            NarrowingCasting narrowingCasting = new NarrowingCasting();
            narrowingCasting.Narrowing();
            Console.ReadLine();        
        }
    }
}
