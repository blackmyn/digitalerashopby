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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            var categories = _categoryRepository.GetAll();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }

        public void Add(CategoryDto categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            _categoryRepository.Add(category);
        }

        public void DeleteById(int categoryId)
        {
            _categoryRepository.Delete(categoryId);
        }

        public CategoryDto GetById(int id)
        {
            var category = _categoryRepository.GetById(id);
            return _mapper.Map<CategoryDto>(category);
        }

        public void Update(CategoryDto categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            _categoryRepository.Update(category);
        }
        public CategoryDto GetByName(string name)
        {
            var category = _categoryRepository.GetByName(name);
            return _mapper.Map<CategoryDto>(category);
        }
    }

}
