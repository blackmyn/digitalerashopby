using BLL.DTOModels;
using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IApplicationUserService
    {
        IEnumerable<ApplicationUserDto> GetAll();
        ApplicationUserDto GetById(string id);
        void Add(ApplicationUserDto entity);
        void Update(ApplicationUserDto entity);
        void DeleteById(string id);
    }
}
