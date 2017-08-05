using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e3_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12,13,14,15};
            Console.WriteLine("element count of array {0}: ", a.Length);
            for(int i=0; i< a.Length; i++)
            {
                Console.WriteLine(" Element at {0} is {1}", i, a[i]);
            }
            Console.ReadLine();
        }
    }
}
