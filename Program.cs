using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrical Engineering", "EE");
            Student s1 = new Student("Feekra Baset", "s39010", 3.39f);
            s1.Department = d2;
            s1.ShowInfo();
            s1.Department = d1;
            d1.Name = "Computer Science and Engineering";
            d1.Id = "CSE";
            s1.ShowInfo();
            //Console.WriteLine(s1.Department.Id);
        }
    }
}
