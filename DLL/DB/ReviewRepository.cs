using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DB
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly ApplicationDbContext _context;

        public ReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Review> GetAll()
        {
            return _context.Reviews.ToList();
        }

        public Review GetById(int id)
        {
            return _context.Reviews.FirstOrDefault(r => r.Id == id);
        }

        public void Add(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public void Update(Review review)
        {
            _context.Reviews.Update(review);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var review = _context.Reviews.FirstOrDefault(r => r.Id == id);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                _context.SaveChanges();
            }
        }
    }

}
