using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.ViewModels;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices.ViewModels.Import;
using RastafarWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.Services
{
    public interface IPostService
    {
        public AllPostQueryModel All(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage);


        public List<PostPreviewViewModel> Fauvorite();

        public void Add(AddPostViewModel model, string id);

        public void Edit(AddPostViewModel model, Guid Id, string currUserId);

        public void Delete(Guid id);

        public void Join(Guid postId, string userId);

        public void Leave(Guid postId, string userId);

        public PostPreviewViewModel Detail(Guid postId);

		public Task<AllPostQueryModel> JoinedEventsAsyc(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage, string userId);
		public Task<AllPostQueryModel> MyEventsAsync(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage, string userId);

		public List<string> GetEnumList<T>();
		public Post GetPostById(Guid id);

        public List<CampTypeViewModel> GetCampTypesAsViewModels();

        public List<TravelTypeViewModel> GetTravelTypesAsViewModels();
	}
}
