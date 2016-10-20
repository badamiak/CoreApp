using System;
using CoreApp.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace CoreApp.Services
{
    internal class CoreAppConfiguration : ICoreAppConfiguration
    {
        public CoreAppConfiguration (IHostingEnvironment env)
        {
            var cfgBuilder = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("config.json");
            var cfg = cfgBuilder.Build();
            _homeGreeting = cfg["Greeting"];

        }
        private string _homeGreeting;
        public string HomeGreeting
        {
            get
            {
                return _homeGreeting;
            }
        }
    }
}