using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DB
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Payment> GetAll()
        {
            return _context.Payments.ToList();
        }

        public Payment GetById(int id)
        {
            return _context.Payments.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }

        public void Update(Payment payment)
        {
            _context.Payments.Update(payment);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var payment = _context.Payments.FirstOrDefault(p => p.Id == id);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
        }
    }

}
