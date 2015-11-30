using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnit2
{
    public class Class1
    {

        public void TestMax2()
        {
            int x = Convert.ToInt32("5");
            int y = Convert.ToInt32("8");
            int z = Convert.ToInt32("7");

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
