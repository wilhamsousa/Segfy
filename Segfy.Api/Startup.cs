using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Segfy.Application;
using Segfy.Application.Interface;
using Segfy.Repository.Entity;
using Segfy.Repository.Repository;
using Segfy.Repository.Repository.Interface;
using Segfy.Service;
using Segfy.Service.Interface;

namespace Segfy.Api
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
            services.AddDbContext<Context>();

            services.AddTransient<IYoutubeApplication, YoutubeApplication>();
            services.AddTransient<IYoutubeService, YoutubeService>();
            services.AddTransient<IYoutubeApiService, YoutubeApiService>();
            services.AddTransient<IYoutubeRepository, YoutubeRepository>();
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

            app.UseHttpsRedirection();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("default", "{controller=Youtube}/{action=Index}/{id?}");
            //});
        }
    }
}
