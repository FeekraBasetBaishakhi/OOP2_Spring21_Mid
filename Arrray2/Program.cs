using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 7, 7, 6, 4, 4, 3, 3, 1 };
            foreach (int i in arr.Distinct())
            {
                Console.WriteLine(i);
            }
        }
    }
}
