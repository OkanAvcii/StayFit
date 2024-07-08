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
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        private readonly StayFITDbContext _context;
        public UserRepo(StayFITDbContext context) : base(context)
        {
            _context = context;
        }
        
        public User GetUserByEmail(string email, string password)
        {
            User user = _context.Users.SingleOrDefault(x => x.Email == email && x.Password == password);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("User not found");
            }
        }
    }
}
