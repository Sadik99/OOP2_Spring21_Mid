using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assosiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Depertment d1 = new Depertment("Computer science", "CS");
            Depertment d2 = new Depertment("Electrical Eng.", "EEE");
          //  Depertment d3 = new Depertment("", "");
            Student s1 = new Student("Sadik hassan", "1234", 3.07f);
            Student s2 = new Student("Karim khan", "3434", 3.55f);
            s1.Depertment = d1;
            s2.Depertment = d2;
            s1.show();
            s2.show();
           

        }
    }
}
