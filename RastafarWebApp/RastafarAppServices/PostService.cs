using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices.ViewModels.Import;
using RastafarWebApp.Data;
using RastafarWebApp.Data.Models;
using RastafarWebApp.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices
{
    public class PostService : IPostService
    {
        private RastafarContext context { get; set; }

        public PostService(RastafarContext context)
        {
                this.context = context;
        }

        public void Add(AddPostViewModel model, string id)
        {
            context.Posts.Add(new Post()
            {
                Name = model.Name,
                Description = model.Description,
                Destination = model.Destination,
                campType = (CampType)model.campType,
                travelType = (TravelType)model.travelType,
                CreatedOn = DateTime.Now,
                ImgsUrl = model.ImgsUrl,
                OwnerId = id,
                Participants = new List<IdentityUserPosts>()
            });

            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var post = this.GetPostById(id);

            context.Posts.Remove(post);

            context.SaveChanges();
        }

        public void Edit(AddPostViewModel model, int Id)
        {
            var realPost = this.GetPostById(Id);

            realPost.Name = model.Name;
            realPost.Description = model.Description;
            realPost.Destination = model.Destination;
            realPost.ImgsUrl = model.ImgsUrl;
            realPost.campType = model.campType;
            realPost.travelType = model.travelType;

            context.SaveChanges();
        }

        public List<PostPreviewViewModel> Fauvorite()
        {
            throw new NotImplementedException();
        }

        public List<PostPreviewViewModel> MyEvents()
        {
            throw new NotImplementedException();
        }

		public AllPostQueryModel All(CampType campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage)
		{
            int totalEvents = context.Posts.Count();
            var postsQuery = context.Posts.Where(p => true);

            postsQuery = FilterPosts(postsQuery, campType, searchTerm, sort);
            
                postsQuery = postsQuery.Skip(eventsPerPage * (currentPage - 1))
                    .Take(eventsPerPage);

                var posts = postsQuery
                                .Select(p => new PostPreviewViewModel()
                                {
                                    Id = p.Id,
                                    Name = p.Name,
                                    Image = p.ImgsUrl,
                                    Description = p.Description,
                                    Destination = p.Destination,
                                    CampType = p.campType.ToString(),
                                    OwnerName = p.Owner.UserName,
                                    TravelType = p.travelType.ToString(),
                                    ParticipantCount = p.Participants.Count(),
                                    Participants = p.Participants.Select(up => new UserPostsViewModel()
                                    {
                                        PostId = up.PostId,
                                        UserId = up.ParticipantId,
                                        UserName = up.Participant.UserName
                                    }).ToList()
                                }).ToList();


            return new AllPostQueryModel()
            {
                Posts = posts,
                TotalEventCount = totalEvents,
                CurrentPage = currentPage
            };
        }

        private IQueryable<Post> FilterPosts(IQueryable<Post> postsQuery, CampType campType, string searchTerm, EventSort sort)
        {
			if ((int)campType != 0)
			{
				postsQuery = postsQuery
				.Where(p => p.campType == campType);
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
			return Enum.GetNames(typeof(T))
				   .Select(s => s).ToList();
		}

		public void Join(int postId, string userId)
		{
            var userPost = new IdentityUserPosts()
            {
                PostId = postId,
                ParticipantId = userId
            };

            var post = GetPostById(postId);

            context.UsersPosts.Add(userPost);
            post.Participants.Add(userPost);

            context.SaveChanges();
		}

		public void Leave(int postId, string userId)
		{
            Post post = GetPostById(postId);
            
            var userPost = context.UsersPosts.FirstOrDefault(p => p.PostId == postId && p.ParticipantId == userId);

            post.Participants.Remove(userPost);
            context.UsersPosts.Remove(userPost);

            context.SaveChanges();
		}

		public Post GetPostById(int id)
		{
            return context.Posts.Find(id);
		}
	}
}
