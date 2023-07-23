using HiparAppServices.Admin;
using HiparAppServices.Services.Admin;
using HiparAppServices.ViewModels;
using Microsoft.AspNetCore.Mvc;
using RastafarAppServices.ViewModels;

namespace HiparWebApp.Controllers.Admin
{
	public class CountryController : Controller
	{
		private readonly ICountryService countryService;

		public CountryController(ICountryService countryService)
		{
			this.countryService = countryService;
		}

		public IActionResult Index()
		{
			return RedirectToAction("All", "Category");
		}

		public IActionResult All()
		{
			var models = countryService.All();
			return View(models);
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(CountryViewModel model)
		{
			await countryService.AddAsync(model);
			return RedirectToAction("All", "Camptype");
		}

		public async Task<IActionResult> Delete(Guid Id)
		{
			await countryService.DeleteAsync(Id);

			return RedirectToAction("All", "Camptype");
		}

		[HttpGet]
		public async Task<IActionResult> Edit(Guid Id)
		{
			var campType = await countryService.GetCampTypeByIdAsync(Id);

			var model = new CountryViewModel()
			{
				Name = campType.Name
			};

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(Guid Id, CountryViewModel model)
		{
			await countryService.EditAsync(Id, model);
			return RedirectToAction("All", "Camptype");
		}
	}
}
