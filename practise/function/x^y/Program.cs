using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_y
{
    class Program
    {   static int cal ( int a, int b)
        { int i,s=1;
          for (i=1; i<=b;i++)
            {
                s = s * a;
            }
          return s;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("input x:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input y:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" {0}^{1} is " + cal(a, b), a,b);
            Console.ReadLine();

        }
    }
}
