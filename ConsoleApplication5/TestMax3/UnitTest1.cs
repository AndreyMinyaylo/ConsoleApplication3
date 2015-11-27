using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TestMax3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMax3()
        {
            int x = Convert.ToInt32("10");

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

            Assert.AreEqual(10, max);
            Debug.Write("max");
        }
    }
}
