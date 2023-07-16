using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RastafarAppData.Data.Models;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices.ViewModels.Import;
using System.ComponentModel;
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
            allPostQueryModel.CampTypes = postService.GetCampTypesAsViewModels();
            allPostQueryModel.Sorts = postService.GetEnumList<EventSort>();
            return View(allPostQueryModel);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Detail(Guid Id)
        {
            var post = postService.Detail(Id);

            return View(post);
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
        public IActionResult Edit(Guid Id)
        {
            //try
            //{
				var post = postService.GetPostById(Id);

				if (post.OwnerId != GetUserId())
				{
					var ex = new UnauthorizedAccessException("401");
					ex.Data.Add("401", "dadasdas");
					throw ex;
				}

				var model = new AddPostViewModel()
				{
					Name = post.Name,
					Description = post.Description,
					Destination = post.Destination,
					ImgsUrl = post.ImgsUrl,
					campType = new CampTypeViewModel()
                    {
                       Id = post.CampTypeId,
                       Name = postService.GetCampTypesAsViewModels().FirstOrDefault(ct => ct.Id == post.CampTypeId).Name
                    },
					travelType = new TravelTypeViewModel()
                    {
                        Id = post.TravelTypeId,
                        Name = postService.GetTravelTypesAsViewModels().FirstOrDefault(ct => ct.Id == post.TravelTypeId).Name
					}
				};

				return View(model);
			//}
   //         catch (Exception e)
			//{
			//	var statusCode = e.Data.Keys.Cast<string>().Single();

			//	return RedirectToAction("Index", "Error", new { statusCode });
			//}
           
        }

        [HttpPost]
        public IActionResult Edit(AddPostViewModel model, Guid Id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    postService.Edit(model, Id, GetUserId());
                }
                else
                {
                    return View(model);
                }
                    return RedirectToAction("All", "Event");
            }
            catch (Exception ex)
            {
                var statusCode = ex.Data.Keys.Cast<string>().Single();

				return RedirectToAction("Index", "Error", new { statusCode });
            }


        }

        public IActionResult Delete(Guid Id)
        {
            postService.Delete(Id);

            return RedirectToAction("All", "Event");
        }

        public IActionResult Join(Guid Id)
        {
            var userId = GetUserId();

            postService.Join(Id, userId);

            return RedirectToAction("Detail", "Event", new { Id });
        }

        public IActionResult Leave(Guid Id)
        {
            string userId = GetUserId();

            postService.Leave(Id, userId);

            return RedirectToAction("Detail", "Event", new {Id});
        }

		private string GetUserId()
		{
			return User.FindFirstValue(ClaimTypes.NameIdentifier);
		}
	}
}
