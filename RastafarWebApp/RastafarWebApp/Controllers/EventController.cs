using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RastafarWebApp.Controllers
{
    public class EventController : BaseController
    {
        [AllowAnonymous]
        public IActionResult All()
        {
            return View();
        }
    }
}
