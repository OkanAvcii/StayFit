using StayFIT_SERVICE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.Services.CategoryService
{
    public interface ICategoryService
    {
        CategoryGetDTO GetById(int id);
        IList<CategoryGetDTO> GetAll();
        IList<CategoryGetDTO> GetAllActive();
        IList<CategoryGetDTO> GetByName(string name);
    }
}
