using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Cars 
                    { 
                        name = "mers s", isFavorite = true, price = 50000, 
                        Category = Categories["Двс"] 
                    },
                    new Cars
                    {
                        name = "Tesla",
                        isFavorite = false,
                        price = 30000,
                        Category = Categories["электромобиль"]
                    },
                      new Cars
                      {
                          name = "audi a7",
                          isFavorite = true,
                          price = 60000,
                          Category = Categories["Двс"]
                      }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "электромобиль", description = "Электрические" },
                        new Category { categoryName = "Двс", description = "С двигателем" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (var element in list)
                    {
                        category.Add(element.categoryName, element);
                    }
                    
                };
                return category;
            }
        }
    }
}
