using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class Category {
        [Key]
        public int id { get; set; }
        public string description { get; set; }
        public string categoryName { get; set; }

        public List<Cars> cars = new List<Cars>
        {
        };

    }
}
