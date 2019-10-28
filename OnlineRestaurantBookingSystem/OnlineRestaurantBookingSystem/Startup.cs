using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineRestaurantBookingSystem.Models;

namespace OnlineRestaurantBookingSystem
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration )
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddDbContext<RestaurantDbContext>(x => {

                x.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
            });
            services.AddSession();
            services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultTokenProviders()
                                                    .AddEntityFrameworkStores<RestaurantDbContext>();
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);
            services.AddAuthentication(options=>
            {
                options.DefaultChallengeScheme = FacebookDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddFacebook(options =>

            {
                options.AppId = "3174222672619464";
                options.AppSecret = "5aa1c120adeb262aa23cf2645d75b4ea";
            }).AddCookie();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseSession();
            app.UseMvc(route =>
            {
                route.MapRoute(name: "", template: "{controller=Home}/{action=Index}/{id?}");
                route.MapRoute(name: "", template: "{controller=Account}/{action=Login}");
            });
        }
    }
}
