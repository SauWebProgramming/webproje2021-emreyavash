using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Models;
using RentAndDrive.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.Controllers
{
    public class ContactAdminPanelController : Controller
    {
        ContactRepository contactRepository = new ContactRepository();
        

        public IActionResult Index()
        {
            var messageList = contactRepository.TList();
            return View(messageList);
        }
        public IActionResult ContactDelete(int id)
        {
            contactRepository.TDelete(new Contact { CustomerId = id });
            return RedirectToAction("Index");
        }
    }
}
