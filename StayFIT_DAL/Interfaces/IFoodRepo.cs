using StayFIT_CORE.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Interfaces
{
    public interface IFoodRepo : IBaseRepo<Food>
    {
        IList<Food> GetFoodByMeal(int mealId);
        IList<Food> GetFoodsByCategory(int categoryId);
    }
}
