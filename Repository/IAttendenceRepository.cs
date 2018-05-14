using ChildcareApi.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IAttendenceRepository
    {
        IEnumerable<Attendence> GetAll();
        //IEnumerable<Employee> GetAll(int? page);
        Attendence Get(int id);
        Attendence Add(Attendence item);
        bool Update(Attendence item);
        void Remove(int id);
        Attendence PatchUpdate(Attendence item);
        void Save();
    }
}
