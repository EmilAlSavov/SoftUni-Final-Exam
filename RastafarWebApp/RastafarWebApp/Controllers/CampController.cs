using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RastafarAppData.Data.Models;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices.ViewModels.Import;

namespace RastafarWebApp.Controllers
{
    public class CampController : Controller
    {
        private ICampService campService { get; set; }

        public CampController(ICampService campService)
        {
            this.campService = campService;
        }
        public IActionResult Index()
        {
            return RedirectToAction("All", "Camp");
        }

        public IActionResult All(AllCampQueryModel campQueryModel)
        {
            var model = campService.All(campQueryModel.Country, campQueryModel.SearchingTerm, campQueryModel.Sort, campQueryModel.CurrentPage, AllCampQueryModel.CampsPerPages);

			campQueryModel.TotalEventCount = model.TotalEventCount;
			campQueryModel.Camps = model.Camps;
			campQueryModel.Countries = campService.GetCountriesTypesAsViewModels();
			campQueryModel.Sorts = campService.GetEnumList<CampSort>();

			return View(campQueryModel);
        }

        public IActionResult Detail(Guid id)
        {
            CampViewModel campViewModel = campService.Detail(id);

            return View(campViewModel);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add()
        {
            return View();
        }

		[HttpPost]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Add(AddCampViewModel campModel)
		{
            await campService.AddAsync(campModel);
			return View();
		}
	}
}
