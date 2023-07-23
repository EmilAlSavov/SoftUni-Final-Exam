using HiparAppServices.Services.Admin;
using HiparAppServices.ViewModels;
using RastafarAppData.Data.Models;
using RastafarWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppServices.Admin
{
	public class CountryService : ICountryService
	{
		private readonly RastafarContext context;

        public CountryService(RastafarContext context)
        {
			this.context = context;
        }
        public Task AddAsync(CountryViewModel model)
		{
			throw new NotImplementedException();
		}

		public List<CountryViewModel> All()
		{
			var models = context.Countries.Select(c => new CountryViewModel()
			{
				Name = c.Name,
			}).ToList();

			return models;
		}

		public Task DeleteAsync(Guid Id)
		{
			throw new NotImplementedException();
		}

		public Task EditAsync(Guid Id, CountryViewModel model)
		{
			throw new NotImplementedException();
		}

		public Task<CampType> GetCampTypeByIdAsync(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
