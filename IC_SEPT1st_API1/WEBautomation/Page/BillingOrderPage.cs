using COMMON.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WEBautomation.Page
{
   
    public class BillingOrderPage
    {
         public  IWebDriver browser ;

        public void FirstName(string value)
        {
            browser .FindElement(By.Id("wpforms-24-field_0")).SendKeys(value);
        }

        public void LastName(string value)
        {
            browser .FindElement(By.Id("wpforms-24-field_0-last")).SendKeys(value);
        }
        public void Email(string value)
        {
            browser .FindElement(By.Id("wpforms-24-field_1")).SendKeys(value);
        }
        public void AdressLine1(string value)
        {
            browser .FindElement(By.Id("wpforms-24-field_3")).SendKeys(value);
        }
         public void AdressLine2(string value)
        {
            browser .FindElement(By.Id("wpforms-24-field_3-address2")).SendKeys(value);
        }
        public void City(string value)
        {
            browser .FindElement(By.Id("wpforms-24-field_3-city")).SendKeys(value);
        }


        public BillingOrderPage()
        { }
        public void FillForm(BillingOrder order)
        {
            FirstName(order.FirstName);
            LastName(order.LastName);
            Email(order.Email);
            AdressLine1(order.AddressLine1);
            AdressLine2(order.AddressLine2);
        }

        public  void Submit()
        {
            browser.FindElement(By.Id("wpforms-submit-24")).Click();
        }

        public BillingOrderPage(IWebDriver driver)
        {
            this.browser  = driver;
        }
        public void Login()
        {
            browser .FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).SendKeys("Testing");
            browser .FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).SendKeys(Keys.Enter);
        }
    }   }
    