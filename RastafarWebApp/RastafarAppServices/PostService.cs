using RastafarAppServices.Services;
using RastafarAppServices.ViewModels.Export;
using RastafarWebApp.Data;
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

        public List<PostPreviewViewModel> All()
        {
           return context.Posts.Select(p => new PostPreviewViewModel()
            {
                Name = p.Name,
                Image = p.ImgsUrl,
                Description = p.Description,
                Destination = p.Destination,
                CampType = p.campType.ToString(),
                OwnerName = p.Owner.UserName,
                TravelType = p.travelType.ToString(),
                ParticipantCount = p.Participants.Count()
            }).ToList();
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
    }
}
