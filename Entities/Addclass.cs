    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Addclass
    {
        [Key]
        public int CId { get; set; }
        public string Name { get; set; }
        public string Max_no_of_student { get; set; }
        public string Students_enrolled { get; set; }
        public string Min_age { get; set; }
        public string Max_age { get; set; }
        public string Start_time { get; set; }
        public string End_time { get; set; }
    }
}
