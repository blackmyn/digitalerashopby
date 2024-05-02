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
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public ProductService(IProductRepository productRepository, IMapper mapper, ICategoryService categoryService)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = _productRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public void Add(ProductDto productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            _productRepository.Add(product);
        }

        public void DeleteById(int productId)
        {
            _productRepository.Delete(productId);
        }

        public ProductDto GetById(int id)
        {
            var product = _productRepository.GetById(id);
            return _mapper.Map<ProductDto>(product);
        }

        public void Update(ProductDto productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            _productRepository.Update(product);
        }
        public IEnumerable<ProductDto> GetProductsByCategory(string category, string sort)
        {
            var categories = _categoryService.GetAll();
            var products = _productRepository.GetAll().Where(p => p.Category.Name == category);
            switch (sort)
            {
                case "price_asc":
                    products = products.OrderBy(p => p.Price);
                    break;
                case "price_desc":
                    products = products.OrderByDescending(p => p.Price);
                    break;
                case "name_asc":
                    products = products.OrderBy(p => p.Name);
                    break;
                case "name_desc":
                    products = products.OrderByDescending(p => p.Name);
                    break;
            }
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }
        public IEnumerable<ProductDto> GetProductsByName(string name)
        {
            var products = _productRepository.GetAll().Where(p => p.Name.Contains(name));
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

    }
}
