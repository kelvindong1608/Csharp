using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delta
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,n;
            Console.WriteLine("pls input the number of lines: \n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
            Console.ReadLine();
        }
    }
}
