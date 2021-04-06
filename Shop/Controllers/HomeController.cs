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
    public class HomeController: Controller
    {
        private readonly IAllCars _carRep;

        public HomeController(IAllCars carRepository)
        {
            _carRep = carRepository;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModels
            {
                favCars = _carRep.getFavCars
            };
            return View(homeCars);
        }
    }
}
