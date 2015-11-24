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
            
            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("Biggest number is: " + x);
                }
            }
            if (y > x)
            {
                if (y > z)
                {
                    Console.WriteLine("Biggest number is: " + y);
                }
                
            }
            if (z > x)
            {
                if (z > x)
                {
                    Console.WriteLine("Biggest number is: " + z);
                }
            }
            Console.ReadKey();
        } 
    }
}

            