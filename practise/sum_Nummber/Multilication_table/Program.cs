using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Multiplication table");
            Console.WriteLine("_____________________");
            for (i = 2; i < 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
                Console.WriteLine("___________");

            }
            Console.ReadLine();
                   
        }
    }
}
