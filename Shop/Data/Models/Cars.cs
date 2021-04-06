using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class Cars
    {
       [Key]
        public int myid { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public string description { get; set; }
        public bool available { get; set; }
        public int categoryId { get; set; }
        public bool isFavorite { get; set; }
        public Category Category { get; set; }

    }
}
