using ChildcareApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public interface IParticipantRepository
    {
        IEnumerable<Participant> GetAll();
        //IEnumerable<Employee> GetAll(int? page);
        Participant Get(int id);
        Participant Add(Participant item);
        void Remove(int id);
        bool Update(Participant item);
        Participant PatchUpdate(Participant item);
        void Save();
    }
}
