﻿using DLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOModels
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }
        public virtual ICollection<ProdSpec> ProdSpec { get; set; }
    }

}
