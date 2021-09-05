using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIautomation.API
{
    class BillingOrderAPI
    {
       public  string BaseUrl = "http://localhost:8080/BillingOrder/";
        public IRestResponse POST(string body)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest(Method.POST);
            //HEADER
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(body);
            //execution
            return client.Execute(request);

        }
        public IRestResponse GetAll()
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            return client.Execute(request);
        }

        public IRestResponse Put(int id, string body)
        {


            var client = new RestClient($"{BaseUrl}/{id}");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(body);
            return client.Execute(request);
        }

        public IRestResponse Delete(int id)
        {
            var client = new RestClient($"{BaseUrl}/{id}");
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            return client.Execute(request);
        }

        public IRestResponse Get(int id)
        {
            var client = new RestClient($"{BaseUrl}/{id}");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            return client.Execute(request);
        }

    }
}
    

