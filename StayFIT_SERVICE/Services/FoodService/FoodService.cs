using StayFIT_DAL.Interfaces;
using StayFIT_SERVICE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.Services.FoodService
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepo _foodRepo;

        public FoodService(IFoodRepo foodRepo)
        {
            _foodRepo = foodRepo;
        }

        public IList<FoodGetDTO> GetFoodsByCategoryId(int categoryId)
        {
            return _foodRepo.GetFoodsByCategoryId(categoryId)
                .Select(x => new FoodGetDTO { Name = x.Name, Calory = x.Calory })
                .ToList();
        }
    }
}
