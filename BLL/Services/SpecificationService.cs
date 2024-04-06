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
    public class SpecificationService : ISpecificationServce
    {
        private readonly ISpecificationRepository _specificationRepository;
        private readonly IMapper _mapper;

        public SpecificationService(ISpecificationRepository specificationRepository, IMapper mapper)
        {
            _specificationRepository = specificationRepository;
            _mapper = mapper;
        }

        public IEnumerable<SpecificationDto> GetAll()
        {
            var specifications = _specificationRepository.GetAll();
            return _mapper.Map<IEnumerable<SpecificationDto>>(specifications);
        }

        public void Add(SpecificationDto specificationDTO)
        {
            var specification = _mapper.Map<Specification>(specificationDTO);
            _specificationRepository.Add(specification);
        }

        public void DeleteById(int specificationId)
        {
            _specificationRepository.Delete(specificationId);
        }

        public SpecificationDto GetById(int id)
        {
            var specification = _specificationRepository.GetById(id);
            return _mapper.Map<SpecificationDto>(specification);
        }

        public void Update(SpecificationDto specificationDTO)
        {
            var specification = _mapper.Map<Specification>(specificationDTO);
            _specificationRepository.Update(specification);
        }
    }

}
