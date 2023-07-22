using HiparAppServices.Services.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RastafarAppServices.ViewModels;
using RastafarWebApp.Controllers;

namespace HiparWebApp.Controllers.Admin
{
    [Authorize(Roles = "Admin")]
    public class CamptypeController : BaseController
    {
        private readonly ICampTypeService campTypeService;

        public CamptypeController(ICampTypeService campTypeService)
        {
            this.campTypeService = campTypeService;
        }
        public IActionResult Index()
        {
            return RedirectToAction("All", "Camptype");
        }

        public IActionResult All()
        {
            var models = campTypeService.All();
            return View(models);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CampTypeViewModel model)
        {
            await campTypeService.AddAsync(model);
            return RedirectToAction("All", "Camptype");
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            await campTypeService.DeleteAsync(Id);

            return RedirectToAction("All", "Camptype");
        }
    }
}
