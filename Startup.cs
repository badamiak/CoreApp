using CoreApp.Services;
using CoreApp.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoreApp
{
    public class Startup
    {
        // public IConfiguration config {get; private set;}
        public Startup(IHostingEnvironment env)
        {
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddSingleton<ICoreAppConfiguration, CoreAppConfiguration>();
            // services.AddSingleton<IHomeGreeter, HomeGreeter>();
            services.AddMvcCore();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory
            // IHomeGreeter homeGreeter
            )
        {
            loggerFactory.AddConsole();
            var logger = loggerFactory.CreateLogger(nameof(Startup.Configure));

            // logger.LogInformation("Inviting Nancy to a dinner");
            // app.UseOwin(x=>x.UseNancy());

            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
            // app.UseFileServer();
        }
    }
}