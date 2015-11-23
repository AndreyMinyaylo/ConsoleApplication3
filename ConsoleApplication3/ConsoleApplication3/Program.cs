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
            string m1,m2,m3;


            if (x == y && x == z && y == z)
            {
                Console.WriteLine("You enter same number " + x);
            }

            else if (x == z)
            {
                Console.WriteLine("You enter twice: A and C ");
            }
            else if (y == z)
            {
                Console.WriteLine("You enter twice: B and C ");
            }
            else if (x == y)
            {
                Console.WriteLine("You enter twice: A and B");
            }


            else if (x > y&&x > z) 
            {
              m1 = "A";
            Console.WriteLine("Biggest number is: " + m1 );
            }

            else if (z > y&&z > x)
            {
                m3 = "C";
                Console.WriteLine("Biggest number is: " + m3);
            }

            else if (y>x&&y>z)
            {
                m2 = "B";
            Console.WriteLine("Biggest number is: "  + m2);
            }
            
            
            Console.ReadKey();
        } 
    }
}

            