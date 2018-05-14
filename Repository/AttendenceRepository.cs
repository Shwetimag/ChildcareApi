using ChildcareApi.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AttendenceRepository : IAttendenceRepository, IDisposable
    {
        ChildCareContext context;

        public AttendenceRepository(ChildCareContext context)
        {
            this.context = context;
        }
        public IEnumerable<Attendence> GetAll()
        {
            return context.AttendenceData.ToList();
        }
        public Attendence Get(int id)
        {
            return context.AttendenceData.Find(id);
        }

        public Attendence Add(Attendence item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            context.AttendenceData.Add(item);
            return item;
        }


        public void Remove(int id)
        {
            Attendence p = context.AttendenceData.Find(id);
            context.AttendenceData.Remove(p);
        }

        public bool Update(Attendence item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }
        public Attendence PatchUpdate(Attendence item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            return new Attendence()
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                Class1=item.Class1,
                Start_time = item.Start_time,
                End_time = item.End_time,
            };

        }

        public void Save()
        {
            context.SaveChanges();
            // throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
