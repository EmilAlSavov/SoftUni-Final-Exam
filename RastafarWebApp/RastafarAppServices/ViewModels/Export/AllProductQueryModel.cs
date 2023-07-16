using RastafarAppData.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.ViewModels.Export
{
	public class AllProductQueryModel
	{
		public const int ProductsPerPages = 8;

		[DisplayName("Search by text")]
		public string SearchingTerm { get; set; }

		public ProductSort Sort { get; set; }

		public List<string> Sorts { get; set; }

		public int CurrentPage { get; set; } = 1;

		public int TotalProductCount { get; set; }

		public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
    }
}
