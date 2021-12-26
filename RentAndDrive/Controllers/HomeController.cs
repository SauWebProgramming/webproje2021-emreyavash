using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Controllers
{
    [AllowAnonymous]

    public class HomeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            var today = DateTime.Now.ToString("yyyy-MM-dd");
            ViewBag.tdy = today;
            return View();
        }
      
        public IActionResult Cars(int id)
        {
            ViewBag.cId = id;
            
            return View();
        }
    }
}
