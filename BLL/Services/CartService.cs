using AutoMapper;
using BLL.DTOModels;
using BLL.Interfaces;
using DLL.DB;
using DLL.Interfaces;
using DLL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public CartService(ICartRepository cartRepository, IMapper mapper, IProductRepository productRepository)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
            _productRepository = productRepository;

        }
        public IEnumerable<CartDto> GetCartItemsForUser(string userId)
        {
            var carts = _cartRepository.GetAll().Where(c => c.UserId == userId);
            var cartDtos = _mapper.Map<IEnumerable<CartDto>>(carts);

            foreach (var cartDto in cartDtos)
            {
                var product = _productRepository.GetById(cartDto.ProductId);
                cartDto.Product = _mapper.Map<ProductDto>(product);
            }

            return cartDtos;
        }

        public IEnumerable<CartDto> GetAll()
        {
            var carts = _cartRepository.GetAll();
            var cartDtos = _mapper.Map<IEnumerable<CartDto>>(carts);
            foreach (var cartDto in cartDtos)
            {
                var product = _productRepository.GetById(cartDto.ProductId);
                cartDto.Product = _mapper.Map<ProductDto>(product);
            }
            return cartDtos;
        }

        public void Add(CartDto cartDTO)
        {
            var cart = _mapper.Map<Cart>(cartDTO);
            _cartRepository.Add(cart);
        }

        public void DeleteById(int cartId)
        {
            _cartRepository.Delete(cartId);
        }

        public CartDto GetById(int id)
        {
            var cart = _cartRepository.GetById(id);
            return _mapper.Map<CartDto>(cart);
        }

        public void Update(CartDto cartDTO)
        {
            var cart = _mapper.Map<Cart>(cartDTO);
            _cartRepository.Update(cart);
        }
    }

}
