using StayFIT_CORE.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.DTOs
{
    public class MealCreateDTO
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public IList<FoodGetDTO> Foods { get; set; }
        public MealCreateDTO()
        {
            Foods = new List<FoodGetDTO>();
        }
    }
}
