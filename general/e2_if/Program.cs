using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e2_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine(" pls input your age: \n");
            string a1 = Console.ReadLine();
            age = System.Convert.ToInt32(a1);
            /* age =Int32.Parse(a1);*/
            if (age < 0)
                Console.WriteLine(" ur data was wrong");
            else if (age < 18)
                Console.WriteLine("u r young");
            else
                Console.WriteLine("u r old");
            Console.ReadLine();


      
        }
    }
}
