using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        [Range(1, 10)]
        public int Rating { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
