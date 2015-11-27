using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMax2()
        {

            int x = Convert.ToInt32("5");

            int y = Convert.ToInt32("8");

            int z = Convert.ToInt32("1");

            int max;

            max = x;

            if (y > max)
            {
                max = y;
            }
            if (z > max)
            {
                max = z;
            }

            Assert.AreEqual(8, max);
            Debug.Write("max");

            
        }
    }
}
