using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.DTOs
{
    public class FoodGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calory { get; set; }
        public string Description { get; set; }
    }
}
