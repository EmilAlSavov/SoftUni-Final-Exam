using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.ViewModels.Export
{
    public class CountryViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<CampViewModel> Camps { get; set; } = new List<CampViewModel>();
    }
}
