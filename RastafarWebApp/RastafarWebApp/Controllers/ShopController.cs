using Microsoft.AspNetCore.Mvc;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices;
using RastafarAppServices.Services;

namespace RastafarWebApp.Controllers
{
    public class ShopController : Controller
    {
		private readonly IProductService productService;

        public ShopController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
			return RedirectToAction("All", "Shop");
		}
		public IActionResult All(AllProductQueryModel productQueryModel)
        {
			var model = productService.All(productQueryModel.SearchingTerm, productQueryModel.Sort, productQueryModel.CurrentPage, AllProductQueryModel.ProductsPerPages);

			productQueryModel.TotalProductCount = model.TotalProductCount;
			productQueryModel.Products = model.Products;
			productQueryModel.Sorts = productService.GetEnumList<EventSort>();

			return View(productQueryModel);
		}

        public IActionResult Detail(Guid id)
        {
            var model = productService.Detail(id);

            return View(model);
        }
    }
}
