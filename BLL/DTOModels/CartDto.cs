using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels
{
    public class CartDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUserDto User { get; set; }

        public int ProductId { get; set; }
        public virtual ProductDto Product { get; set; }
    }

}
