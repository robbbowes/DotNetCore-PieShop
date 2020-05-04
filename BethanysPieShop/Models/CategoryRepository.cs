using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public IEnumerable<Category> AllCategories => _appDbContext.Categories;
    }
}
