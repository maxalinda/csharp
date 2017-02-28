using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson06
{
    class Lesson06Class
    {
        public void PracticeWhile() {

            Console.WriteLine("Input value1");
            string a = Console.ReadLine();
            double val1 = Convert.ToDouble(a);

            Console.WriteLine("Input value2");
            string b = Console.ReadLine();
            double val2 = Convert.ToDouble(b);

             do
                {
                    Console.WriteLine("a= " + val1);
                    Console.WriteLine("b= " + val2); ;
                    val1 = val1 - 1;
                } while (val1 > val2);            
        }

        public void PracticeFor() {
            for (int i = 0; i < 11; i++) {
                Console.WriteLine(i);
            }
        }

        public void Increments() {
            int a = 1;
            Console.WriteLine("Original value " + a);
            Console.WriteLine("Post-increment a " + a++);
            Console.WriteLine("After post-increment  " + a);
            Console.WriteLine("Pre-increment a " + ++a);
            Console.WriteLine("After pre-increment  " + a);
            Console.ReadLine();
        }
        public void Task() {
            int j = 0;
            for (int i = 0; i < 20; i += 2) {               
                j++;
            }
            Console.WriteLine(j);
            Console.ReadLine();
        }

        //public void AskUser() {
        //    Console.WriteLine("Type a Int");
        //    int a = Convert.ToInt16(Console.ReadLine());
        //    Console.WriteLine("Type b Int");
        //    int b = Convert.ToInt16(Console.ReadLine());
        //}
    }
}
