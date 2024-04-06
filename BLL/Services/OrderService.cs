using AutoMapper;
using BLL.DTOModels;
using BLL.Interfaces;
using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public IEnumerable<OrderDto> GetAll()
        {
            var orders = _orderRepository.GetAll();
            return _mapper.Map<IEnumerable<OrderDto>>(orders);
        }

        public void Add(OrderDto orderDTO)
        {
            var order = _mapper.Map<Order>(orderDTO);
            _orderRepository.Add(order);
        }

        public void DeleteById(int orderId)
        {
            _orderRepository.Delete(orderId);
        }

        public OrderDto GetById(int id)
        {
            var order = _orderRepository.GetById(id);
            return _mapper.Map<OrderDto>(order);
        }

        public void Update(OrderDto orderDTO)
        {
            var order = _mapper.Map<Order>(orderDTO);
            _orderRepository.Update(order);
        }
    }
    
}
