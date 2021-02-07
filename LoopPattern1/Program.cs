using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPattern1
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = 5, m = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write( i + j + 1);


                }
                Console.Write("\n");

            }
           Console.Read ();
        }

    }
}
