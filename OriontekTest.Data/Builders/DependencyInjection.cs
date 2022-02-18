using Microsoft.Extensions.DependencyInjection;
using OriontekTest.Data.BaseRepository;
using OriontekTest.Data.Entities;
using OriontekTest.Data.Repositories.Abstractions;
using OriontekTest.Data.Repositories.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Data.Builders
{
    public static partial class DependencyInjection
    {
        public static void DataServices(this IServiceCollection services)
        {
            #region BaseRepository
            services.AddScoped<IBaseRepository<Customer>, CustomerRepository>();
            services.AddScoped<IBaseRepository<Company>, CompanyRepository>();
            services.AddScoped<IBaseRepository<Address>, AddressRepository>();
            #endregion

            #region Repository
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            #endregion
        }
    }
}
