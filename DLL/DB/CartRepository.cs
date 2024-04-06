using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DB
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _context;

        public CartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cart> GetAll()
        {
            return _context.Carts.ToList();
        }

        public Cart GetById(int id)
        {
            return _context.Carts.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Cart cart)
        {
            _context.Carts.Add(cart);
            _context.SaveChanges();
        }

        public void Update(Cart cart)
        {
            _context.Carts.Update(cart);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cart = _context.Carts.FirstOrDefault(c => c.Id == id);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
                _context.SaveChanges();
            }
        }
    }

}
