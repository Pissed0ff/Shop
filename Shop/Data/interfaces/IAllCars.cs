using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Cars> getAllCars { get;  }
        IEnumerable<Cars> getFavCars { get; }
        Cars getObjCar(int id);
    }
}
