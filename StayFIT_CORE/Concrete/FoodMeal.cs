using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_CORE.Concrete
{
    public class FoodMeal
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public virtual Food Food { get; set; }
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }
    }
}
