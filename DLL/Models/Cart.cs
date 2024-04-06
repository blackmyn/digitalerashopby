using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
