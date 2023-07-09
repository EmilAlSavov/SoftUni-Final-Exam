using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices.ViewModels.Import;
using RastafarWebApp.Data.Models;
using RastafarWebApp.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.Services
{
    public interface IPostService
    {
        public AllPostQueryModel All(CampType campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage);

        public List<PostPreviewViewModel> MyEvents();

        public List<PostPreviewViewModel> Fauvorite();

        public void Add(AddPostViewModel model, string id);

        public void Edit(AddPostViewModel model, int Id, string currUserId);

        public void Delete(int id);

        public void Join(int postId, string userId);

        public void Leave(int postId, string userId);

		public List<string> GetEnumList<T>();
		public Post GetPostById(int id);
	}
}
