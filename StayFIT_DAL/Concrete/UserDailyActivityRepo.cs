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
    public class UserDailyActivityRepo : BaseRepo<UserDailyActivity>, IUserDailyActivityRepo
    {
        private readonly StayFITDbContext _context;
        public UserDailyActivityRepo(StayFITDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<UserDailyActivity> GetByDate(DateTime startDate, DateTime endDate, int userId)
        {
            return _context.UserDailyActivities.Where(x => x.DateTime >= startDate && x.DateTime <= endDate && x.UserId == userId).ToList();
        }

        public IList<UserDailyActivity> GetDailyActivitiesByUser(int userId)
        {
            return _context.UserDailyActivities.Where(x => x.Id == userId).ToList();
        }
    }
}
