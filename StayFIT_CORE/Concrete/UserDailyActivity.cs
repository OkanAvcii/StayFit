using StayFIT_CORE.Abstract;
using StayFIT_CORE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_CORE.Concrete
{
    public class UserDailyActivity : IEntity
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public int ShouldTakenCalories { get; set; } //User ın girdiği kişisel bilgilerden bir metot içerisine formülü yazılıp çekilecek.
        public int StepCount { get; set; } //User günlük girecek yada bir yerden çekilecek.
        public Activity Activity { get; set; }
        public int TotalCalories { get; set; } //Gün içerisinde yediği öğünlerden hesaplanan kalori
        public virtual ICollection<Meal> Meals { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public UserDailyActivity()
        {
            Meals = new HashSet<Meal>();
        }
    }
}
