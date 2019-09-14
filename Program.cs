using System;
using System.Configuration;

namespace case_grabber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string apiKey = Environment.GetEnvironmentVariable("CASELAW_KEY");
    

            Console.WriteLine("Using key: {0}", apiKey);
        }
    }
}
