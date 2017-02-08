using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Menu
    {
        public static void programMenu() {
            Console.WriteLine("Select program by entering number.");          
            Console.WriteLine("Menu:");
            Console.WriteLine("===========================================");
            Console.WriteLine("== 1. Odd or Even analizator.            ==");
            Console.WriteLine("== 2. Is Triangle right-angled debugger. ==");
            Console.WriteLine("== 3. Calculate bigger cicle area.       ==");
            Console.WriteLine("== 4. Calculate cicle area.              ==");
            Console.WriteLine("===========================================");

            int menuNumber = Convert.ToInt32(Console.ReadLine());

            programSelect(menuNumber);

        }

        public static void programSelect(int menuNumber) {
            if (menuNumber == 1)
            {
                DefineNumber.evenOrOdd();
            }
            else if (menuNumber == 2)
            {
                TriangleCalculation.isTriangleRightAngled();
            }
            else if (menuNumber == 3)
            {
                CircleArea.CalculateBiggerCicleArea();
            }
            else if (menuNumber == 4)
            {
                CircleRadius.CalculateCicleArea();
            }
            else {
                Console.WriteLine("You selected unexistance program. Press Enter to continue.");
                Console.ReadLine();
                programMenu();
            }
            
        }

    }
}
