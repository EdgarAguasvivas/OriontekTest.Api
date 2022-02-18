using OriontekTest.Business.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace OriontekTest.Business.Service.Abstractions
{
    public interface ICompanyService 
    {
        IEnumerable<CompanyDto> GetAll();
        IEnumerable<CompanyDto> GetAllActive();
        CompanyDto Find(int id);
        CompanyDto Add(CompanyDto dto);
        CompanyDto Update(int id, CompanyDto dto);
        CompanyDto Delete(int id);
    }
}
