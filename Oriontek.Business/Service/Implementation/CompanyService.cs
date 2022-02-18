using AutoMapper;
using OriontekTest.Business.Dtos;
using OriontekTest.Business.Service.Abstractions;
using OriontekTest.Data.BaseRepository;
using OriontekTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Service.Implementation
{
    public class CompanyService : ICompanyService
    {
        private readonly IBaseRepository<Company> _baseRepository;
        private readonly IMapper _mapper;

        public CompanyService(IBaseRepository<Company> baseRepository, IMapper mapper)
        {
            this._baseRepository = baseRepository;
            this._mapper = mapper;
        }
        public IEnumerable<CompanyDto> GetAll()
        {
            return _mapper.Map<IEnumerable<CompanyDto>>(_baseRepository.GetAll());
        }

        public IEnumerable<CompanyDto> GetAllActive()
        {
            return _mapper.Map<IEnumerable<CompanyDto>>(_baseRepository.GetAll().Where(x => x.IsActive));
        }

        public CompanyDto Find(int id)
        {
            return _mapper.Map<CompanyDto>(_baseRepository.Get(id));
        }

        public CompanyDto Add(CompanyDto dto)
        {
            var entity = _mapper.Map<Company>(dto);
            _baseRepository.Insert(entity);
            return _mapper.Map<CompanyDto>(entity); ;
        }

        public CompanyDto Update(int id, CompanyDto dto)
        {
            var entity = _baseRepository.Get(id);
            _mapper.Map(dto, entity);
            _baseRepository.Update(entity);
            return _mapper.Map<CompanyDto>(entity);
        }

        public CompanyDto Delete(int id)
        {
            var entity = _baseRepository.Get(id);
            _baseRepository.Delete(entity);
            return _mapper.Map<CompanyDto>(entity);
        }
    }
}
