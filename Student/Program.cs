using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask
{
    internal class Student
    {
        string name;
        int id;
        string depertment;
        float cgpa;

        public static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Feekra Baset Baishakhi",18390103,"CSE",3.39f );
            s2.ShowDetails();

        }
        public Student()
        {
            Console.WriteLine("Default Constructor");
        }
        public Student(string name,int id,string depertment,float cgpa)
        {
            Console.WriteLine("Parameterized Constructor");
            this.name = name;
            this.id = id;
            this.depertment = depertment;
            this.cgpa = cgpa;
        }
       
       
        
        public void ShowDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Depertment: " + depertment);
            Console.WriteLine("cgpa: " + cgpa);



        } 
 
    
    
    }
        }
 