using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiparAppServices.ViewModels;

namespace RastafarAppServices.ViewModels.Export
{
    public class CampViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public CountryViewModel Country { get; set; }

        public string Image { get; set; }

        public List<PostPreviewViewModel> Posts { get; set; }
    }
}
