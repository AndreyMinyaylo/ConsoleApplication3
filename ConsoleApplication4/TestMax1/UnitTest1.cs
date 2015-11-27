using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace TestMax1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMax1()
        {
            int x = Convert.ToInt32("1");
            int y = Convert.ToInt32("2");
            int z = Convert.ToInt32("3");

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
            Assert.AreEqual(3, max);
            Debug.Write("max");

        }
    }
}
