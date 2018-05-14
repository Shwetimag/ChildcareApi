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
        Attendence Add(Attendence item);
        bool Update(Attendence item);
        Attendence PatchUpdate(Attendence item);
        void Save();
    }
}
