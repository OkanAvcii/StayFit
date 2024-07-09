using StayFIT_SERVICE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.Services.FoodService
{
    public interface IFoodService
    {
        IList<FoodGetDTO> GetFoodsByCategoryId(int categoryId);
    }
}
