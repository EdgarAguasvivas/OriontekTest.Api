using AutoMapper;
using OriontekTest.Business.Dtos;
using OriontekTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Address, AddressDto>()
                    .ReverseMap();
        }
    }
}
