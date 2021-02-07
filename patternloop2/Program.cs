using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternloop2
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = 4;
            int m = 6;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 == 0)
                    {

                        Console.Write("X");
                    }

                    else
                    {
                        Console.Write("O");
                    }

                }
                Console.Write("\n");


            }
            Console.Read();
        }
    }
}
