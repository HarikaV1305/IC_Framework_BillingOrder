using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace WEBautomation.Framework
{
    public class BaseTest
    {
        public IWebDriver driver;
        

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
        //[Test]
        // public void BillingOrder2()
        // {
        //     driver.Navigate().GoToUrl("https://qaauto.co.nz/billing-order-form/");
        //     driver.Manage().Window.Size = new System.Drawing.Size(945, 1020);
        //     driver.FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).Click();
        //     driver.FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).SendKeys("Testing");
        //     driver.FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).SendKeys(Keys.Enter);
        //     driver.FindElement(By.Id("wpforms-24-field_0")).SendKeys("harika");
        //     driver.FindElement(By.Id("wpforms-24-field_0-last")).SendKeys("v");
        //     driver.FindElement(By.Id("wpforms-24-field_1")).SendKeys("harika.vadaganadham@gmail.com");
        //     driver.FindElement(By.Id("wpforms-24-field_2")).SendKeys("(022) 075-5780");
        //     driver.FindElement(By.Id("wpforms-24-field_3")).SendKeys("titirangi");
        //     driver.FindElement(By.Id("wpforms-24-field_3-city")).SendKeys("auckland");
        //     driver.FindElement(By.Id("wpforms-24-field_3-address2")).SendKeys("hsjdhsh");
        //     {
        //         var dropdown = driver.FindElement(By.Id("wpforms-24-field_3-state"));
        //         dropdown.FindElement(By.XPath("//option[. = 'Hawaii']")).Click();
        //     }
        //     driver.FindElement(By.Id("wpforms-24-field_3-postal")).SendKeys("0604_");
        //     driver.FindElement(By.Id("wpforms-24-field_6")).SendKeys("testing");
        //     driver.FindElement(By.Id("wpforms-submit-24")).Click();
        // }

    } 
}
