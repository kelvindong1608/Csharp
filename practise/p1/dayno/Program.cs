using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayno
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            do
            {
                Console.WriteLine(" pls input your number:");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine(" it is Monday");
                        break;
                    case 2:
                        Console.WriteLine(" it is Tuesday");
                        break;
                    case 3:
                        Console.WriteLine(" it is Wednesday");
                        break;
                    case 4:
                        Console.WriteLine(" it is Thursday");
                        break;
                    case 5:
                        Console.WriteLine(" it is Friday");
                        break;
                    case 6:
                        Console.WriteLine(" it is Saturday");
                        break;
                    case 7:
                        Console.WriteLine(" it is Sunday");
                        break;
                    default:
                        Console.WriteLine(" your number is incorrect");
                        break;

                }

                Console.WriteLine("Do you want to continue: 1-Yes or 2-No");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b ==1);
            Console.ReadLine();

        }
    }
}
