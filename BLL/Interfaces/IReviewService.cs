﻿using BLL.DTOModels;
using BLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IReviewService : IService<ReviewDto>
    {
        public IEnumerable<ReviewDto> GetByProductId(int productId);
    }
}
