using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_letter
{
    class Program
    {   static void check(char c)
        {
            if (Char.IsLetter(c))
            {
                if (Char.IsUpper(c))
                    Console.WriteLine(" char is upper");
                else
                    Console.WriteLine("char is lower");

            }
            else
                Console.WriteLine("you do not input the propper char");
        }
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Pls input the propper char: ");
            c = Convert.ToChar(Console.ReadLine());
            check(c);
            Console.ReadLine();
        }
    }
}
