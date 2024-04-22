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
        public async Task<int> PlaceOrderAsync(string userId, IEnumerable<CartDto> cartItems, string paymentMethod, string deliveryMethod)
        {
            var order = new Order
            {
                OrderDate = DateTime.Now,
                Status = "Done",
                TotalPrice = CalculateTotalPrice(cartItems, deliveryMethod),
                UserId = userId,
            };

            _orderRepository.Add(order);

            return order.Id;
        }
        private decimal CalculateTotalPrice(IEnumerable<CartDto> cartItems, string deliveryMethod)
        {
            // Рассчитываем общую стоимость товаров
            decimal totalProductsPrice = 0;
            foreach (var item in cartItems)
            {
                totalProductsPrice += item.Quantity * item.Product.Price;
            }

            // Добавляем стоимость доставки, если это не самовывоз
            decimal deliveryFee = deliveryMethod == "pickup" ? 0 : 1000; // Здесь можно настроить стоимость доставки
            return totalProductsPrice + deliveryFee;
        }
    }

}
