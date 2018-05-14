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
     public class ClassRepository : IClassRepository, IDisposable
    {
        ChildCareContext context;

        public ClassRepository(ChildCareContext context)
        {
            this.context = context;
        }

        public IEnumerable<Addclass> GetAll()
        {
            return context.ClassData.ToList();
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
        public Addclass Get(int id)
        {
            return context.ClassData.Find(id);
        }

        public Addclass Add(Addclass item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            context.ClassData.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            Addclass p = context.ClassData.Find(id);
            context.ClassData.Remove(p);
        }

        public bool Update(Addclass item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }
        public Addclass PatchUpdate(Addclass item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            return new Addclass()
            {
                Name = item.Name,
                Max_no_of_student = item.Max_no_of_student,
                Students_enrolled = item.Students_enrolled,
                Min_age = item.Min_age,
                Max_age = item.Max_age,
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
