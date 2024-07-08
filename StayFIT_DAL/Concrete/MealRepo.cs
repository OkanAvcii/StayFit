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
    public class MealRepo : BaseRepo<Meal>, IMealRepo
    {
        private readonly StayFITDbContext _context;
        public MealRepo(StayFITDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<Meal> GetByDate(DateTime startDate, DateTime endDate)
        {
            return _context.Meals.Where(x => x.UserDailyActivity.DateTime >= startDate && x.UserDailyActivity.DateTime <= endDate).ToList();
        }
    }
}
