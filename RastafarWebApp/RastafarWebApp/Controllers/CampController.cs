using Microsoft.AspNetCore.Mvc;

namespace RastafarWebApp.Controllers
{
    public class CampController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
