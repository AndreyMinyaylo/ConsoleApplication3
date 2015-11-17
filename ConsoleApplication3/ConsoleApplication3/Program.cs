using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one");
            long x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two");
            long y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number three");
            long z = Convert.ToInt32(Console.ReadLine());

           if (x > y)
            {
            Console.WriteLine("Biggest number is: " + x);
            }

            else if (z > y)
            {
                Console.WriteLine("Biggest number is: " + z);
            }

            else
            { 
            Console.WriteLine("Biggest number is: " + y);
            } 
            
            Console.ReadKey();
        } 
    }
}
