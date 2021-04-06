using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDBContent appDbContent;
        private readonly ShopCart shopCart;
        public OrderRepository (AppDBContent appDbContent, ShopCart shopCart)
        {
            this.appDbContent = appDbContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDbContent.order.Add(order);
            appDbContent.SaveChanges();

            var items = shopCart.ListShopItemes;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail
                {
                    carId = el.car.myid,
                    orderId = order.id,
                    price = el.car.price
                };
                appDbContent.orderDetails.Add(orderDetail);
            }
            appDbContent.SaveChanges();
        }
    }
}
