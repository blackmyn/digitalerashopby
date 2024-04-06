using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces
{
    public interface IApplicationUserRepository
    {
        IEnumerable<ApplicationUser> GetAll();
        ApplicationUser GetById(string id);
        void Add(ApplicationUser entity);
        void Update(ApplicationUser entity);
        void Delete(string id);
    }
}
