using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_DAL.Interfaces
{
    public interface IFoodMealRepo
    {
        int Create(int FoodId, int MealId);
    }
}
