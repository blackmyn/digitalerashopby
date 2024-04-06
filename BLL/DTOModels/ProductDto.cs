using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public int? CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public int? BrandId { get; set; }
        public BrandDto Brand { get; set; }
        public ICollection<SpecificationDto> Specifications { get; set; }
        public ICollection<ReviewDto> Reviews { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; }
    }

}
