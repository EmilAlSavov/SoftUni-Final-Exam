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
	public class CountryService : ITravelTypeService
	{
		private readonly RastafarContext context;

        public CountryService(RastafarContext context)
        {
			this.context = context;
        }
        public async Task AddAsync(CountryViewModel model)
		{
			await context.Countries.AddAsync(new Country()
			{
				Id = Guid.NewGuid(),
				Name = model.Name,
			});

			await context.SaveChangesAsync();

			return;
		}

		public List<CountryViewModel> All()
		{
			var models = context.Countries.Select(c => new CountryViewModel()
			{
				Id = c.Id,
				Name = c.Name,
			}).ToList();

			return models;
		}

		public async Task DeleteAsync(Guid Id)
		{
			var country = await this.GetCountryAsync(Id);

			context.Countries.Remove(country);

			await context.SaveChangesAsync();

			return;
		}

		public async Task EditAsync(Guid Id, CountryViewModel model)
		{
			var campType = await GetCountryAsync(Id);

			campType.Name = model.Name;

			await context.SaveChangesAsync();

			return;
		}

		public async Task<Country> GetCountryAsync(Guid id)
		{
			return await context.Countries.FindAsync(id);
		}
	}
}
