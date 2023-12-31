﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices.ViewModels.Import;
using RastafarWebApp.Data;
using RastafarWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RastafarAppServices
{
    public class PostService : IPostService
    {
        private RastafarContext context { get; set; }

		private IHostingEnvironment Environment { get; set; }

        public PostService(RastafarContext context, IHostingEnvironment environment)
        {
            this.context = context;
			this.Environment = environment;
        }

        public void Add(AddPostViewModel model, string id, HttpContext httpContext)
        {

			var path = SaveImageFile(model.ImgsUrl, httpContext);

			

			var post = new Post()
			{
				Name = model.Name,
				Description = model.Description,
				Destination = model.Destination,
				CampTypeId = model.campType.Id,
				TravelTypeId = model.travelType.Id,
				CreatedOn = DateTime.Now,
				ImgsUrl = path,
				OwnerId = id,
				Participants = new List<IdentityUserPosts>()

            };

			if (model.camp != null)
			{
				if (model.camp.Id != Guid.Empty)
				{
					post.CampId = model.camp.Id;
				}
			}
			context.Posts.Add(post);

            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var post = this.GetPostById(id);

			this.DeleteImageFile(post.ImgsUrl);
            context.Posts.Remove(post);

            context.SaveChanges();
        }

        public void Edit(AddPostViewModel model, Guid Id, string currUserId, HttpContext httpContext)
        {
            var realPost = this.GetPostById(Id);


			this.DeleteImageFile(realPost.ImgsUrl);

			var imgPath = this.SaveImageFile(model.ImgsUrl, httpContext);


            realPost.Name = model.Name;
            realPost.Description = model.Description;
            realPost.Destination = model.Destination;
            realPost.ImgsUrl = imgPath;
            realPost.CampTypeId = model.campType.Id;
            realPost.TravelTypeId = model.travelType.Id;

            if (model.camp != null)
            {
                if (model.camp.Id != Guid.Empty)
                {
                    realPost.CampId = model.camp.Id;
                }
            }

            context.SaveChanges();
        }

        public List<PostPreviewViewModel> Fauvorite()
        {
            throw new NotImplementedException();
        }


		public AllPostQueryModel All(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage)
		{
            int totalEvents = context.Posts.Count();
            var postsQuery = context.Posts.Where(p => true);
            var postsQuerytest = context.Posts.Where(p => true).ToList();

            postsQuery = FilterPosts(postsQuery, campType, searchTerm, sort);

			//var resultCount = postsQuery.ToList().Count();
   //             postsQuery = postsQuery.Skip(eventsPerPage * (currentPage - 1))
   //                 .Take(eventsPerPage);

                var posts = postsQuery
                                .Select(p => new PostPreviewViewModel()
                                {
                                    Id = p.Id,
                                    Name = p.Name,
                                    Image = p.ImgsUrl,
                                    Description = p.Description,
                                    Destination = p.Destination,
                                    CampType = p.CampType.Name,
                                    OwnerName = p.Owner.UserName,
                                    TravelType = p.TravelType.Name,
                                    ParticipantCount = p.Participants.Count(),
                                    Participants = p.Participants.Select(up => new UserPostsViewModel()
                                    {
                                        PostId = up.PostId,
                                        UserId = up.ParticipantId,
                                        UserName = up.Participant.UserName
                                    }).ToList()
                                }).ToList();

			var resultCount = posts.Count();
			posts = posts.Skip(eventsPerPage * (currentPage - 1)).Take(eventsPerPage).ToList();

            return new AllPostQueryModel()
            {
                Posts = posts,
                TotalEventCount = totalEvents,
                CurrentPage = currentPage,
				ResultCount = resultCount
            };
        }

        private IQueryable<Post> FilterPosts(IQueryable<Post> postsQuery, CampTypeViewModel campType, string searchTerm, EventSort sort)
        {
            if (campType != null)
            {
				if (campType.Id != Guid.Empty)
				{
					postsQuery = postsQuery
					.Where(p => p.CampTypeId == campType.Id);
				}
			}
           

			if (searchTerm != null)
			{
				postsQuery = postsQuery.Include(p => p.Owner)
				.Where(p => p.Name.ToLower().Contains(searchTerm.ToLower())
				|| p.Description.ToLower().Contains(searchTerm.ToLower())
				|| p.Destination.ToLower().Contains(searchTerm.ToLower())
				|| p.Owner.UserName.ToLower().Contains(searchTerm.ToLower()));
			}

			if ((int)sort == 0)
			{
				postsQuery = postsQuery.OrderByDescending(p => p.CreatedOn);
			}
			else if ((int)sort == 1)
			{
				postsQuery = postsQuery.OrderBy(p => p.Name);
			}
			else if ((int)sort == 2)
			{
				postsQuery = postsQuery
					.Include(p => p.Participants)
					.OrderByDescending(p => p.Participants.Count());

			}

            return postsQuery;
		}

		public List<string> GetEnumList<T>()
		{
			if (typeof(T).Name == "CampType")
			{
				return context.CampTypes.Select(ct => ct.Name).ToList();
			}

			return Enum.GetNames(typeof(T))
				   .Select(s => s).ToList();
		}

        public List<CampTypeViewModel> GetCampTypesAsViewModels()
        {
             return context.CampTypes.Select(ct => new CampTypeViewModel()
                    {
                        Id = ct.Id,
                        Name = ct.Name
                    }).ToList();
        }

		public void Join(Guid postId, string userId)
		{
            var userPost = new IdentityUserPosts()
            {
                PostId = postId,
                ParticipantId = userId
            };

            var post = GetPostById(postId);

			if (context.UsersPosts.Contains(userPost))
			{
				return;
			}

            context.UsersPosts.Add(userPost);
            post.Participants.Add(userPost);

            context.SaveChanges();
		}

		public void Leave(Guid postId, string userId)
		{
            Post post = GetPostById(postId);
            
            var userPost = context.UsersPosts.FirstOrDefault(p => p.PostId == postId && p.ParticipantId == userId);

            post.Participants.Remove(userPost);
            context.UsersPosts.Remove(userPost);

            context.SaveChanges();
		}

		public Post GetPostById(Guid id)
		{
            return context.Posts.FirstOrDefault(p => p.Id == id);
		}

		public List<TravelTypeViewModel> GetTravelTypesAsViewModels()
		{
			return context.TravelTypes.Select(ct => new TravelTypeViewModel()
			{
				Id = ct.Id,
				Name = ct.Name
			}).ToList();
		}

		public PostPreviewViewModel Detail(Guid postId)
		{

            var model = context.Posts.Where(p => p.Id == postId ).Select( post => new PostPreviewViewModel()
            {
                Id = post.Id,
                Name = post.Name,
                Description = post.Description,
                Destination = post.Destination,
                CampType = post.CampType.Name,
                TravelType = post.TravelType.Name,
                Image = post.ImgsUrl,
                ParticipantCount = context.UsersPosts.Where(up => up.PostId == postId).Count(),
                Participants = post.Participants.Select(p => new UserPostsViewModel()
                {
                    PostId = p.PostId,
                    UserId = p.ParticipantId,
                    UserName = p.Participant.UserName
                }).ToList(),
                OwnerName = context.Users.FirstOrDefault(u => u.Id == post.OwnerId).UserName
            }).First();

            return model;
		}

		public async Task<AllPostQueryModel> JoinedEventsAsyc(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage, string userId)
		{
			int totalEvents = context.Posts.Count();
			var postsQuery = context.Posts.Where(p => true);

			postsQuery = FilterPosts(postsQuery, campType, searchTerm, sort);

			postsQuery = postsQuery
                .Include(p => p.Participants)
                .Where(p => p.Participants.Any(pt => pt.ParticipantId == userId.Trim()));



			var posts = postsQuery.Select(p => new PostPreviewViewModel()
							{
								Id = p.Id,
								Name = p.Name,
								Image = p.ImgsUrl,
								Description = p.Description,
								Destination = p.Destination,
								CampType = p.CampType.Name,
								OwnerName = p.Owner.UserName,
								TravelType = p.TravelType.Name,
								ParticipantCount = p.Participants.Count(),
								Participants = p.Participants.Select(up => new UserPostsViewModel()
								{
									PostId = up.PostId,
									UserId = up.ParticipantId,
									UserName = up.Participant.UserName
								}).ToList()
							}).ToList();

			var resultCount = posts.Count();

			posts = posts.Skip(eventsPerPage * (currentPage - 1))
				.Take(eventsPerPage).ToList();

			return new AllPostQueryModel()
			{
				Posts = posts,
				TotalEventCount = totalEvents,
				CurrentPage = currentPage,
				ResultCount = resultCount
			};
		}

		public async Task<AllPostQueryModel> MyEventsAsync(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage, string userId)
		{
			int totalEvents = context.Posts.Count();
			var postsQuery = context.Posts.Where(p => true);

			postsQuery = FilterPosts(postsQuery, campType, searchTerm, sort);

			postsQuery = postsQuery
				.Include(p => p.Participants)
				.Where(p => p.OwnerId == userId.Trim());



			var posts = postsQuery.Select(p => new PostPreviewViewModel()
			{
				Id = p.Id,
				Name = p.Name,
				Image = p.ImgsUrl,
				Description = p.Description,
				Destination = p.Destination,
				CampType = p.CampType.Name,
				OwnerName = p.Owner.UserName,
				TravelType = p.TravelType.Name,
				ParticipantCount = p.Participants.Count(),
				Participants = p.Participants.Select(up => new UserPostsViewModel()
				{
					PostId = up.PostId,
					UserId = up.ParticipantId,
					UserName = up.Participant.UserName
				}).ToList()
			}).ToList();

			var resultCount = posts.Count();

			posts = posts.Skip(eventsPerPage * (currentPage - 1))
				.Take(eventsPerPage).ToList();

			return new AllPostQueryModel()
			{
				Posts = posts,
				TotalEventCount = totalEvents,
				CurrentPage = currentPage,
				ResultCount = resultCount
			};
		}

		private string SaveImageFile(IFormFile imageFile, HttpContext httpContext)
		{
			string wwwPath = this.Environment.WebRootPath;
			string contentPath = this.Environment.ContentRootPath;

			string path = Path.Combine(wwwPath, "imgs");

			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			string fileName = Path.GetFileName(imageFile.FileName);

			using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
			{
				imageFile.CopyTo(stream);
			}

			var pathScheme = httpContext.Request.Scheme + $":\\\\{httpContext.Request.Host.ToString()}";
			var pathReturn = Path.Combine(pathScheme, "imgs",imageFile.FileName).ToString();

			return pathReturn;
		}

		private void DeleteImageFile(string imagePath)
		{
			string webRootPath = this.Environment.WebRootPath;
			string fileName = Path.GetFileName(imagePath);
			string path = Path.Combine(webRootPath, "imgs", fileName);

			try
			{
				File.Delete(path);
			}
			catch
			{
				return;
			}

		}
	}
}
