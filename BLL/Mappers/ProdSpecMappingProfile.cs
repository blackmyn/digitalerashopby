using BLL.DTOModels;
using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class ProdSpecMappingProfile : Profile
    {
        public ProdSpecMappingProfile() => CreateMap<ProdSpec, ProdSpecDto>().ReverseMap();
    }
}
