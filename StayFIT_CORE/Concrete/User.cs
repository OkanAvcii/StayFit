using StayFIT_CORE.Abstract;
using StayFIT_CORE.Enums;
using StayFIT_CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_CORE.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (UserService.IsValidName(value))
                {
                    _firstName = value.ToUpper();
                }
                else
                {
                    throw new Exception("Firstname must contain only letters.");

                }
            }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (UserService.IsValidName(value))
                {
                    _lastName = value.ToUpper();

                }
                else
                {
                    throw new Exception("Last name must contain only letters.");
                }

            }
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }

        public int Weight { get; set; }
        public virtual ICollection<UserDailyActivity> UserDailyActivity { get; set; }
        public User()
        {
            UserDailyActivity = new HashSet<UserDailyActivity>();
        }
    }
}
