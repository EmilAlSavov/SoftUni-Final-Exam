using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels.Export;
using RastafarWebApp.Data.Models.Enums;

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
        public IActionResult All(AllPostQueryModel allPostQueryModel)
        {

            var models = postService.All(allPostQueryModel.CampType.ToString(), allPostQueryModel.SearchingTerm, allPostQueryModel.Sort, allPostQueryModel.CurrentPage, AllPostQueryModel.PostsPerPages);

            allPostQueryModel.TotalEventCount = models.TotalEventCount;
            allPostQueryModel.Posts = models.Posts;
            allPostQueryModel.CampTypes = postService.GetEnumList<CampType>();
            allPostQueryModel.Sorts = postService.GetEnumList<EventSort>();
            return View(allPostQueryModel);
        }
    }
}
