using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace COMMON.Debug
{
    class CSV2Example
    {
        class CSVExample
        {
            [TestCaseSource("TestData")]
            public void CSVTestExample(string name)
            {
                TestContext.WriteLine(name);
            }


            static IEnumerable<string> TestData()
            {
                string filename = "TestData\\test.csv";
                string currentDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                string completePath = currentDir + filename;

                using (var reader = new CsvReader(new StreamReader(completePath), false))
                {
                    while (reader.ReadNextRecord())
                        yield return reader[0]+"  " + reader [1];
                }
            }
}   }   } 
