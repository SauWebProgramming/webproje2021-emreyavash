using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using RentAndDrive.Models;
using RentAndDrive.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Controllers
{
    [AllowAnonymous]

    public class ContactController : Controller
    {
        //private readonly IStringLocalizer<ContactController> _localizer;
        //public ContactController(IStringLocalizer<ContactController> localizer)
        //{
        //    _localizer = localizer;
            
        //}
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
