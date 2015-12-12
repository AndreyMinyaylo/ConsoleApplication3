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
            int  i, j;
            for (i = 1; i <= 10; i++)
            {
                for(j = 1; j <= (10 + i); j++)
                {
                    if(j <= (10 - i + 1))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\r\n");
            }

                Console.ReadKey();
            }
        }
    }



     