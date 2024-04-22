﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Models
{
    public class Specification
    {
        public int Id { get; set; }
        [Required]
        public string Key { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }
        public ICollection<ProdSpec> ProdSpec { get; set; }
    }

}
