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
        public int CategoryId { get; set; }
        public int CharacteristicId { get; set; }
        public string Value { get; set; }

        public Category Category { get; set; }
        public Specification Specification { get; set; }
    }
}
