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
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public CartService(ICartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        public IEnumerable<CartDto> GetAll()
        {
            var carts = _cartRepository.GetAll();
            return _mapper.Map<IEnumerable<CartDto>>(carts);
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
