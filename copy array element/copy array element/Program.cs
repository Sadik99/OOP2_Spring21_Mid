using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_array_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr2 = new int[] { 10, 20, 30, 40, 50 };
            for(int i=0;i<5;i++)
            {
                arr[i] = arr2[i];
            }
            Console.WriteLine("After copying values from arr2 to arr : ");
            for(int i=0;i<5;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
