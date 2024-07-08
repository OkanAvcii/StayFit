using StayFIT_CORE.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_CORE.Concrete
{
    public class Food : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Calory { get; set; }
        public int Portion { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string? Image { get; set; }
        public virtual ICollection<FoodMeal> FoodMeals { get; set; }
        public Food()
        {
            FoodMeals = new HashSet<FoodMeal>();
        }
    }
}
