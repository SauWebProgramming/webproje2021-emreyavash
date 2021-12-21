using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Models;
using RentAndDrive.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Controllers
{
    public class CarController : Controller
    {
        CarRepository carRepository = new CarRepository();
        Context c = new Context();
        public IActionResult Index()
        {
            var carList=c.Cars.ToList();
            return View(carRepository.TList());
        }
       
    }
}
