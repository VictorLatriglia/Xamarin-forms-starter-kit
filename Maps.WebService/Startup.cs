using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Maps.DataAccess;
using Maps.DataAccess.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Maps.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; private set; }
        public IHostingEnvironment HostingEnvironment { get; private set; }

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            HostingEnvironment = hostingEnvironment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Handle your own enviroment strings here
            if (HostingEnvironment.IsDevelopment())
            {
                this.Configuration = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                           .AddJsonFile($"appsettings.development.json", optional: true)
                           .AddEnvironmentVariables()
                       .Build();
            }

            string connection = this.Configuration["ConnectionStrings:MapsDbContext"];
            services.AddDbContext<MapsDbContext>(options =>
            {
                options.UseSqlServer(connection);
            });

            services.AddMvcCore()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors();

            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            //Configure your own dependency injection here
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(builder => builder
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials());

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseStaticFiles();
        }
    }
}
