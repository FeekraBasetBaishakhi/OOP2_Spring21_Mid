using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class labtask
{ }
namespace EvenOddProblem
{
    class Even
    {
        static void Main()
        {
            int sumEven = 0, sumOdd = 0;

            for (int i = 1; i <= 100; i++)
            {

                if (i % 2 == 0)
                {
                    sumEven += i;
                }
                else
                {
                    sumOdd += i;
                }
            }

            Console.Write("Even Sum: {0}\n Odd Sum: {1}", sumEven, sumOdd);
            Console.Read();
        }
    }


    }