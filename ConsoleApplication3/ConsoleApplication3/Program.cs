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
                m = "A";
                Console.WriteLine("Biggest number is: " + m + " It is: " + x);
            }
            else if (y > x && y > z)
            {
                m = "B";
                Console.WriteLine("Biggest number is: " + m + " It is: " + y);
            }
            else if (z > y && z > x)
            {
                m = "C";
                Console.WriteLine("Biggest number is: " + m+" It is: "+z);
            }
            else
            {
                Console.WriteLine("You enter same number " + x);
            }
            Console.ReadKey();
        } 
    }
}

            