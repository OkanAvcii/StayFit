using StayFIT_CORE.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Interfaces
{
    public interface IUserRepo : IBaseRepo<User>
    {
        User GetUserByEmailWithPassword(string email, string password);
        User GetUserByEmail(string email);
    }
}
