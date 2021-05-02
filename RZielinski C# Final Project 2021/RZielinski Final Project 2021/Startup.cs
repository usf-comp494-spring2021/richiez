//Project: RZielinski Final Project 2021
//Author: Richie Zielinski
//Date: 5/11/21
//Language: C#
//Purpose: To create a web MVC project and make use of a swagger API

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.IO;
using static System.Console;
using System.Net.Http.Headers;

namespace RZielinski_Final_Project_2021
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method is used to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

            services.AddControllers();

            services.AddRazorPages();

            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "COMP494_FINAL", Version = "v1" }); });

            //In this block we are starting the connection to the swagger API by stating our base address and that we will be pulling data in the JSON format
            services.AddHttpClient(name: "Shadow_Info",
              configureClient: options =>
              {
                  options.BaseAddress = new Uri("http://csc494a-sp21-final.azurewebsites.net/");
                  options.DefaultRequestHeaders.Accept.Add(
              new MediaTypeWithQualityHeaderValue(
              "application/json", 1.0));
              });
        }

        // This method is used to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("http://csc494a-sp21-final.azurewebsites.net/swagger/v1/swagger.json" , "COMP495_FINAL"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");

                 endpoints.MapRazorPages();
            });
        }
    }
}