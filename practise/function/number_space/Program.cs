using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_space
{
    class Program
    {    static int cal (string c)
        {
            int i,s=0;
            string c1;
            for (i=0;i< c.Length;i++)
            {
                c1 = c.Substring(i, 1);
                if (c1 == " ")
                     s = s + 1;
            }
            return s;

        }
        static void Main(string[] args)
        { string c;
            Console.WriteLine("input your string: ");            
            c = Console.ReadLine();
            Console.WriteLine(" the number of spaces in your string is " +cal(c));
            Console.ReadLine();


        }
    }
}
