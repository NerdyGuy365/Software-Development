using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NerdyGuy.Security.NetCore.Example.ViewModels;

namespace NerdyGuy.Security.NetCore.Example.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View("Index");
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel login)
        {
            return View("Logout");
        }

        public IActionResult Logout()
        {
            return View("Logout");
        }
    }
}