using RastafarAppData.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.ViewModels.Export
{
    public class AllCampQueryModel
    {
        public const int CampsPerPages = 8;

        public CountryViewModel Country { get; set; }

        public List<CountryViewModel> Countries { get; set; }

        [DisplayName("Search by text")]
        public string SearchingTerm { get; set; }

        public CampSort Sort { get; set; }

        public List<string> Sorts { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalEventCount { get; set; }

        public List<CampViewModel> Camps { get; set; } = new List<CampViewModel>();
    }
}
