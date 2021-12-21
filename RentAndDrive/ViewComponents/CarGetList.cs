using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.ViewComponents
{
    public class CarGetList:ViewComponent
    {
        CarRepository carRepository = new CarRepository();
        public IViewComponentResult Invoke()
        {
            var carList = carRepository.TList();
            return View(carList);
        }
    }
}
