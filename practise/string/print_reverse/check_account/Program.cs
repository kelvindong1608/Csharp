using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_account
{
    class Program
    {   static void check (string u, string p)
        {
            int n = 2;
                    
            
                do
                {
                   /* Console.WriteLine("pls input the right username and password :");*/
                    Console.WriteLine(" pls input your username");
                    u = Console.ReadLine();
                    Console.WriteLine(" pls input your password");
                    p = Console.ReadLine();
                    n = n + 1;
                if (u == "kelvin" & p == "123")
                    Console.WriteLine(" you entered correctly");

                if (n > 3)
                    Console.WriteLine(" you have wrongly inputted so many times. Your account is currently locked!!");
            }
                while ((u != "kelvin" || p != "123") & n <= 3);
            
            


        }
        static void Main(string[] args)
        {
            string u, p;
            Console.WriteLine(" your username is kelvin");
            Console.WriteLine(" your password is 123");
            Console.WriteLine(" pls input your username");
            u = Console.ReadLine();
            Console.WriteLine(" pls input your password");
            p = Console.ReadLine();
            check(u, p);
            Console.ReadLine();

        }
    }
}
