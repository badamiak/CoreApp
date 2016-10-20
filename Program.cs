using System;
using Microsoft.AspNetCore.Hosting;

namespace CoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://w1.localhost:80")
                .UseStartup(typeof(CoreApp.Startup))
                .Build();

            host.Run();
        }
    }
}
