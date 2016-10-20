using System;
using CoreApp.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace CoreApp.Services
{
    internal class HomeGreeter : IHomeGreeter
    {
        public HomeGreeter (ICoreAppConfiguration config)
        {
          _greeting = config.HomeGreeting;
        }
        private string _greeting;
        public string Greeting
        {
            get
            {
                return _greeting;
            }
        }
    }
}