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
    [AllowAnonymous]

    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        Context c = new Context();
        public IActionResult Index()
        {
            var category = c.Categories.ToList();
            return View(categoryRepository.TList());
        }
    }
}
