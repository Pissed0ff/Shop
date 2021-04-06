using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int carId { get; set; }
        public uint price { get; set; }

        public virtual Cars car { get; set; }
        public virtual Order order { get; set; }
 
    }
}
