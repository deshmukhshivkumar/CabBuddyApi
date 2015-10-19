using System;
using System.Threading.Tasks;

namespace ApiTester
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
        }
        static async Task RunAsync()
        {
            Console.WriteLine("Calling the back-end API");

            //const string apiBaseAddress = "http://localhost:8080/";

            //var customDelegatingHandler = new CustomDelegatingHandler();

            //var client = HttpClientFactory.Create(customDelegatingHandler);

            //var order = new Group {AdminName = "Shiv", CreatedOn = DateTime.Now, Name = "Shiv's Group "};

            //var response = await client.PostAsJsonAsync(apiBaseAddress + "api/group", order);

            //if (response.IsSuccessStatusCode)
            //{
            //    var responseString = await response.Content.ReadAsStringAsync();
            //    Console.WriteLine(responseString);
            //    Console.WriteLine("HTTP Status: {0}, Reason {1}. Press ENTER to exit", response.StatusCode, response.ReasonPhrase);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to call the API. HTTP Status: {0}, Reason {1}", response.StatusCode, response.ReasonPhrase);
            //}

            Console.ReadLine();
        }
    }
}
