using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    public class ProdSpec
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CharacteristicId { get; set; }
        public string Value { get; set; }

        public Product Product { get; set; }
        public Specification Specification { get; set; }
    }
}
