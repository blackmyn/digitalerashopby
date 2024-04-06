using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DB
{
    public class SpecificationRepository : ISpecificationRepository
    {
        private readonly ApplicationDbContext _context;

        public SpecificationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Specification> GetAll()
        {
            return _context.Specifications.ToList();
        }

        public Specification GetById(int id)
        {
            return _context.Specifications.FirstOrDefault(s => s.Id == id);
        }

        public void Add(Specification specification)
        {
            _context.Specifications.Add(specification);
            _context.SaveChanges();
        }

        public void Update(Specification specification)
        {
            _context.Specifications.Update(specification);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var specification = _context.Specifications.FirstOrDefault(s => s.Id == id);
            if (specification != null)
            {
                _context.Specifications.Remove(specification);
                _context.SaveChanges();
            }
        }
    }

}
