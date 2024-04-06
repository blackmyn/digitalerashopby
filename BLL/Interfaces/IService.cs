using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IService<T>
    {
        void Add(T item);
        void Update(T item);
        void DeleteById(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
