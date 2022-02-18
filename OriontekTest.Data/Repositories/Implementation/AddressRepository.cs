using Microsoft.EntityFrameworkCore;
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
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        private readonly ApiDbContext _context;

        public AddressRepository(ApiDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
