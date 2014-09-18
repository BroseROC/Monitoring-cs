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
            WebService w = new WebService();
            w.StartHost();
        }
    }
}
