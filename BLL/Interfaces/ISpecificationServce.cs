using BLL.DTOModels;
using BLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISpecificationServce : IService<SpecificationDto>
    {
        public string GetCharacteristicNameById(int characteristicId);
    }
}
