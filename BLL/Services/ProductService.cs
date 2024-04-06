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

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
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
    }
}
