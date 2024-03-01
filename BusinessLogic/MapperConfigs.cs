using AutoMapper;
using Core.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class AppProfiles : Profile
    {
        public AppProfiles()
        {
            CreateMap<Phone, PhoneDto>()
                .ForMember(dto => dto.CategoryName, opts => opts.MapFrom(p => p.Category.Name));
            CreateMap<PhoneDto, Phone>();
        }
    }
}
