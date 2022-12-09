using InnoClinic.OfficesAPI.Application.Services;
using InnoClinic.OfficesAPI.Application.Services.Abstractions;
using InnoClinic.OfficesAPI.Infrastructure.Repositories;
using InnoCLinic.OfficesAPI.Core.Contracts.Repositories;
using InnoCLinic.OfficesAPI.Core.Contracts.Settings;
using InnoCLinic.OfficesAPI.Core.Entities.Models;
using Microsoft.Extensions.Options;

namespace InnoClinic.OfficesAPI.Extensions
{
    public static class ServiceExstentions
    {
        public static void ConfigureDbConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<OfficeStoreDatabaseSettings>(configuration.GetSection(nameof(OfficeStoreDatabaseSettings)));

            services.AddSingleton<IOfficeStoreDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<OfficeStoreDatabaseSettings>>().Value);
        }

        public static void ConfigureServiceManager(this IServiceCollection services) =>
           services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
