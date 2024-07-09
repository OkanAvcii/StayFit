using StayFIT_CORE.Concrete;
using StayFIT_SERVICE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.Services.MealService
{
    public interface IMealService
    {
        int Create(MealCreateDTO meal);
        List<Food> GetMeals();
        List<Food> GetCategories();
        List<Food> GetFoodItemsByCategory(Category category);
    }
}
