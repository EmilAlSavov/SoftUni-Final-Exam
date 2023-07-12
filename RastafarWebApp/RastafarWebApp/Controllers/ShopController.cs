using Microsoft.AspNetCore.Mvc;

namespace RastafarWebApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
