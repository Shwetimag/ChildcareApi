using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string Name { get; set; }
        public List<State> State { get; set; }
    }

    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string Name { get; set; }
        public List<City> City { get; set; }
        //Adding Foreign Key constraints for country  
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }

    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; }
        //Adding Foreign Key Constraints for State  
        public int StateId { get; set; }
        public State State { get; set; }
    }
}

