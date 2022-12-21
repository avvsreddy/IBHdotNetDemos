using System.Net.Http.Json;

namespace CoolProductsClientConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // need list of products

            // 1. discover the uri of the service
            string serviceUri = "https://localhost:44366/api/CoolProducts";
            // 2. send get request to service
            HttpClient httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri(serviceUri);
            var response = httpClient.GetAsync(serviceUri).Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //string result = response.Content.ReadAsStringAsync().Result;
                var items = response.Content.ReadFromJsonAsync<List<Item>>().Result;

                foreach (var item in items)
                {
                    Console.WriteLine(item.name);
                }

            }
            //Console.WriteLine(response);


        }
    }
}