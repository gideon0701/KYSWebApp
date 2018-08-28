using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test1.Models;

namespace Test1.Utils.restUtil
{
    public class RestClientUtil
    {
        readonly string apiURL = "http://192.168.254.153:23123/api";
        RestClient client;
        public RestClientUtil()
        {
            client = new RestClient(apiURL);
        }

        public NewsModel getCompanyNews(string wController, string wCompanyName)
        {
            var request = new RestRequest(wController, Method.GET);
            request.AddParameter("name", wCompanyName);

            IRestResponse<NewsModel> response = client.Execute<NewsModel>(request);
            return response.Data;
        }

        public string getStringData(string wController)
        {
            var request = new RestRequest(wController, Method.GET);
            request.AddParameter("id", 1);

            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string
            return content;
        }
    }
}