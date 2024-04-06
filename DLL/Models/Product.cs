using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int? BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<Specification> Specifications { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
