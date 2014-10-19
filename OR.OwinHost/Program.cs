using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin.Hosting;
using OR.Web;
using OpenRasta.Configuration;
using OpenRasta.Owin;
using Owin;

namespace OR.OwinHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            IConfigurationSource configSources = new Config();
            appBuilder.UseOpenRasta(configSources);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const string uri = "http://localhost:5050/";

            WebApp.Start<Startup>(uri);

            Console.WriteLine("OR server started on 5050, listening...");

            Console.ReadLine();
        }
    }
}
