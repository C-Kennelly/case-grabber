using System;
using System.Configuration;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Headers;
using case_grabber.Models.CaseStore;

namespace case_grabber
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

//            string apiKey = Environment.GetEnvironmentVariable("CASELAW_KEY");
//            Console.WriteLine("Using key: {0}", apiKey);

            var endpoints = MakeCall().Result;

            foreach(string key in endpoints.Keys)
            {
                Console.WriteLine("{0}: {1}", key, endpoints.GetValueOrDefault(key));
            }



        }

        private static async Task<Dictionary<string, string>> MakeCall()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            var streamTask = client.GetStreamAsync("https://api.case.law");

            var serializer = new DataContractJsonSerializer(typeof(Endpoints));
            var endpoints = serializer.ReadObject(await streamTask) as Endpoints;

            return endpoints.MakeDictionary();
        }
    }
}
