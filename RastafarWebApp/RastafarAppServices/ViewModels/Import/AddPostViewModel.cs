using Microsoft.AspNetCore.Identity;
using RastafarWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RastafarAppServices.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RastafarAppServices.ViewModels.Export;

namespace RastafarAppServices.ViewModels.Import
{
	public class AddPostViewModel
	{

        [StringLength(100, MinimumLength = 10)]
		[Required]
		public string Name { get; set; } = null!;

		[StringLength(2000, MinimumLength = 20)]
		[Required]
		public string Description { get; set; } = null!;

		[Required]
		public string ImgsUrl { get; set; } = null!;

		[Required]
		[StringLength(100)]
		public string Destination { get; set; } = null!;

		[Required]
		[ValidateNever]
		public CampTypeViewModel campType { get; set; }

		[Required]
		[ValidateNever]
		public TravelTypeViewModel travelType { get; set; }

		[ValidateNever]
		public CampViewModel? camp { get; set; }

    }
}
