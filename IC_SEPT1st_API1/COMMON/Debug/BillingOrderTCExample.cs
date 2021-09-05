﻿using COMMON.Models;
using LumenWorks.Framework.IO.Csv;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace COMMON.Debug
{
    class BillingOrderTCExample
    {
        [TestCaseSource("TestData")]
        public void CSVTestExample5(BillingOrder order)
        {
            TestContext.WriteLine(order.FirstName);
            TestContext.WriteLine(order.LastName);
            TestContext.WriteLine(order.Email);
        }


        static IEnumerable<TestCaseData> TestData()
        {
            using (var csv = new CsvReader(new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "TestData\\test.csv"), true))
            {
                while (csv.ReadNextRecord())
                {
                    BillingOrder order =
                        new BillingOrder(firstName: csv["firstname"],
                        lastName: csv["lastname"], email: csv["email"]);

                    yield return new TestCaseData(order).SetName(csv["TCname"]);
                }
            }
}   }    }