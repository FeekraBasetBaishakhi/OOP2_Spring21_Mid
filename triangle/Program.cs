using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace triangle
{
    class Triangle
    {
        private int x;
        private int y;
        private int z;
        public static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(5, 8, 9);
            t2.ShowDetails();

        }
        public Triangle()
        {
            Console.WriteLine("Default Constructor");
        }
        public Triangle(int x, int y, int z)
        {

            this.x = x;
            this.y = y;
            this.z = z;
            Console.WriteLine("Parameterized Constructor");
        }
        public void ShowDetails()
        {
            if (x == y && y == z)
                Console.WriteLine("With given three side value are\n{0}\n{1}\n{2}\nSo,this is : Equilateral Triangle", x,y,z);

           
            else if (x == y || y == z || z == x)
                Console.WriteLine("With given three side value are\n{0}\n{1}\n{2}\nSo,this is : Isoceles Triangle", x,y,z);

            // Otherwise scalene triangle 
            else
                Console.WriteLine("With given three side value are\n{0}\n{1}\n{2}\nSo, this is : Scalene Triangle", x,y,z);
        }



    }
}
