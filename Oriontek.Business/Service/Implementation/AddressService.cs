using AutoMapper;
using OriontekTest.Business.Dtos;
using OriontekTest.Business.Service.Abstractions;
using OriontekTest.Data.BaseRepository;
using OriontekTest.Data.Entities;
using OriontekTest.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Service.Implementation
{
    public class AddressService : IAddressService
    {

        private readonly IBaseRepository<Address> _baseRepository;
        private readonly IMapper _mapper;
        private readonly IAddressRepository _addressRepository;

        public AddressService(IBaseRepository<Address> baseRepository, IMapper mapper,IAddressRepository addressRepository)
        {
            this._baseRepository = baseRepository;
            this._mapper = mapper;
            this._addressRepository = addressRepository;
        }
        public IEnumerable<AddressDto> GetAll()
         {
            var address = _baseRepository.GetAll();
            var result = _mapper.Map<IEnumerable<AddressDto>>(address);
            return result;
        }
        public AddressDto Find(int id)
        {
            return _mapper.Map<AddressDto>(_baseRepository.Get(id));
        }

        public IEnumerable<AddressDto> GetAllByCustomerId(int id)
        {
            return _mapper.Map<IEnumerable<AddressDto>>(_baseRepository.GetAll().Where(x => x.CustomerId == id));
        }

        public AddressDto Add(AddressDto dto)
        {
            var entity = _mapper.Map<Address>(dto);
            _baseRepository.Insert(entity);
            return _mapper.Map<AddressDto>(entity); ;
        }

        public AddressDto Update(int id, AddressDto dto)
        {
            var entity = _baseRepository.Get(id);
            _mapper.Map(dto, entity);
            _baseRepository.Update(entity);
            return _mapper.Map<AddressDto>(entity);
        }

        public AddressDto Delete(int id)
        {
            var entity = _baseRepository.Get(id);
            _baseRepository.Delete(entity);
            return _mapper.Map<AddressDto>(entity);
        }
    }
}
