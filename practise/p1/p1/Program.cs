using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {   //check a number is odd or even
            int n1;
            Console.WriteLine("pls input number :");
            n1 = Convert.ToInt32(Console.ReadLine());   
            if (n1 % 2 == 0)
                Console.WriteLine("number is even");
            else Console.WriteLine("number is odd");
            Console.ReadLine();

        }
    }
}
