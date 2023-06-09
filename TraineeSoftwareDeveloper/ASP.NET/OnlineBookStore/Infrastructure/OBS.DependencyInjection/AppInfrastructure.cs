using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using OBS.Business.Interfaces;
using OBS.Business.Interfaces.Authentication;
using OBS.Business.Interfaces.Email;
using OBS.Business.Models.Email;
using OBS.Business.Services;
using OBS.Business.Services.Authentication;
using OBS.Business.Services.Email;
using OBS.Data;
using OBS.Data.Interfaces;
using OBS.Data.Services;
using System.Text;

namespace OBS.DependencyInjection
{
    public static class AppInfrastructure
    {
        public static void AppDISetup(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure EntityFramework
            services.AddDbContext<BookStoreDbContext>(options => options
                                                    .UseSqlServer(configuration.GetConnectionString("DbConnection")));

            // Identity Framework 
            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<BookStoreDbContext>()
                    .AddDefaultTokenProviders();

            // Require Confirmed Email Configuration
            services.Configure<IdentityOptions>(options =>
                    options.SignIn.RequireConfirmedEmail = true);

            // Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                };
            });

            // Email Configuration
            var emailConfig = configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);

            services.AddScoped<IEmailService, EmailService>();
            services.AddMvc();
            services.AddScoped<IUrlHelper, UrlHelper>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            // Repositories Configuration
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // Unit Of Work Configuration
            //services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            // All of the Custom Configuration - Dependency Injection
            //services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IPublisherService, PublisherService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderItemService, OrderItemService>();

            // Automapper Configuration
            services.AddAutoMapper(typeof(BusinessEntityMapping));
        }
    }
}