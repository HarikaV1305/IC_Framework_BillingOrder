using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMMON.Debug
{
    class Drivern
    {
        [TestCase(1, 0, 1)]
        [TestCase(-1, -1, -2)]
        [TestCase(-1000, 4, -996)]
        public void SubTest(int n, int d, int output)
        {
            int input = n + d;
            Assert.AreEqual(output, input);
        }

        //Data driven using test data as source 

        [TestCaseSource("TestData")]
        public void AddTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n + d);
        }



        static object[] TestData =
        {
            new object[] { 12, 3, 15 },
            new object[] { 12, 2, 14 },
            new object[] { 12, 4, 16 },
            new object[] { 12, 14, 26}
        };
    }
}
