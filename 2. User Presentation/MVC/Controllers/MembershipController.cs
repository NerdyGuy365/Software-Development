using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NerdyGuy.UserPresentation.MVC.Example.Controllers
{
    [Authorize]
    public class MembershipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}