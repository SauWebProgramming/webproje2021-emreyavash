using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentAndDrive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RentAndDrive.Controllers
{
    public class LoginAdminPanelController : Controller
    {
        Context c = new Context();
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Admin admn)
        {


            var dataValue = c.Admins.FirstOrDefault(x => x.UserName == admn.UserName && x.Password == admn.Password);
            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admn.UserName)
                };
                var userIdentity = new ClaimsIdentity(claims, "LoginAdminPanel");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("CarList", "CarAdminPanel");
            }
            else
            {
                return View();

            }
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "LoginAdminPanel");
        }
    }
}
