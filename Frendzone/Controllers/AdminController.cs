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
        private RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<User> usrMng, RoleManager<IdentityRole> roleMng)
        {
            _userManager = usrMng;
            _roleManager = roleMng;
        }

        public IActionResult Index() => View(_userManager.Users);

        public IActionResult Roles() => View(_roleManager.Roles);

    }
}