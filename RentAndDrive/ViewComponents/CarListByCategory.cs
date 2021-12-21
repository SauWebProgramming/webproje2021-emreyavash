using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.ViewComponents
{
    public class CarListByCategory:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
           
            CarRepository carRepository = new CarRepository();
            var carList=carRepository.List(x => x.CategoryId == id);
            return View(carList);

        }
    }
}
