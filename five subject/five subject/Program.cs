using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_subject
{
    class Program
    {
        static void Main(string[] args)
        {
            int phy=62, che=83, bio=93, math=89, com=71;
            double sum = phy + che + bio + math + com;
            Console.WriteLine("percentage is " + sum / 5.0 +"%");

        }
    }
}
