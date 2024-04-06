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
    public class OrderItemMappingProfile : Profile
    {
        public OrderItemMappingProfile() => CreateMap<OrderItem, OrderItemDto>().ReverseMap();
    }
}
