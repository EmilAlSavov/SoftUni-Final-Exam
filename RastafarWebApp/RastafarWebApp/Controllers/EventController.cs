using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices.ViewModels.Import;
using RastafarWebApp.Data.Models.Enums;
using System.Security.Claims;

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

            var models = postService.All(allPostQueryModel.CampType, allPostQueryModel.SearchingTerm, allPostQueryModel.Sort, allPostQueryModel.CurrentPage, AllPostQueryModel.PostsPerPages);

            allPostQueryModel.TotalEventCount = models.TotalEventCount;
            allPostQueryModel.Posts = models.Posts;
            allPostQueryModel.CampTypes = postService.GetEnumList<CampType>();
            allPostQueryModel.Sorts = postService.GetEnumList<EventSort>();
            return View(allPostQueryModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddPostViewModel model)
        {
            if (ModelState.IsValid)
            {
                postService.Add(model, GetUserId());
            }
            else
            {
                return View(model);
            }

            return RedirectToAction("All", "Event");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var post = postService.GetPostById(Id);

            var model = new AddPostViewModel()
            {
                Name = post.Name,
                Description = post.Description,
                Destination = post.Destination,
                ImgsUrl = post.ImgsUrl,
                campType = post.campType,
                travelType = post.travelType
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(AddPostViewModel model, int Id)
        {
            if (ModelState.IsValid)
            {
                postService.Edit(model, Id);
            }
            else
            {
                return View(model);
            }

            return RedirectToAction("All", "Event");
        }

        public IActionResult Delete(int Id)
        {
            postService.Delete(Id);

            return RedirectToAction("All", "Event");
        }

        public IActionResult Join(int Id)
        {
            var userId = GetUserId();

            postService.Join(Id, userId);

            return RedirectToAction("All", "Event");
        }

        public IActionResult Leave(int Id)
        {
            string userId = GetUserId();

            postService.Leave(Id, userId);

            return RedirectToAction("All", "Event");
        }

		private string GetUserId()
		{
			return User.FindFirstValue(ClaimTypes.NameIdentifier);
		}
	}
}
