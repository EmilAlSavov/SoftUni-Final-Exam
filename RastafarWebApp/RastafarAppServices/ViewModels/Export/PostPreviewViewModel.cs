using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.ViewModels.Export
{
    public class PostPreviewViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public string OwnerName { get; set; }

        public string Destination { get; set; }

        public string CampType { get; set; }

        public string TravelType { get; set; }

        public int ParticipantCount { get; set; }

        public List<UserPostsViewModel> Participants { get; set; }


    }
}
