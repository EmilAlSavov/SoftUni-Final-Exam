using RastafarAppData.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.ViewModels.Import
{
	public class AddCampViewModel
	{
		[StringLength(100, MinimumLength = 10)]
		[Required]
		public string Name { get; set; }

		[Required]
		public string Image { get; set; }

		[Required]
		[ForeignKey(nameof(CountryId))]
		public Country Country { get; set; } = null!;

		public Guid CountryId { get; set; }
	}
}
