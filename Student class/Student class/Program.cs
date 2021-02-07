using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_class
{
    public class Student
    {
        private string name;
        private string id;
        private string dept;
        private float cgpa;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name = "SADIK HASSAN";
            s1.id = "18-36843-1";
            s1.dept = "CSE";
            s1.cgpa = 3.07f;


        }
    }
}
