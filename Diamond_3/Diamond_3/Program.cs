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
            for (i = 1; i <= 5; i++)
            {
                for(j = 1; j <= (5 + i); j++)
                {
                    if(j <= (5 - i + 1))
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
            for (i = 1; i <= 10; i++)
            {
                /*for (j = 20; j >= (1 + i); j--)
                {
                    if (j <= (20 - i + 1))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");*/
                Console.Write(" ");

                for (j = 10; j >= (1 + i); j--)
                {
                    if (j <= (10 - i + 1))
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



     