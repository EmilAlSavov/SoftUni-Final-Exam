using RastafarAppData.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.ViewModels.Export
{
	public class AllPostQueryModel
	{
		public const int PostsPerPages = 8;

        public CampTypeViewModel CampType { get; set; }

        public List<CampTypeViewModel> CampTypes { get; set; }

        [DisplayName("Search by text")]
        public string SearchingTerm { get; set; }

        public EventSort Sort { get; set; }

        public List<string> Sorts { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalEventCount { get; set; }

        public List<PostPreviewViewModel> Posts { get; set; } = new List<PostPreviewViewModel>();
    }
}
