using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels
{
    public class DeliveryDto
    {
        public int Id { get; set; }
        public string DeliveryMethod { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Status { get; set; }

        public int OrderId { get; set; }
        public virtual OrderDto Order { get; set; }
    }
}
