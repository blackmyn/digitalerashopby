using AutoMapper;
using BLL.DTOModels;
using BLL.Interfaces;
using DLL.DB;
using DLL.Interfaces;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProdSpecService : IProcSpecService
    {
        private readonly IProdSpec _prodspecRepository;
        private readonly IMapper _mapper;

        public ProdSpecService(IProdSpec productRepository, IMapper mapper)
        {
            _prodspecRepository = productRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProdSpecDto> GetAll()
        {
            var products = _prodspecRepository.GetAll();
            return _mapper.Map<IEnumerable<ProdSpecDto>>(products);
        }

        public void Add(ProdSpecDto productDTO)
        {
            var product = _mapper.Map<ProdSpec>(productDTO);
            _prodspecRepository.Add(product);
        }

        public void DeleteById(int productId)
        {
            _prodspecRepository.Delete(productId);
        }

        public ProdSpecDto GetById(int id)
        {
            var product = _prodspecRepository.GetById(id);
            return _mapper.Map<ProdSpecDto>(product);
        }

        public void Update(ProdSpecDto productDTO)
        {
            var product = _mapper.Map<ProdSpec>(productDTO);
            _prodspecRepository.Update(product);
        }
        public IEnumerable<ProdSpecDto> GetByProductId(int productId)
        {
            var specifications = _prodspecRepository.GetAll().Where(spec => spec.ProductId == productId);
            return _mapper.Map<IEnumerable<ProdSpecDto>>(specifications);
        }
    }
}
