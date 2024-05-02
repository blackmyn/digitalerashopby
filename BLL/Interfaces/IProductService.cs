using BLL.DTOModels;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProductService : IService<ProductDto>
    {
        public IEnumerable<ProductDto> GetProductsByCategory(string category, string sort);
        public IEnumerable<ProductDto> GetProductsByName(string name);

    }
}
