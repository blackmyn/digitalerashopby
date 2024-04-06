using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DB
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderItem> GetAll()
        {
            return _context.OrderItems.ToList();
        }

        public OrderItem GetById(int id)
        {
            return _context.OrderItems.FirstOrDefault(oi => oi.Id == id);
        }

        public void Add(OrderItem orderItem)
        {
            _context.OrderItems.Add(orderItem);
            _context.SaveChanges();
        }

        public void Update(OrderItem orderItem)
        {
            _context.OrderItems.Update(orderItem);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var orderItem = _context.OrderItems.FirstOrDefault(oi => oi.Id == id);
            if (orderItem != null)
            {
                _context.OrderItems.Remove(orderItem);
                _context.SaveChanges();
            }
        }
    }
}