using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;
using System.Web.Http;
using Owin;

namespace Server.WebServices
{
    public class WebService
    {
        public WebService()
        {
        }

        public const String BaseAddress = "http://localhost:8080/";

        public void StartHost()
        {
            using (WebApp.Start<WebService>(url: BaseAddress))
            {
                HttpClient client = new HttpClient();
                    var result = client.GetAsync(BaseAddress + "api/status").Result;
                Console.WriteLine(result);
                Console.WriteLine(result.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }

        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration(); 
            config.Routes.MapHttpRoute(
                name: "DefaultApi", 
                routeTemplate: "{controller}/{action}/{id}", 
                defaults: new { id = RouteParameter.Optional } 
            ); 

            appBuilder.UseWebApi(config); 
        }

    }
}