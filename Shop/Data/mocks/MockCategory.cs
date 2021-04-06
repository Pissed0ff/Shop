using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.mocks
{
    public class MockCategory : IAllCategory
    {
        public IEnumerable<Category> getAllCategories {
            get {
                return new List<Category>{
            new Category {categoryName = "электромобиль", description = "Электрические"},
            new Category {categoryName = "Двс" , description = "С двигателем"}
            };
            }
        }
    }
}
