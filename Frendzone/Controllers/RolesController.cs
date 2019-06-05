using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frendzone.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Frendzone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;

        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }


        [HttpGet("get")]
        public IEnumerable<IdentityRole> Roles() => _roleManager.Roles.ToList();


        [HttpPost("edit")]
        public async Task<IActionResult> Edit(IdentityRole r)
        {
            if (r == null)
            {
                return BadRequest();
            }
            if (!string.IsNullOrEmpty(r.Id))
            {
                if (!string.IsNullOrEmpty(r.Name))
                {
                    IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(r.Name));
                    if (result.Succeeded)
                    {
                        return Ok();
                    }
                }
                return BadRequest();
            }
            else
            {
                IdentityRole role = await _roleManager.FindByIdAsync(r.Id);
                if (role != null)
                {
                    role.Name = r.Name;
                    IdentityResult result = await _roleManager.UpdateAsync(role);
                    if (result.Succeeded)
                    {
                        return Ok(role);
                    }
                    return BadRequest();
                }
                return NotFound();
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            IdentityResult result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}