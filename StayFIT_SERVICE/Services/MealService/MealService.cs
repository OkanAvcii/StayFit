using StayFIT_CORE.Concrete;
using StayFIT_DAL.Interfaces;
using StayFIT_SERVICE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.Services.MealService
{
    public class MealService : IMealService
    {
        private readonly IMealRepo _mealRepo;
        public MealService(IMealRepo repo)
        {
            _mealRepo = repo;
        }
        public int Create(MealCreateDTO meal)
        {
            try
            {
                var mealCr = new Meal { Name = meal.Name };
                return _mealRepo.Create(mealCr);
            }
            catch (Exception ex)
            {
                throw new Exception("Beklenmeyen bir hata gerçekleşti..." + ex.Message);
            }
        }

        public List<Food> GetCategories()
        {
            throw new NotImplementedException();
        }

        public List<Food> GetFoodItemsByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Food> GetMeals()
        {
            throw new NotImplementedException();
        }
    }
}
