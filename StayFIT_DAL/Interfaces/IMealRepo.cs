using StayFIT_CORE.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Interfaces
{
    public interface IMealRepo : IBaseRepo<Meal>
    {
        IList<Meal> GetByDate(DateTime startDate, DateTime endDate);
    }
}
