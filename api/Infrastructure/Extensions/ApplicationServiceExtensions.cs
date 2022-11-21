using Domain.Interface;
using Infrastructure.Data;
using Infrastructure.Repositiories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("Clause"),  b => b.MigrationsAssembly("API"));
            });
            services.AddScoped<IClauseRepository, ClauseRepository>();
            return services;
        }
    }
}