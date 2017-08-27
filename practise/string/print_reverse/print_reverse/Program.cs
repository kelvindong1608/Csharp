using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_reverse
{
    class Program
    {   static string reserve (string c)
        {
            int i;
            string c1,c2="";
            for (i= c.Length-1;i>=0;i--)
            {   
                c1 = c.Substring(i, 1);
                c2 = c2 + c1;
            }
            return c2;
        }
        static void Main(string[] args)
        {
            string c;
            Console.WriteLine(" input your string :");
            c = Console.ReadLine();
            Console.WriteLine("your reverved string is :" + reserve(c));
            Console.ReadLine();


        }
    }
}
