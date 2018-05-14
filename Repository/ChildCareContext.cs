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
   public class ChildCareContext : DbContext
    {
        public DbSet<Participant> ParticipantData { get; set; }
        public DbSet<Image> ImageData { get; set; }
        public DbSet<Attendence> AttendenceData { get; set; }
        public DbSet<Addclass> ClassData { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public ChildCareContext() : base("DefaultConnection")
        {

        }
    }

}
