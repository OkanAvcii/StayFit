using StayFIT_DAL.Interfaces;
using StayFIT_SERVICE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayFIT_SERVICE.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoryService(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public IList<CategoryGetDTO> GetAll()
        {
            return _categoryRepo.GetAll().Select(x => new CategoryGetDTO { Id = x.Id, Name = x.Name }).ToList();
        }

        public IList<CategoryGetDTO> GetAllActive()
        {
            return _categoryRepo.GetFilteredList(
                select: x => new CategoryGetDTO { Id = x.Id, Name = x.Name },
                orderBy: x => x.OrderBy(x => x.Name));
        }

        public CategoryGetDTO GetById(int id)
        {
            if (_categoryRepo.GetAny(x => x.Id == id))
            {
                var category = _categoryRepo.GetById(id);
                var catDto = new CategoryGetDTO { Id = category.Id, Name = category.Name };
                return catDto;
            }
            else
                throw new Exception("Böyle bir kategori bulunamamaktadır.");
        }

        public IList<CategoryGetDTO> GetByName(string name)
        {
            return _categoryRepo.GetFilteredList(
                select: x => new CategoryGetDTO { Id = x.Id, Name = x.Name },
                where: x => x.Name.Contains(name));
        }
    }
}
