using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class APIHelper1
    {
        //This class allows us make call on the internet.
        //use static here becase we want to open Httpclient onece per application.
        //open up one browser in mmy computer. so vi kan have multiple tabs.
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            //we are looking for json.
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


    }
}
