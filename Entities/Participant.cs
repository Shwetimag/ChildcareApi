using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChildcareApi.Models
{
    public class Participant
    {
        [Key]
        public int PId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
       // public int Id { get; set; }
        public string BloodGroup { get; set; }
        public string EnrollmentDate { get; set; }
        public string MotherName { get; set; }
        public string Occupation { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string FatherName { get; set; }
        public string FOccupation { get; set; }
        public string FEmail { get; set; }
        public string FCellPhone { get; set; }
        public string GuardianName { get; set; }
        public string GCellPhone { get; set; }
    }
}