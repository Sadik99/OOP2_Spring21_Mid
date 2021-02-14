using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 40, 30, 20, 17, 10, 34, 40,50,50,70,65,33,10,20,30,45,33 };
            int[] ar = new int[100];
            HashSet<int> xx = new HashSet<int>();
            for (int i=0;i<arr.Length;i++)
            {
                xx.Add(arr[i]);
                ar[arr[i]]++;
            }
            foreach(int x in xx)
            {
                Console.WriteLine(x + " occours " + ar[x] + " times.");
            }

        }
    }
}
