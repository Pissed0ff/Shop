using Microsoft.EntityFrameworkCore;
using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;
        public CarRepository(AppDBContent appDbContent)
        {
            this.appDBContent = appDbContent;
        }
        public IEnumerable<Cars> getAllCars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Cars> getFavCars => appDBContent.Car.Where(p => p.isFavorite).Include(c => c.Category);

        public Cars getObjCar(int carId)
        {
            return appDBContent.Car.FirstOrDefault(p => p.myid == carId);
        }
    }
}
