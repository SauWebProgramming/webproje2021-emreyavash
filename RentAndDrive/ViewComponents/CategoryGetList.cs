using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentAndDrive.ViewComponents
{
    public class CategoryGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var categoryList = categoryRepository.TList();
            return View(categoryList);
        }
    }
}
