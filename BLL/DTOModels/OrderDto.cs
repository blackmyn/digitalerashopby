using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }

        public string UserId { get; set; }
        public ApplicationUserDto User { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; }
        public PaymentDto Payment { get; set; }
        public DeliveryDto Delivery { get; set; }
    }

}
