using BookStore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBContexts;
using WebApplication1.Services;

namespace WebApplication1
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
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IClasssService, ClasssService>();
            services.AddControllersWithViews();
            services.AddDbContext<StudentDBContext>(option => option.UseSqlServer(Configuration.GetConnectionString("StudentConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Convension Routing

            //app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
            app.UseMvc(routers =>
            {
                //routers.MapRoute("two-paras", "{Controller=Home}/{Action=Index}/{para1?}/{para2?}");
                routers.MapRoute("default", "{Controller=Home}/{Action=Index}/{id?}");
            });
        }
    } 
}
