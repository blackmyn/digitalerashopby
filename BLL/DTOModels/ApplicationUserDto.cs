using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Models;

namespace BLL.DTOModels
{
    public class ApplicationUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual ICollection<OrderDto> Orders { get; set; }
        public virtual ICollection<CartDto> Carts { get; set; }
    }
}
