using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace options_for_area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            char d;
            do
            {
                Console.WriteLine(" Option 1 :Calculate rectangular");
                Console.WriteLine(" Option 2 :Calculate square");
                Console.WriteLine(" Option 3 :Calculate circle");
                Console.WriteLine(" Pls select your option");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("Pls input the length");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Pls input the width");
                            c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("area of this rectangular is {0}", b * c);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Pls input the length");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("area of this square is {0}", b * b);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Pls input the radius");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("area of this circle is {0}", b * b * 3.14);
                            break;
                        }
                };
                Console.WriteLine("Do you want to continue Y-N");
                d = Convert.ToChar(Console.ReadLine());


            }
            while (d == 'Y' || d == 'y');
            Console.ReadLine();






                    

        }
    }
}
