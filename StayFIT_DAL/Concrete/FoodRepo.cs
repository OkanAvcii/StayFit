using StayFIT_CORE.Concrete;
using StayFIT_DAL.Context;
using StayFIT_DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Concrete
{
    public class FoodRepo : BaseRepo<Food>, IFoodRepo
    {
        private readonly StayFITDbContext _context;
        public FoodRepo(StayFITDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<Food> GetFoodByMeal(int mealId)
        {
            return _context.Foods.Where(x => x.Id == mealId).ToList();
            //Buradaki id fooddan geliyor meal classından gelmesi gerekmiyormu!!!!!!!!!!!!!Hocaya sor.
        }

        public IList<Food> GetFoodsByCategory(int categoryId)
        {
            return _context.Foods.Where(x => x.Id == categoryId).ToList();
        }
    }
}
