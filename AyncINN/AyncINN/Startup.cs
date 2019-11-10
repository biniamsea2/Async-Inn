using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AyncINN.Data;
using AyncINN.Models.Interfaces;
using AyncINN.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace AyncINN
{
    public class Startup
    {
        public IHostEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

        public Startup(IHostEnvironment environment)
        {
            Environment = environment;
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            string connectionString = Environment.IsDevelopment()
                    ? Configuration["ConnectionStrings:DefaultConnection"]
                    : Configuration["ConnectionStrings:ProductionConnection"];

            services.AddDbContext<AsyncInnDbContext>(options =>
            options.UseSqlServer(connectionString));


            services.AddDbContext<AsyncInnDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ProductionConnection")));

            services.AddScoped<IHotelManager, HotelService>();
            services.AddScoped<IRoomManager, RoomService>();
            services.AddScoped<IAmenitiesManager, AmenitiesService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                //the question mark in id is nullable, so the id may or may not exist.
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
