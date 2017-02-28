using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson06
{
    class ArrayLesson
    {


    int[][] intArray1 = new int[2][];

    public void Jadged() {
            for (int j = 0; j < intArray1.Length; j++)
            {
                intArray1[j] = new int[3];
                for (int k = 0; k < intArray1[j].Length; k++) {
                    intArray1[j][k] = (j + 1) * (k + 1);
                    Console.Write(intArray1[j][k] + " ");
                }
                Console.WriteLine();
            }

        }

        public void Multi() {
            int[,] arr = new int[4, 3];

            if (arr.Rank > 1)
            {

                for (int dim = 0; dim < arr.Rank; dim++)
                    Console.WriteLine("Dimension {0}: {1}",
                    dim, arr.GetLength(dim));

            }
        }

        int[] intArray = { 1, 2, 3 };
        public void IntArray() {
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }        
        }

        bool[] boolArray = { true, false, false };
        public void BoolArray()
        {
            for (int i = 0; i < boolArray.Length; i++)
            {
                Console.WriteLine(boolArray[i]);
            }
        }

        char[] charArray = { '2', 't', '!' };
        public void CharArray()
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }
        }

        double[] doubleArray = { 3.678, 4.8908, 5.8965 };
        public void DoubleArray()
        {
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }
        }

        long[] longArray = { 12L, 67L, 43L };
        public void LongArray()
        {
            for (int i = 0; i < longArray.Length; i++)
            {
                Console.WriteLine(longArray[i]);
            }
        }

      
    }
}
