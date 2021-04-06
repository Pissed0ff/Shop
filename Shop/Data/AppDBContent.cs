using Microsoft.EntityFrameworkCore;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        { }

        public DbSet<Cars> Car {get;set;}
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> shopCartItems { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
    }
}
