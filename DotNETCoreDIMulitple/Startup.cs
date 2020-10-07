using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNETCoreDIMultiple.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DotNETCoreDIMulitple
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();


            var settingTypes = typeof(ISample).Assembly.GetTypes()
                .Where(item => item.GetInterfaces().Contains(typeof(ISample)));


            foreach (var type in settingTypes)
            {
                var serviceDescriptor = new ServiceDescriptor(typeof(ISample), type, ServiceLifetime.Scoped);
                services.Add(serviceDescriptor);
            }

            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
