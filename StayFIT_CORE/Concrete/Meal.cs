using StayFIT_CORE.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_CORE.Concrete
{
    public class Meal : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FoodMeal> FoodMeals { get; set; }
        public virtual UserDailyActivity UserDailyActivity { get; set; }
        public int UserDailyActivityId { get; set; }
        public Meal()
        {
            FoodMeals = new HashSet<FoodMeal>();
        }
    }
}
