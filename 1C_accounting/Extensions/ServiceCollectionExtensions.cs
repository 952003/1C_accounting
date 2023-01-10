using _1C_accounting.DataBase;
using _1C_accounting.Repositories.Implementations;
using _1C_accounting.Repositories.Interfaces;
using _1C_accounting.Services.Implementations;
using _1C_accounting.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _1C_accounting.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(o =>
            {
                o.UseLazyLoadingProxies();
                o.UseSqlServer(configuration.GetConnectionString("ApplicationDb"));
            });
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IIngridientsRepository, IngridientsRepository>();
            services.AddTransient<IProductsRepository, ProductsRepository>();
            return services;
        }
    }
}
