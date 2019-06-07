using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frendzone.Data.Interfaces;
using Frendzone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Frendzone.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IEventRepository _eventRepository;

        public AdminController(
            UserManager<User> usrMng, 
            RoleManager<IdentityRole> roleMng,
            ICategoryRepository categoryRepo,
            IEventRepository eventRepo
            )
        {
            _userManager = usrMng;
            _roleManager = roleMng;
            _categoryRepository = categoryRepo;
            _eventRepository = eventRepo;
        }

        public IActionResult Index() => View(_userManager.Users);

        public IActionResult Roles() => View(_roleManager.Roles);

        public IActionResult Categories() => View(_categoryRepository.All());

        public IActionResult Events() => View(_eventRepository.All());

    }
}