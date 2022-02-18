using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OriontekTest.Business.Profiles;
using OriontekTest.Business.Service.Abstractions;
using OriontekTest.Business.Service.Implementation;
using OriontekTest.Data.Context;
using System.Reflection;

namespace OriontekTest.Business.Builders
{
    public static partial class DependencyInjection
    {
        public static IServiceCollection BusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApiDbContext>(m =>
            {
                m.UseSqlServer(configuration.GetConnectionString("localConnection"));
            });

            return services
                .AddServices();
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IAddressService, AddressService>();

            return services;
        }       
    }
}
