using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace COMMON.Debug
{
    class CSV1Example
    {

        [TestCaseSource("TestData")]
        public void CSVTestExample1(string name)
        {
            TestContext.WriteLine(name);
        }


        static IEnumerable<string> TestData()
        {
            using (var csv = new CsvReader(new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "TestData\\test.csv"), true))
            {
                while (csv.ReadNextRecord())
                    yield return csv["firstname"] + " " + csv["lastname"] + " " + csv["email"];
            }
        }
    }    }