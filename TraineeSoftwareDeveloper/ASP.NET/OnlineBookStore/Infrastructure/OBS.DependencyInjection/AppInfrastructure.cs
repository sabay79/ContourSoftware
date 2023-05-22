using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OBS.Business.Interfaces;
using OBS.Business.Services;
using OBS.Data;
using OBS.Data.Interfaces;
using OBS.Data.Services;

namespace OBS.DependencyInjection
{
    public static class AppInfrastructure
    {
        public static void AppDISetup(this IServiceCollection services, IConfiguration configuration)
        {
            //// Configure EntityFramework
            services.AddDbContext<BookStoreDbContext>(options => options
                                                    .UseSqlServer(configuration.GetConnectionString("DbConnection")));

            // Repositories Configuration
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // Unit Of Work Configuration
            //services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            // All of the Custom Configuration - Dependency Injection
            services.AddScoped<IAuthorService, AuthorService>();

            // Automapper Configuration
            services.AddAutoMapper(typeof(BusinessEntityMapping));
        }
    }
}