using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

using Server.WebServices;

namespace Server
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Server");
            using (WebService w = WebService.StartHost())
            {
                Console.WriteLine("Server started");

                HttpClient client = new HttpClient();
                var result = client.GetAsync(WebService.BaseAddress + "status/").Result;
                Console.WriteLine(result);
                Console.WriteLine(result.Content.ReadAsStringAsync().Result);

//                Console.WriteLine("Hit enter to exit");
//                Console.ReadLine();
            }
        }
    }
}
