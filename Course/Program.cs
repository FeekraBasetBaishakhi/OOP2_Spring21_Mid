using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;

        public static void Main(string[] args)
        {
            Course c1 = new Course();
            Course c2 = new Course("Object Oriented Programming 2", "CSC2210", 3);
            c2.ShowDetails();

        }
        public Course()
        {
            Console.WriteLine("Default Course");
        }
        public Course(string courseName, string courseCode, int courseCredit)
        {

            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
            Console.WriteLine("Parameterized Course");
        }



    public void ShowDetails()
    {
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Course Code: " + courseCode);
        Console.WriteLine("Course Credit: " + courseCredit);
    }
}
}
