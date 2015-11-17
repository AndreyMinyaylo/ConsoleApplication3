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
            string x, y, z;
            Console.WriteLine("Enter number one");
            x = Console.ReadLine();
            Console.WriteLine("Enter number two");
            y = Console.ReadLine();
            Console.WriteLine("Enter number three");
            z = Console.ReadLine();

            int q = Convert.ToInt32(x);
            int w = Convert.ToInt32(y);
            int e = Convert.ToInt32(z);
            int m;

            if (q > w)
            {
                m = q;
                Console.WriteLine("Biggest number is: " + x);
            }

            else if (e > w)
            {

                m = e;
                Console.WriteLine("Biggest number is: " + z);
            }

            else
            { 
                m = w;
            Console.WriteLine("Biggest number is: " + y);
            } 
                
            
            

            Console.ReadKey();
        } 
    }
}
