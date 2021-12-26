using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentAndDrive.Models;
using RentAndDrive.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Controllers
{
    public class CarAdminPanelController : Controller
    {

        Context c = new Context();
        CarRepository carRepository = new CarRepository();

  
        public IActionResult CarList()
        {
            var carList = carRepository.TList("Category");
            return View(carList);

        }
        [HttpGet]
        public IActionResult CarAdd()
        {
            //Dropbox menü
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }
                                           ).ToList();
            ViewBag.value = values;

            return View();
        }
        public IActionResult CarAdd(Car p)
        {


            carRepository.TAdd(p);
            return RedirectToAction("CarList");
        }
        public IActionResult CarDelete(int id)
        {
            carRepository.TDelete(new Car { CarId = id });
            return RedirectToAction("CarList");
        }
        
        public IActionResult CarGet(int id)
        {
            var x = carRepository.TGet(id);
            List<SelectListItem> values = (from y in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryId.ToString()
                                           }
                                          ).ToList();
            ViewBag.value = values;
            Car cr = new Car()
            {
                CarId = x.CarId,
                CategoryId = x.CategoryId,
                CarName = x.CarName,
                Model = x.Model,
                Price = x.Price,
                Year = x.Year,
                Vites = x.Vites,
                Km = x.Km,
                Yakit = x.Yakit,
                ImageUrl = x.ImageUrl

            };
            return View(cr);
        }
        [HttpPost]
        public IActionResult CarUpdate(Car cr)
        {
            var x = carRepository.TGet(cr.CarId);

            x.CarName = cr.CarName;
            x.Model = cr.Model;
            x.Price = cr.Price;
            x.Year = cr.Year;
            x.Vites = cr.Vites;
            x.Km = cr.Km;
            x.Yakit = cr.Yakit;
            x.ImageUrl = cr.ImageUrl;
            x.CategoryId = cr.CategoryId;
            carRepository.TUpdate(x);
            return RedirectToAction("CarList");
        }
        
    }
}
