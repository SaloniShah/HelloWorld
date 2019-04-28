using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.FileExtensions;
using HelloWorldWriter;

namespace HelloWorldConsoleApp
{
    class Program
    {
        private static HttpClient client = new HttpClient();
        private static MessageWriter messageWriter;
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
          
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            client.BaseAddress = new Uri(config["helloWorldAPI"]);
           
            messageWriter = MessageWriter.GetMessageWriter(config["MessageWriter"]);
            
            try
            {
                HttpResponseMessage response = await client.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    messageWriter.Write(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();
        }
    }
}
