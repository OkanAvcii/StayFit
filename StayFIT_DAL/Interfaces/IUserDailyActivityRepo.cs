using StayFIT_CORE.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Interfaces
{
    public interface IUserDailyActivityRepo : IBaseRepo<UserDailyActivity>
    {
        IList<UserDailyActivity> GetByDate(DateTime startDate, DateTime endDate, int userId);
        IList<UserDailyActivity> GetDailyActivitiesByUser(int userId);
    }
}
