using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core3dot1WebAPI.Configuration;
using Core3dot1WebAPI.Configuration.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Core3dot1WebAPI
{
    public class Startup
    {
        private IWebHostEnvironment Environment { get; }
        private IConfiguration Configuration { get; }

        public Startup(IWebHostEnvironment env, IConfiguration config)
        {
            Environment = env;
            Configuration = config;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            ContainerBuilder builder = new ContainerBuilder();
            services.AddControllers();

            builder.Populate(services);

            // Dependency Injection steps:
            // 1. Create Interface
            // 2. Create class which implements interface
            //      a. Add private interface member to class
            //      b. Add interface to constructor & initialize member
            //      c. Register type in ConfigureServices
            builder.RegisterType<ConfigRetriever>()
                .As<IConfigRetriever>()
                .WithParameter(new TypedParameter(typeof(IConfiguration), Configuration));

            return new AutofacServiceProvider(builder.Build());
        }

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
