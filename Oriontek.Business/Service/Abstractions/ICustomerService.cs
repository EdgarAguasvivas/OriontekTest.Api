using OriontekTest.Business.Dtos;
using OriontekTest.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OriontekTest.Business.Service.Abstractions
{
    public interface ICustomerService
    {
        IEnumerable<CustomerDto> GetAll();
        CustomerDto Find(int id);
        CustomerDto Add(CustomerDto dto);
        CustomerDto Update(int id, CustomerDto dto);
        CustomerDto Delete(int id);
    }
}
