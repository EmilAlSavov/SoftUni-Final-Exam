using Microsoft.AspNetCore.Mvc;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels;
using RastafarAppServices.ViewModels.Export;

namespace RastafarWebApp.Controllers.Api
{
	[ApiController]
	[Route("/api")]
	public class JqueryController : ControllerBase
	{
		private readonly IPostService postService;

        public JqueryController(IPostService postService)
        {
            this.postService = postService;
        }
        [Route("/api/all")]
		public ActionResult<AllPostQueryModel> All(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage)
		{
			return postService.All(campType, searchTerm, sort, currentPage, eventsPerPage);
		}
	}
}
