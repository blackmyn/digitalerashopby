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
    public interface IOrderService : IService<OrderDto>
    {
        public Task<int> PlaceOrderAsync(string userId, IEnumerable<CartDto> cartItems, string paymentMethod, string deliveryMethod);

    }
}
