using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name="Введите имя")]
        [StringLength(2)]
        [Required(ErrorMessage ="Длина имени не менее 2 символов")]
        public string name { get; set; }

        [Display(Name = "Введите Фамилию")]
        [StringLength(2)]
        [Required(ErrorMessage = "Длина не менее 2 символов")]
        public string surname { get; set; }
        [Display(Name = "Адрес")]
        [StringLength(3)]
        [Required(ErrorMessage = "Длина имени не менее 3 символов")]
        public string adress { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Введите имя")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина  не менее 11 символов")]
        public string phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
