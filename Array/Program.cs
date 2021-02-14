using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr
{
    class Program
    {
        static void Main(string[] s)

        {
            Console.WriteLine("Original Array:");
            int[] arr1 = new int[] { 1, 2 };
            int[] arr2 = new int[2];
            foreach (int value in arr1)
            {
                Console.WriteLine(value);
            }

            Array.Copy(arr1, arr2, 2);

            Console.WriteLine("Copied Array:");
            foreach (int value in arr2)
            {
                Console.WriteLine(value);
            }

            int[] array = { 2, 2, 2, 6, 7 };
            int count = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {

                    if (array[j] == array[j + 1])
                        count = count + 1;
                }
                Console.WriteLine("Number:" + array[i] + " Duplicated=" + count + "times");
                Console.ReadLine();
            }
        }
    }
}
