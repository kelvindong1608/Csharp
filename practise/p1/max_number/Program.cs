using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("input the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                if (b < c)
                    Console.WriteLine("max is {0}", c);
                else
                    Console.WriteLine("max is {0}", b);
            }
            else
            {
                if (a>c)
                    Console.WriteLine("max is {0}", a);
                else
                    Console.WriteLine("max is {0}", c);
            }
            Console.ReadLine();



        }
    }
}
