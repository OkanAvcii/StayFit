using StayFIT_CORE.Concrete;
using StayFIT_DAL.Context;
using StayFIT_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Concrete
{
    public class FoodMealRepo : IFoodMealRepo
    {
        private readonly StayFITDbContext _context;
        public int Create(int FoodId, int MealId)
        {
            var foodMeal = new FoodMeal { FoodId = FoodId, MealId = MealId };
            _context.FoodMeals.Add(foodMeal);
            return _context.SaveChanges();
        }
    }
}
