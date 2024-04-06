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
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IMapper _mapper;

        public OrderItemService(IOrderItemRepository orderItemRepository, IMapper mapper)
        {
            _orderItemRepository = orderItemRepository;
            _mapper = mapper;
        }

        public IEnumerable<OrderItemDto> GetAll()
        {
            var orderItems = _orderItemRepository.GetAll();
            return _mapper.Map<IEnumerable<OrderItemDto>>(orderItems);
        }

        public void Add(OrderItemDto orderItemDTO)
        {
            var orderItem = _mapper.Map<OrderItem>(orderItemDTO);
            _orderItemRepository.Add(orderItem);
        }

        public void DeleteById(int orderItemId)
        {
            _orderItemRepository.Delete(orderItemId);
        }

        public OrderItemDto GetById(int id)
        {
            var orderItem = _orderItemRepository.GetById(id);
            return _mapper.Map<OrderItemDto>(orderItem);
        }

        public void Update(OrderItemDto orderItemDTO)
        {
            var orderItem = _mapper.Map<OrderItem>(orderItemDTO);
            _orderItemRepository.Update(orderItem);
        }
    }

}
