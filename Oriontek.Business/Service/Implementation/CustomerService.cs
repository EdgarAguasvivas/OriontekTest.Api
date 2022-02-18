using OriontekTest.Business.Dtos;
using OriontekTest.Business.Service.Abstractions;
using OriontekTest.Data.BaseRepository;
using OriontekTest.Data.Entities;
using System;
using System.Linq;
using AutoMapper;
using System.Collections.Generic;

namespace OriontekTest.Business.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly IBaseRepository<Customer> _baseRepository;
        private readonly IMapper _mapper;

        public CustomerService(IBaseRepository<Customer> baseRepository, IMapper mapper)
        {
            this._baseRepository = baseRepository;
            this._mapper = mapper;
        }
        public IEnumerable<CustomerDto> GetAll()
        {
            return _mapper.Map<IEnumerable<CustomerDto>>(_baseRepository.GetAll());
        }
        public CustomerDto Find(int id)
        {
            return _mapper.Map<CustomerDto>(_baseRepository.Get(id));
        }

        public CustomerDto Add(CustomerDto dto)
        {
            var entity = _mapper.Map<Customer>(dto);
            _baseRepository.Insert(entity);
            return _mapper.Map<CustomerDto>(entity); ;
        }

        public CustomerDto Update(int id, CustomerDto dto)
        {
            var entity = _baseRepository.Get(id);
            _mapper.Map(dto, entity);
            _baseRepository.Update(entity);
            return _mapper.Map<CustomerDto>(entity);
        }

        public CustomerDto Delete(int id)
        {
            var entity = _baseRepository.Get(id);
            _baseRepository.Delete(entity);
            return _mapper.Map<CustomerDto>(entity);
        }
    }
}
    