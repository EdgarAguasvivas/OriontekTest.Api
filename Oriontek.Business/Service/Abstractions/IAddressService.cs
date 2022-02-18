using OriontekTest.Business.Dtos;
using OriontekTest.Data.BaseRepository;
using System.Collections.Generic;
using System.Linq;

namespace OriontekTest.Business.Service.Abstractions
{
    public interface IAddressService
    {
        IEnumerable<AddressDto> GetAll();
        AddressDto Find(int id);
        AddressDto Add(AddressDto dto);
        AddressDto Update(int id, AddressDto dto);
        AddressDto Delete(int id);
        IEnumerable<AddressDto> GetAllByCustomerId(int id);
    }
}
