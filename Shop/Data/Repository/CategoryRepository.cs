using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Repository
{
    public class CategoryRepository : IAllCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDbContent)
        {
            this.appDBContent = appDbContent;
        }
        public IEnumerable<Category> getAllCategories => appDBContent.Category;
    }
}
