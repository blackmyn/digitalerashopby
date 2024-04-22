using BLL.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProcSpecService : IService<ProdSpecDto>
    {
        IEnumerable<ProdSpecDto> GetByProductId(int productId);
    }
}
