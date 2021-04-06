using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent appDbContent)
        {
            this.appDBContent = appDbContent;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItemes { get; set; }

        public static ShopCart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context)
            {
                ShopCartId = shopCartId
            };
        } 

        public void AddToCart(Cars car)
        {
            appDBContent.shopCartItems.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                car = car,
                price = car.price
            }) ;

            appDBContent.SaveChanges();   
        }

        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.shopCartItems.Where(c => ShopCartId == ShopCartId).Include(s => s.car).ToList();
        }
    }
}
