using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DB
{
    public class ProdSpecRepository : IProdSpec
    {
        private readonly ApplicationDbContext _context;

        public ProdSpecRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProdSpec> GetAll()
        {
            return _context.ProdSpecs.ToList();
        }

        public ProdSpec GetById(int id)
        {
            return _context.ProdSpecs.FirstOrDefault(b => b.Id == id);
        }

        public void Add(ProdSpec brand)
        {
            _context.ProdSpecs.Add(brand);
            _context.SaveChanges();
        }

        public void Update(ProdSpec brand)
        {
            _context.ProdSpecs.Update(brand);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var brand = _context.ProdSpecs.FirstOrDefault(b => b.Id == id);
            if (brand != null)
            {
                _context.ProdSpecs.Remove(brand);
                _context.SaveChanges();
            }
        }
    }
}
