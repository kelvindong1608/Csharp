using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime b = DateTime.Now;
            int[,] a =
                {
                { 3,6,2,5},
                {0,4,5,2 },
                {3,6,1,3 }
            };
            for (int i=0; i<3;i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.WriteLine("Element a[{0}][{1}] = {2}", i, j, a[i, j]);
                Console.WriteLine("---------");
            
            }
            Console.WriteLine(" now is {0}", b);
            Console.WriteLine(" sqare root of 35 is {0}", Math.Round(Math.Sqrt(35), 2));
            Console.WriteLine(" sqare root of 35 is {0}",Math.Sqrt(35));
            Console.ReadLine();
        }
    }
}
