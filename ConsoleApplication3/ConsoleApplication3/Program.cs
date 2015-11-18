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

           if (x > y&&x > z) 
            {
            Console.WriteLine("Biggest number is: " + x);
            }

            else if (z > y&&z > y)
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
