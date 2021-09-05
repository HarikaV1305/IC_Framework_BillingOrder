using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMMON.Debug
{
    class LoopsExample
    {

        [TestCaseSource("TestData")]
        public void CSVTestExample(string name)
        {
            TestContext.WriteLine(name);
        }


        static IEnumerable<string> TestData()
        {
            for (int i = 0; i <= 10; i++)
                yield return "Test " + i;
        }
    }
}
