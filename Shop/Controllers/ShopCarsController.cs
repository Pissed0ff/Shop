using Microsoft.AspNetCore.Mvc;
using shop.Data.interfaces;
using shop.Data.Models;
using shop.Data.Repository;
using shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class ShopCarsController : Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCarsController(IAllCars carRepository,ShopCart shopCart)
        {
            _carRep = carRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopItemes = items;
            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
        return View(obj);
        }

        public RedirectToActionResult AddToCart(int id ) {
            var item = _carRep.getAllCars.FirstOrDefault(i => i.myid == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
                }
    }
}
