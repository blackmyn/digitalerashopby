using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels
{
    public class ProdSpecDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int CharacteristicId { get; set; }
        public string Value { get; set; }

        public CategoryDto Category { get; set; }
        public SpecificationDto Specification { get; set; }
    }
}
