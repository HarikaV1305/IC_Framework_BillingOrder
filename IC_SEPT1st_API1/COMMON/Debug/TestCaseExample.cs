using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace COMMON.Debug
{
    class TestCaseExample
    {
        class TestCaseDataExample
        {
            [TestCaseSource("TD")]
            public int SumTest(int num1, int num2)
            {
                return num1 + num2;

            }
            public static IEnumerable TD
            {
                get
                {
                    yield return new TestCaseData(12, 3).Returns(15);
                    yield return new TestCaseData(12, 2).Returns(14);
                    yield return new TestCaseData(12, 4).Returns(16);
                }
            }
        }
    }
}
