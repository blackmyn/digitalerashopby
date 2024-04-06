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
    public class BrandService(IBrandRepository brandRepository, IMapper mapper) : IBrandService
    {
        private IMapper _mapper = mapper;
        private IBrandRepository _brandRepository = brandRepository;

        public IEnumerable<BrandDto> GetAll()
        {
            var brands = _brandRepository.GetAll();
            return _mapper.Map<IEnumerable<BrandDto>>(brands);
        }

        public void Add(BrandDto productDTO)
        {
            var brand = _mapper.Map<Brand>(productDTO);
            _brandRepository.Add(brand);
        }

        public void DeleteById(int brandId)
        {
            _brandRepository.Delete(brandId);
        }

        public BrandDto GetById(int id)
        {
            var brand = _brandRepository.GetById(id);
            return _mapper.Map<BrandDto>(brand);
        }

        public void Update(BrandDto productDTO)
        {
            var brands = _mapper.Map<Brand>(productDTO);
            _brandRepository.Update(brands);
        }
    }
}
