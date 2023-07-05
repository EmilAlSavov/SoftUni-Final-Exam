using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RastafarAppServices;
using RastafarAppServices.Services;

namespace RastafarWebApp.Controllers
{
    public class EventController : BaseController
    {
        public IPostService postService { get; set; }

        public EventController(IPostService postService)
        {
            this.postService = postService;
        }

        [AllowAnonymous]
        public IActionResult All()
        {
            var models = postService.All();

            return View(models);
        }
    }
}
