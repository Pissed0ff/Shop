using Microsoft.AspNetCore.Mvc;
using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Controllers
{
    public class OrderController:Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly ShopCart _shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            _allOrders = allOrders;
            _shopCart = shopCart;
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            _shopCart.ListShopItemes = _shopCart.getShopItems();
            if (_shopCart.ListShopItemes.Count == 0)
            {
                ModelState.AddModelError("", "Корзина пуста");
            }
            if (ModelState.IsValid)
            {
                _allOrders.createOrder(order);
                return RedirectToAction("Complite");
            }
            return View(order);
        }

        public IActionResult Complite()
        {
            ViewBag.Message = "Заказ оформлен";
            return View();
        }
    }

}
