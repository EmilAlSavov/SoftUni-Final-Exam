using HiparAppServices.ViewModels;
using RastafarAppData.Data.Models;
using RastafarAppServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppServices.Services.Admin
{
	public interface ICountryService
	{
		public List<ViewModels.CountryViewModel> All();

		public Task AddAsync(ViewModels.CountryViewModel model);

		public Task DeleteAsync(Guid Id);

		public Task EditAsync(Guid Id, ViewModels.CountryViewModel model);

		public Task<CampType> GetCampTypeByIdAsync(Guid id);
	}
}
