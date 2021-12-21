using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Models;
using RentAndDrive.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Controllers
{
    public class ContactController : Controller
    {
        ContactRepository contactRepository = new ContactRepository();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            contactRepository.TAdd(p);
            return RedirectToAction("Index");

        }
       
    }
}
