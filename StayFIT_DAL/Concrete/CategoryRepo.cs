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
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        private readonly StayFITDbContext _context;
        public CategoryRepo(StayFITDbContext context) : base(context)
        {
            _context = context;
        }

        
    }
}
