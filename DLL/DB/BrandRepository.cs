using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Models;
using System.Collections.Generic;
using System.Linq;
using DLL.Interfaces;

namespace DLL.DB
{


    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _context;

        public BrandRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetAll()
        {
            return _context.Brands.ToList();
        }

        public Brand GetById(int id)
        {
            return _context.Brands.FirstOrDefault(b => b.Id == id);
        }

        public void Add(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
        }

        public void Update(Brand brand)
        {
            _context.Brands.Update(brand);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var brand = _context.Brands.FirstOrDefault(b => b.Id == id);
            if (brand != null)
            {
                _context.Brands.Remove(brand);
                _context.SaveChanges();
            }
        }
    }

}
