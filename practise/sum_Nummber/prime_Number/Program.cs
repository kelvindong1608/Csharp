using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_Number
{
    class Program
    {
        static void Main(string[] args)
        { int i, j, a, b,n;
            do
            {
                Console.WriteLine("Pls input beginning number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pls input ending number:");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (a >= b);
            Console.WriteLine("--------------");
            for (i = a; i <= b; i++)
            {
                n = 0;
                for (j = 2; j < i; j++)
                {
                    if (i == 2)
                        Console.WriteLine("2");


                    if (i % j == 0)
                        n = n + 1;
                }
                if (n == 0)
                     Console.WriteLine("{0}", i);
                n = 0;
                    
                
            };
            Console.ReadLine();
                    
            

        }
    }
}
