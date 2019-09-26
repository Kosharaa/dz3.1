using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arrCopy = new int[10];


            int countMin = arr.Length;
            int countMax = arrCopy.Length;
            if (countMin > countMax)
            {
                (countMin, countMax) = (countMax, countMin);
                (arr, arrCopy) = (arrCopy, arr);
            }
            int index = (countMax - countMin) / 2;
            Array.Copy(arr, 0, arrCopy, index, countMin);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arrCopy.Length; i++)
            {
                Console.WriteLine(arrCopy[i]);
            }
            Console.ReadKey();
        }
    }
}
