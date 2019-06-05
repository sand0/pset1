using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frendzone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Frendzone.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<User> _userManager;

        public AdminController(UserManager<User> usrMng)
        {
            _userManager = usrMng;
        }

        public IActionResult Index()
        {
            return View(_userManager.Users);
        }
    }
}