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
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number three");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number four");
            int q = Convert.ToInt32(Console.ReadLine());


            if (x > y && x > z&& x > q)
            {
               
                Console.WriteLine("Biggest number is: " + x);
            }
            else if (y > x && y > z && y > q)
            {
               
                Console.WriteLine("Biggest number is: " + y);
            }
            else if (z > y && z > x && z > q)
            {
               
                Console.WriteLine("Biggest number is: " +z);
            }
            else if (q > x && q > y && q > z)
            {

                Console.WriteLine("Biggest number is: " + q);
            }
            else
            {
                Console.WriteLine("Same number is: " + x);
            }
            Console.ReadKey();
        } 
    }
}

            