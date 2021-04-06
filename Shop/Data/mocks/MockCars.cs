using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly IAllCategory _categoryCar = new MockCategory();
        public IEnumerable<Cars> getAllCars { 
            get {
                return new List<Cars>
            {
                new Cars { name = "mers s", isFavorite = true, price = 50000, Category = _categoryCar.getAllCategories.First() },
                new Cars { name = "Tesla", isFavorite = false, price = 30000 }
            };
            }
        }

        public IEnumerable<Cars> getFavCars {
            get {
                return new List<Cars> { };
               
            }
        }

        public Cars getObjCar(int id)
        {
            return new Cars(); 
        }
    }
}
