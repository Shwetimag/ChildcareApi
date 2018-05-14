using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Attendence
    {
        [Key]
        public int AId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class1 { get; set; }
        public string Start_time { get; set; }
        public string End_time { get; set; }
    }
}
