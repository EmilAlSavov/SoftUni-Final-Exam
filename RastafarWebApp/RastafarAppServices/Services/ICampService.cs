using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.ViewModels;
using RastafarAppServices.ViewModels.Export;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.Services
{
    public interface ICampService
    {
        public AllCampQueryModel All(string searchTerm, EventSort sort, int currentPage, int eventsPerPage);

        public PostPreviewViewModel Detail(int postId);

        public AllPostQueryModel Events(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage);

    }
}
