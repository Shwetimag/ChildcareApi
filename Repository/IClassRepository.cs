using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IClassRepository
    {
        IEnumerable<Addclass> GetAll();
        //IEnumerable<Employee> GetAll(int? page);
        Addclass Get(int id);
        Addclass Add(Addclass item);
        void Remove(int id);
        bool Update(Addclass item);
        Addclass PatchUpdate(Addclass item);
        void Save();
    }
}
