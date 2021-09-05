using APIautomation.API;
using COMMON.Models;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIautomation.TESTS
{
  
    public class BillingOrderTests
    {
    /* string jsonBody = "{\"addressLine1\":\"address1\",\"addressLine2\":\"add2\"," +
                          "\"city\":\"auckland\",\"comment\":\"testcomment\",\"email\":\"ajit@sector36.com\"," +
     "\"firstName\":\"Ajit\",\"itemNumber\":0,\"lastName\":\"Sharma\"," +
     "\"phone\":\"0123456789\",\"state\":\"AL\",\"zipCode\":\"121212\"}";*/
        [Test]
        public void BillingOrderPost()
        {
            BillingOrder Expectedorder = new BillingOrder
            {

                AddressLine1 = "harika",
                AddressLine2 = "titi",
                City = "Greenbay",
                Comment = "comment",
                Email = "harika@gmail.com",
                FirstName = "harika",
                ItemNumber = 12,
                LastName = "sweetie/suhaas",
                Phone = "0123456789",
                State = "AL",
                ZipCode = "2938283"
            };

            //converting object to JSON

            string jsonBody = JsonConvert.SerializeObject(Expectedorder);
            BillingOrderAPI billingOrder = new BillingOrderAPI();
           
            //creating order means POST
            IRestResponse POSTresponse = billingOrder.POST(jsonBody);
                      
            //Converting Json TO OBJECT
           
            BillingOrder actualorder  = JsonConvert.DeserializeObject<BillingOrder>(POSTresponse.Content);
         

           //Getting order means GET 
           // IRestResponse GETresponse = billingOrder.Get(actualorder.Id);
            //TestContext.WriteLine(GETresponse.Content);
            TestContext.WriteLine(POSTresponse.Content);
           // actualorder.Id = Expectedorder.Id;

            // Assert.AreEqual(Expectedorder.FirstName ,  actualorder.FirstName );
           
            actualorder.FirstName = "asadada";
            actualorder.AddressLine1= "ywdhwdxwu";
            Expectedorder.Should().BeEquivalentTo(actualorder);
            Expectedorder .Should().BeEquivalentTo(actualorder ,
                options => options.Excluding(o => o.Id ));


        }
    }

}
