using InnowiseTask.Server.Data.Repositories;
using InnowiseTask.Server.Data.Repositories.Interfaces;
using InnowiseTask.Server.Services;
using InnowiseTask.Server.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InnowiseTask.Server.Extensions
{
    public static class DIExtensions
    {
        public static void AddLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();

        public static void AddRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void AddFridgeService(this IServiceCollection services) =>
            services.AddScoped<IFridgeService, FridgeService>();

    }
}
