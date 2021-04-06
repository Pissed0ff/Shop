using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Cars> getAllCars { get; set; }
        public string currentCategory;
    }
}
