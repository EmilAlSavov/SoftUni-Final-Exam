using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels.Export;
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

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public List<PostPreviewViewModel> Fauvorite()
        {
            throw new NotImplementedException();
        }

        public List<PostPreviewViewModel> MyEvents()
        {
            throw new NotImplementedException();
        }

		public AllPostQueryModel All(string campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage)
		{
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
                                    ParticipantCount = p.Participants.Count()
                                }).ToList();


            return new AllPostQueryModel()
            {
                Posts = posts,
            };
        }

        private IQueryable<Post> FilterPosts(IQueryable<Post> postsQuery, string campType, string searchTerm, EventSort sort)
        {
			if (campType != "All")
			{
				postsQuery = postsQuery
				.Where(p => p.campType.ToString() == campType);
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
				postsQuery = postsQuery.OrderBy(p => p.CreatedOn);
			}
			else if ((int)sort == 1)
			{
				postsQuery = postsQuery.OrderBy(p => p.Name);
			}
			else if ((int)sort == 2)
			{
				postsQuery = postsQuery
					.Include(p => p.Participants)
					.OrderBy(p => p.Participants.Count());

			}

            return postsQuery;
		}

		public List<string> GetEnumList<T>()
		{
			return Enum.GetNames(typeof(T))
				   .Select(s => s).ToList();
		}

	}
}
