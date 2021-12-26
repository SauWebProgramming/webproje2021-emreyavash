using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using RentAndDrive.Models;
using RentAndDrive.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RentAndDrive.Controllers
{
    
    [AllowAnonymous]

    public class UserController : Controller
    {
        //private readonly IStringLocalizer<UserController> _localizer;
        //public UserController(IStringLocalizer<UserController> localizer)
        //{
        //    _localizer = localizer;

        //}

        UserRepository userRepository = new UserRepository();
        Context c = new Context();
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User p)
        {
            

            if (!ModelState.IsValid)
            {
                return View();
            }
            userRepository.TAdd(p);
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var u = c.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
            var name = c.Users.Where(x=>x.Email == user.Email).Select(x=>x.UserName).FirstOrDefault();
            var surname = c.Users.Where(x=>x.Email == user.Email).Select(x=>x.UserSurname).FirstOrDefault();

            
            if (u!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.Email)
                };
                var userIdenty = new ClaimsIdentity(claims, "User");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdenty);
                TempData["Names"] =name+" "+surname;

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Home");
            }
           

            ViewBag.mesaj = "Giriş Hatalı !! Email ve Şifrenizi kontrol ediniz.";
            
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

    }
}
