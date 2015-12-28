using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= (5 + i); j++)
                {
                    
                    if (j <= (5 - i + 1 ))
                    {
                        Console.Write(" ");
                       
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
            for (i = 1; i <= 4; i++)
            {

                Console.Write(" ");

                for (j = 9; j >= (1 + i); j--)
                {
                    
                    if (j <= (9 - i  ))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");

            }

            Console.ReadKey();
        }
    }
}



