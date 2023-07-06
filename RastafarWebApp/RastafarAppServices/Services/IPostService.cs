using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.ViewModels.Export;
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
        public AllPostQueryModel All(string campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage);

        public List<PostPreviewViewModel> MyEvents();

        public List<PostPreviewViewModel> Fauvorite();

        public void Add();

        public void Edit();

        public void Delete();

        public List<string> GetEnumList<T>();


	}
}
