using COMMON.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WEBautomation.Framework;
using WEBautomation.Page;

namespace WEBautomation.Tests
{
    class BillingOrderTests: BaseTest
    {
        
        [Test]

        public void CreateBillingOrderTest()
        {
            driver.Url = ("https://qaauto.co.nz/billing-order-form/");            
            BillingOrderPage orderpage = new BillingOrderPage(driver );
            orderpage.Login();
            orderpage.FirstName("harikaa");
            orderpage.LastName("sweeetie");

            
        }

               
        [Test]
        public void ModelCreateBillingOrder()
        {
            BillingOrder orderobject = new BillingOrder(email :"");            
            driver.Url = "https://qaauto.co.nz/billing-order-form/";
            BillingOrderPage modelpage = new BillingOrderPage(driver);
            {
                modelpage.Login();
                modelpage.FillForm (orderobject);
                modelpage.Submit();

            }

        }
    }

}
