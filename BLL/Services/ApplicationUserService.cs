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
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IMapper _mapper;

        public ApplicationUserService(IApplicationUserRepository applicationUserRepository, IMapper mapper)
        {
            _applicationUserRepository = applicationUserRepository;
            _mapper = mapper;
        }

        public IEnumerable<ApplicationUserDto> GetAll()
        {
            var applicationUsers = _applicationUserRepository.GetAll();
            return _mapper.Map<List<ApplicationUserDto>>(applicationUsers);
        }

        public void Add(ApplicationUserDto applicationUserDTO)
        {
            var applicationUser = _mapper.Map<ApplicationUser>(applicationUserDTO);
            _applicationUserRepository.Add(applicationUser);
        }

        public void DeleteById(string userId)
        {
            _applicationUserRepository.Delete(userId);
        }

        public ApplicationUserDto GetById(string id)
        {
            var applicationUser = _applicationUserRepository.GetById(id);
            return _mapper.Map<ApplicationUserDto>(applicationUser);
        }

        public void Update(ApplicationUserDto applicationUserDTO)
        {
            var applicationUser = _mapper.Map<ApplicationUser>(applicationUserDTO);
            _applicationUserRepository.Update(applicationUser);
        }
    }

}
