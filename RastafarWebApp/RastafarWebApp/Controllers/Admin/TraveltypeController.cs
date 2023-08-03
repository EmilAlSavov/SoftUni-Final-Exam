using HiparAppServices.Admin;
using HiparAppServices.Services.Admin;
using Microsoft.AspNetCore.Mvc;
using RastafarAppServices.ViewModels;

namespace HiparWebApp.Controllers.Admin
{
    public class TraveltypeController : Controller
    {
        private readonly ITraveltypeService traveltypeService;

        public TraveltypeController(ITraveltypeService traveltypeService)
        {
            this.traveltypeService = traveltypeService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("All", "Traveltype");
        }

        public IActionResult All()
        {
            var models = traveltypeService.All();
            return View(models);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(TravelTypeViewModel model)
        {
            await traveltypeService.AddAsync(model);
            return RedirectToAction("All", "Traveltype");
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            await traveltypeService.DeleteAsync(Id);

            return RedirectToAction("All", "Traveltype");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid Id)
        {
            var travelType = await traveltypeService.GetByIdAsync(Id);

            var model = new TravelTypeViewModel()
            {
                Name = travelType.Name
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid Id, TravelTypeViewModel model)
        {
            await traveltypeService.EditAsync(Id, model);
            return RedirectToAction("All", "Traveltype");
        }
    }
}
