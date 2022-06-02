using InnowiseTask.Server.Data;
using InnowiseTask.Server.Data.Models;
using InnowiseTask.Server.Services;
using InnowiseTask.Server.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InnowiseTask.Server.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
            });

        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
            services.AddDbContext<ApplicationDbContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


        public static void ConfigureIdnetity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<User>(o =>
           {
               o.Password.RequireDigit = false;
               o.Password.RequireLowercase = false;
               o.Password.RequireUppercase = false;
               o.Password.RequireNonAlphanumeric = false;
               o.Password.RequiredLength = 16;
               o.User.RequireUniqueEmail = true;
           });

            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);
            builder.AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }
    }
}
