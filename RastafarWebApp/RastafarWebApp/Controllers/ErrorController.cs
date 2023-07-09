using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RastafarWebApp.Controllers
{
	public class ErrorController : BaseController
	{
		[AllowAnonymous]
		public IActionResult Index(int statusCode)
		{
			if (statusCode == 204)
			{
				return RedirectToAction("Error204", "Error");
			}

			if (statusCode == 401)
			{
				return RedirectToAction("Error401", "Error");
			}

			if (statusCode == 404)
			{
				return RedirectToAction("Error404", "Error");
			}

			return View();
		}
		[AllowAnonymous]
		public IActionResult Error204()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Error401()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Error404()
		{
			return View();
		}
	}
}
