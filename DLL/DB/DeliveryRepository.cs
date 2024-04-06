using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DB
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly ApplicationDbContext _context;

        public DeliveryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Delivery> GetAll()
        {
            return _context.Deliveries.ToList();
        }

        public Delivery GetById(int id)
        {
            return _context.Deliveries.FirstOrDefault(d => d.Id == id);
        }

        public void Add(Delivery delivery)
        {
            _context.Deliveries.Add(delivery);
            _context.SaveChanges();
        }

        public void Update(Delivery delivery)
        {
            _context.Deliveries.Update(delivery);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var delivery = _context.Deliveries.FirstOrDefault(d => d.Id == id);
            if (delivery != null)
            {
                _context.Deliveries.Remove(delivery);
                _context.SaveChanges();
            }
        }
    }

}
