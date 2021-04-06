using Microsoft.AspNetCore.Mvc;
using shop.Data.interfaces;
using shop.Data.Models;
using shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCategory _allCategory;
        private readonly IAllCars _allCars;

        public CarsController(IAllCars iAllCars, IAllCategory iAllCat)
        {
            _allCars = iAllCars;
            _allCategory = iAllCat;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Cars> cars = null;
            string currentCategory = "";
            if (String.IsNullOrEmpty(category))
            {
                cars = _allCars.getAllCars.OrderBy(i => i.myid);
            }
            else
            {
                if (String.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.getAllCars.Where(c => c.Category.categoryName.Equals("электромобиль"));
                }
                else if (String.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.getAllCars.Where(c => c.Category.categoryName.Equals("Двс"));
                }
            }
        
            currentCategory = category;
            CarsListViewModel carObj = new CarsListViewModel
            {
                getAllCars = cars,
                currentCategory = currentCategory,
            };
          

            return View(carObj);
        }
    }
}
