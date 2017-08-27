using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("input the number");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0 )
                Console.WriteLine("{0} is a positive number", a);
            else if (a ==0)
                Console.WriteLine("you inputed number 0");
            else
                Console.WriteLine("{0} is a negative number", a);
            Console.ReadLine();
        }
    }
}
