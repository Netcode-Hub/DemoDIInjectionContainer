
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Data
{
    public static class ServiceContainer
    {
        public static IServiceCollection MyCustomServices(this IServiceCollection services
            , IConfiguration configuration, string connectionStringName)

        {
            services.AddDbContext<AppDbContext>(o =>
            o.UseSqlServer(configuration.GetConnectionString(connectionStringName),
                b => b.MigrationsAssembly(typeof(ServiceContainer).Assembly.FullName)),
                ServiceLifetime.Scoped);

            services.AddScoped<ICustomer, CustomerRepo>();

            return services;
        }
    }
}
