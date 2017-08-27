using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcome_with_x
{
    class Program
    {   static void welcome( string n)
        {
            Console.WriteLine(" Welcome to {0}", n);
        }
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("pls inout your text:");
            x = Convert.ToString(Console.ReadLine());
            welcome(x);
            Console.ReadLine();
            
        }
    }
}
