using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HelloWorld_Console_Client
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static void Main()
        {
            //Console.WriteLine("Hello World!");
            RunAsync().GetAwaiter().GetResult();
        }
               

        static void ShowGreeting(string greeting)
        {
            Console.WriteLine(greeting);
        }

        static async Task<string> GetGreeting(string path)
        {
            var greeting = string.Empty;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                greeting = await response.Content.ReadAsStringAsync();
            }
            return greeting;
        }
        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                var greeting = await GetGreeting("helloworldapi");
                ShowGreeting(greeting);    
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

    }
}
