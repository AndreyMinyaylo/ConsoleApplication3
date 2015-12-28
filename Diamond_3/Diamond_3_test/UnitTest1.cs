using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Diamond_3_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            var st = "    *\n" +
                     "   ***\n" +
                     "  *****\n" +
                     " *******\n" +
                     "*********\n" +
                     " *******\n" +
                     "  *****\n" +
                     "   ***\n" +
                     "    *\n";

            string sr = string.Empty;
            
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= (5 + i); j++)
                {
                    if (j <= (5 - i + 1))
                    {
                        sr = sr + " ";
                    }
                    else
                    {
                        sr = sr + "*";
                    }
                }
                sr = sr + "\n";
            }
            for (i = 1; i <= 5; i++)
            {
                /*sr = sr + " ";*/
                for (j = 10; j >= (1 + i); j--)
                {
                    if (j <= (10 - i + 1))
                    {
                        sr = sr + "*";
                    }
                    else
                    {
                        sr = sr + " ";
                    }
                }
                sr = sr + "\n";

               }
            Assert.AreEqual(st, sr);

        }
        }
    }

