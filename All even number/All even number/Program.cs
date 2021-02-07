using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers :");
            for(int i=1;i<=30;i++)
            {
                if (i%2==0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();

        }
    }
}
