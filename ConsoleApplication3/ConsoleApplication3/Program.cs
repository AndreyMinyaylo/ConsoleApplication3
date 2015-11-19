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

            if (x == y && y == z || x == z)
            {
                Console.WriteLine("You enter same number " + x);
            }
            else if(y == z || y == x)
            {
                Console.WriteLine("You enter same number " + y);
            }

            else if (x > y&&x > z) 
            {
                /*string x = Convert.ToString("A");*/
                m = "A";
            Console.WriteLine("Biggest number is: " + m );
            }

            else if (z > y&&z > y)
            {
                m = "C";
                Console.WriteLine("Biggest number is: " + m);
            }

            else
            {
                m = "B";
            Console.WriteLine("Biggest number is: "  + m);
            } 
           
            
            Console.ReadKey();
        } 
    }
}

