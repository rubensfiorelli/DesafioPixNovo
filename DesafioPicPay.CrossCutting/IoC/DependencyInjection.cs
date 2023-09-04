using DesafioPicPay.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioPicPay.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories();

            services.AddDbContextPool<AppDbContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("SQLConnection"),
            b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            return services;
        }
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            //services.AddScoped(typeof(ICategoryWriteRepository), typeof(CategoryWriteRepository));
            //services.AddScoped(typeof(ICostumerWriteRepository), typeof(CostumerWriteRepository));
            //services.AddScoped(typeof(IOrderWriteRepository), typeof(OrderWriteRepository));
            //services.AddScoped(typeof(ICategoryReadRepository), typeof(CategoryReadRepository));
            //services.AddScoped(typeof(ICostumerReadRepository), typeof(CostumerReadRepository));
            //services.AddScoped(typeof(IOrderItemReadRepository), typeof(OrderItemReadRepository));
            //services.AddScoped(typeof(IOrderReadRepository), typeof(OrderReadRepository));
            //services.AddScoped(typeof(IProductReadRepository), typeof(ProductReadRepository));

            return services;
        }
    }
}
