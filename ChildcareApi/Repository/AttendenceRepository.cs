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
        ApplicationDbContext context;

        public AttendenceRepository(ApplicationDbContext context)
        {
            this.context = context;
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
                CheckIn = item.CheckIn,
                CheckOut = item.CheckOut,
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
