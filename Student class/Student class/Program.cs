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
        public Student()
        {

        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public float Cgpa
        {
            set
            {
                cgpa = value;
            }
            get
            {
                return cgpa;
            }
        }
        public string Dept
        {
            set
            {
                dept = value;
            }
            get
            {
                return dept;
            }
        }
        public void show()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Cgpa : " + Cgpa);
            Console.WriteLine("Depertment : " + Dept);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "SADIK HASSAN";
            s1.Id = "18-36843-1";
            s1.Dept = "CSE";
            s1.Cgpa = 3.07f;
            s1.show();


        }
    }
}
