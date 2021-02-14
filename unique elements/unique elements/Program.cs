using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unique_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 10, 30, 45, 20, 60, 30, 15, 45 };
            HashSet<int> a = new HashSet<int>();
            for(int i=0;i<10;i++)
            {
                a.Add(arr[i]);
            }
            foreach (int j in a)
            {
                Console.WriteLine(j);
            }
        }
    }
}
