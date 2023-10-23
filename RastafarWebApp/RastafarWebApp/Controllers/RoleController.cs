using HiparAppData.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RastafarAppServices.ViewModels.Import;

namespace RastafarWebApp.Controllers
{
	public class RoleController : BaseController
	{
		private readonly RoleManager<IdentityRole> roleManager;
		private readonly UserManager<ApplicationUser> userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
			this.roleManager = roleManager;
			this.userManager = userManager;
        }

        public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateRole()
		{
			return View();
		}


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateRole(string roleName)
		{
			if (await roleManager.RoleExistsAsync(roleName))
			{
				return BadRequest();
			}
			var result = await roleManager.CreateAsync(new IdentityRole(roleName));

			return Ok(result);
		}

        [HttpGet]
		[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GiveRole()
        {
            return View();
        }

		[HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GiveRole(RoleViewModel roleModel)
		{
			var user = userManager.Users.FirstOrDefault(u => u.UserName == roleModel.UserName);

			if (!await roleManager.RoleExistsAsync(roleModel.RoleName))
			{
				return BadRequest();
			}
			var result = await userManager.AddToRoleAsync(user, roleModel.RoleName);
			return Ok(result);
		}
	}
}
