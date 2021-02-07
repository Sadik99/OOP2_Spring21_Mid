using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        private int x;
        private int y;
        private int z;
        public Triangle()
        {

        }
        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        public int Z
        {
            set
            {
                z = value;
            }
            get
            {
                return z;
            }
        }
        public void show()
        {
            Console.WriteLine("X = " + X);
            Console.WriteLine("Y = " + Y);
            Console.WriteLine("Z = " + Z);
           // Console.WriteLine("Depertment : " + Dept);
        }

        public void TestTriangle()
        {
            if(X==Y&&Y==Z)
            {
                Console.WriteLine("Equilateral");
            }
            else if(X==Y||Y==Z||Z==X)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            t1.X = 9;
            t1.Y = 10;
            t1.Z = 11;
            t1.show();
            t1.TestTriangle();
        }
    }
}
