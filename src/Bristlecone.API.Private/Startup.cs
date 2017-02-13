using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Bristlecone.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Bristlecone.DataAccessLayer.Repositories.Interfaces;
using Bristlecone.BusinessLayer.Interfaces;
using Bristlecone.BusinessLayer.Concretes;
using Bristlecone.DataLayer.EfRepositories;
using Bristlecone.Service.Interfaces;
using IDX.Service.Services;

namespace Bristlecone.API.Private
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
#pragma warning disable CS1701 // Assuming assembly reference matches identity
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
#pragma warning restore CS1701 // Assuming assembly reference matches identity
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
#pragma warning disable CS1701 // Assuming assembly reference matches identity
            services.AddDbContext<BristleconeDbContext>(options =>
                options.UseInMemoryDatabase()
            );
            // Add framework services.
            services.AddMvc();

            services.AddScoped<IApplicationService, ApplicationService>();
            services.AddScoped<IApplicationBusinessEntity, ApplicationBusinessEntity>();
            services.AddScoped<IApplicationRepository, ApplicationEfRepository>();
#pragma warning restore CS1701 // Assuming assembly reference matches identity
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
#pragma warning disable CS1701 // Assuming assembly reference matches identity
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
#pragma warning restore CS1701 // Assuming assembly reference matches identity

            app.UseMvc();
        }
    }
}
