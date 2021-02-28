using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask5
{
    class Program
    {
        static void Main(string[] args)
        {
            department d1 = new department("Electrical engineering", "EE");
            department d2 = new department("Computer science", "CS");
            student s1 = new student("Feekra", "39010", 3.3f);
            student s2 = new student("Baset", "3222123", 3.39f);
            student s3 = new student("Baishakhi", "3333123", 3.9f);
            d1.AddStudents(s1, s2, s3);
            s1.Department = d1;
            s2.Department = d1;
            s3.Department = d1;
            s1.Department.ShowInfo();

            d2.AddStudents(s3);

            d1.AllStudents();
            Console.WriteLine("**********");
            d2.AllStudents();

        }
    }
}