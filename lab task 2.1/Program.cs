using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_task_2._1 { 
private class Student
{
        string name;
        string id;
        string depertment;
        float cgpa;

public void Setname (string name)
        {
            this.name = name;
        }   
        
   internal void ShowDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " +id);
            Console.WriteLine("depertment: " + depertment);
            Console.WriteLine("CGPA: " + cgpa);
        }
    {
        
    }
}
}