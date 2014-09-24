using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;
using System.Web.Http;
using Owin;

namespace Server.WebServices
{
    public class WebService : IDisposable
    {
        private WebService()
        {
            this.webHost = WebApp.Start<WebService.Host>(url: BaseAddress);
        }

        public const String BaseAddress = "http://localhost:8080/";
        private IDisposable webHost = null;

        public static WebService StartHost()
        {
            return new WebService();
        }

     
        public void Dispose()
        {
            if (this.webHost != null)
            {
                this.webHost.Dispose();
            }
        }

        private class Host
        {
            public void Configuration(IAppBuilder appBuilder)
            {
                // Configure Web API for self-host. 
                HttpConfiguration config = new HttpConfiguration(); 
                config.Routes.MapHttpRoute(
                    name: "DefaultApi", 
                    routeTemplate: "{controller}/{action}/{id}", 
                    defaults: new { id = RouteParameter.Optional,
                    action = RouteParameter.Optional} 
                ); 

                appBuilder.UseWebApi(config); 
            }
        }
    }
}