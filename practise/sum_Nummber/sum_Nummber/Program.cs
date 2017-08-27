using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_Nummber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n,s=0;
            Console.WriteLine("pls inout ten number from the keyboard");
            for (i=0;i<10;i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                s = n + s;
            }
            Console.WriteLine(" sum of 10 number is: {0}", s);
            Console.ReadLine();
        }
    }
}
