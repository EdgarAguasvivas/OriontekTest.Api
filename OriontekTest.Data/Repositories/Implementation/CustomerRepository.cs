using OriontekTest.Data.BaseRepository;
using OriontekTest.Data.Context;
using OriontekTest.Data.Entities;
using OriontekTest.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Data.Repositories.Implementation
{
    class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApiDbContext context) : base(context)
        {
        }
    }
}
