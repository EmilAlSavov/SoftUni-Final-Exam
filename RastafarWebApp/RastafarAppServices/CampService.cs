using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels;
using RastafarAppServices.ViewModels.Export;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices
{
    public class CampService : ICampService
    {
        public AllCampQueryModel All(string searchTerm, EventSort sort, int currentPage, int eventsPerPage)
        {
            throw new NotImplementedException();
        }

        public PostPreviewViewModel Detail(int postId)
        {
            throw new NotImplementedException();
        }

        public AllPostQueryModel Events(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage)
        {
            throw new NotImplementedException();
        }
    }
}
