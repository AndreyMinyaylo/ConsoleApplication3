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

            if (x == y && x == z && y == z)
            {
                Console.WriteLine("You enter same number " + x);
            }

            else if (x == z&&x!=y)
            {
                Console.WriteLine("You enter twice: A and C ");
                Console.WriteLine("Biggest number is: " + x);
            }
            else if (y == z&&y!=x)
            {
                Console.WriteLine("You enter twice: B and C ");
                Console.WriteLine("Biggest number is: " + y);
            }
            else if (x == y && x != z)
            {
                Console.WriteLine("You enter twice: A and B");
                Console.WriteLine("Biggest number is: " + x);
            }
        
            


            
                     
            Console.ReadKey();
        } 
    }
}

            