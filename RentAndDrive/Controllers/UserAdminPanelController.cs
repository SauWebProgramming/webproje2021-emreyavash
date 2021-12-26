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
    public class UserAdminPanelController : Controller
    {
        Context c = new Context();

        UserRepository userRepository = new UserRepository();
       

        public IActionResult Index()
        {
            var userList = userRepository.TList();
            return View(userList);
        }
        public IActionResult UserDelete(int id)
        {
            userRepository.TDelete(new User { UserId = id });
            return RedirectToAction("Index");
        }
        public IActionResult UserGet(int id)
        {
            var x = userRepository.TGet(id);
          
            User usr = new User()
            {
                UserId = x.UserId,
                UserName = x.UserName,
                UserSurname = x.UserSurname,
                Email = x.Email,
                Password = x.Password,
                BirthDay = x.BirthDay,
                Phone = x.Phone,
                Role = x.Role,
                

            };
            return View(usr);
        }
        [HttpPost]
        public IActionResult UserUpdate(User usr)
        {
            var x = userRepository.TGet(usr.UserId);

            x.UserName = usr.UserName;
            x.UserSurname = usr.UserSurname;
            x.Email = usr.Email;
            x.Password = usr.Password;
            x.BirthDay = usr.BirthDay;
            x.Phone = usr.Phone;
            x.Role = usr.Role;

            userRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
