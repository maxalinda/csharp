using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson06
{
    class Lesson06Homework
    {
        public void Task01()
        {
            int[] array = new int[10];
            int j = 0;

            for (int i = 2; i <= 20; i += 2)
            {
                array[j] = i;
                Console.Write(array[j] + " ");
                j++;

            }
            j = 0;
            Console.WriteLine();
            for (int i = 2; i <= 20; i += 2)
            {
                array[j] = i;
                Console.WriteLine(array[j]);
                j++;
            }

            Console.ReadLine();
        }

        public void Task02()
        {
            int[] array = new int[50];
            int j = 0;

            for (int i = 1; i <= 99; i += 2)
            {
                array[j] = i;
                Console.Write(array[j] + " ");
                j++;
            }
            Console.WriteLine();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }

        public void Task03()
        {
            double[] array = new double[15];
            Random r = new Random();
            int evenNumber = 0;

            for (int i = 0; i <= 14; i++)
            {
                array[i] = r.Next(0, 9);
                Console.Write(array[i] + " ");
            }

            foreach (double arrayElement in array) {
               bool numberIsEven = DefineNumber.isEven(arrayElement);
                if (numberIsEven) {
                    evenNumber++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Count of Even numbers in array is " + evenNumber);
            Console.ReadLine();
        }

        public void Task04() {
            int[] array = new int[15];
            Random r = new Random();

            for (int i = 0; i <= 14; i++)
            {

                array[i] = r.Next(0, 999);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("The biggest number in array is " + array.Max());
            Console.WriteLine("The smallest number in array is " + array.Min());
            Console.ReadLine();
        }
    }
}
