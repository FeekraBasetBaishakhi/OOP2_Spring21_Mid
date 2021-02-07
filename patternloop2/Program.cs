using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter marks physics: \n");
            Console.Read(); ;
            Console.WriteLine();
            Console.Write("Enter marks chemistry: \n");
            Console.Read();
            Console.WriteLine();
            Console.Write("Enter marks Biology: \n");
            Console.Read();
            Console.WriteLine();
            Console.Write("Enter marks Mathematics: \n ");
            Console.Read();
            Console.WriteLine();
            Console.Write("Enter marks Computer: \n ");
            Console.Read();
            Console.WriteLine();

            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 90)
            {
                Console.WriteLine("A+");
            }
            else if (marks >= 85 && marks < 89)
            {
                Console.WriteLine("A");
            }
            else if (marks >= 80 && marks < 84)
            {
                Console.WriteLine("B+");
            }
            else if (marks >= 75 && marks < 79)
            {
                Console.WriteLine("B");
            }

            else if (marks <= 50)
            {
                Console.WriteLine("F");
            }

            else
            {
                Console.WriteLine();
            }
        }
    }
}