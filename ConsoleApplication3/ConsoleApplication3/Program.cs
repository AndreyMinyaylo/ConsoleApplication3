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
            string m;


            if (x > y && x > z)
            {
               
                Console.WriteLine("Biggest number is: " + x);
            }
            else if (y > x && y > z)
            {
               
                Console.WriteLine("Biggest number is: " + y);
            }
            else if (z > y && z > x)
            {
               
                Console.WriteLine("Biggest number is: " +z);
            }
            else
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        } 
    }
}

            