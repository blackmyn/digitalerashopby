using AutoMapper;
using BLL.DTOModels;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class SpecificationMappingProfile : Profile
    {
        public SpecificationMappingProfile() => CreateMap<Specification, SpecificationDto>().ReverseMap();
    }
}
