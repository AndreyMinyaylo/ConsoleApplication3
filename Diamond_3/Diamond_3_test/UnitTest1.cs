using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Diamond_3_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var st = "  *'\n'" +
                     " ***'\n'" + 
                     "*****'\n'" +
                     " ***'\n'" +
                     "  *'\n'";

            string sr = string.Empty;

            int i, j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= (10 + i); j++)
                {
                    if (j <= (10 - i + 1))
                    {
                        sr = sr + " ";
                    }
                    else
                    {
                        sr = sr + "*";
                    }
                }
                /*sr = sr + "\n";*/
            }
        }
    }
}
