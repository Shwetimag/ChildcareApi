using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChildcareApi.Models;
using System.Data.Entity;

namespace Repository
{
    public class ParticipantRepository : IParticipantRepository, IDisposable
    {
        ChildCareContext context;

        public ParticipantRepository(ChildCareContext context)
        {
            this.context = context;
        }

        public IEnumerable<Participant> GetAll()
        {
            return context.ParticipantData.ToList();
        }

        //public IEnumerable<Employee> GetAll(int? page)
        //{
        //    int pageNo = 0;
        //    pageNo = page == null ? 1 : int.Parse(page.ToString());

        //    int totalEmployee = context.employee.Count();
        //    int employeePerPage = 3;
        //    int inEachPageEmployeeEndAt = pageNo * employeePerPage;
        //    int inEachPageEmployeeStartsFrom = inEachPageEmployeeEndAt - employeePerPage;
        //    var employees = context.employee.OrderBy(e => e.Id).Skip(inEachPageEmployeeStartsFrom).Take(employeePerPage);
        //    Pager<Employee> pager = new Pager<Employee>(employees.AsQueryable(), pageNo, employeePerPage, totalEmployee);
        //    return pager;
        //   // return context.employee.ToList();
        //}
        public Participant Get(int id)
        {
            return context.ParticipantData.Find(id);
        }

        public Participant Add(Participant item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            context.ParticipantData.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            Participant p = context.ParticipantData.Find(id);
            context.ParticipantData.Remove(p);
        }

        public bool Update(Participant item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }
        public Participant PatchUpdate(Participant item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            return new Participant()
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                Gender = item.Gender,
                DateOfBirth = item.DateOfBirth,
                Country = item.Country,
                State = item.State,
                City = item.City,
                Street = item.Street,
                ZipCode = item.ZipCode,
               
                BloodGroup = item.BloodGroup,
                EnrollmentDate = item.EnrollmentDate,
                MotherName = item.MotherName,
                Occupation = item.Occupation,
                Email = item.Email,
                CellPhone = item.CellPhone,
                FatherName = item.FatherName,
                FOccupation = item.FOccupation,
                FEmail = item.FEmail,
                FCellPhone=item.FCellPhone,
                GuardianName=item.GuardianName,
                GCellPhone=item.GCellPhone,
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
