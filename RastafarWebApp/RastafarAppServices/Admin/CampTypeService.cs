using HiparAppServices.Services.Admin;
using RastafarAppData.Data.Models;
using RastafarAppServices.ViewModels;
using RastafarWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppServices.Admin
{
	public class CampTypeService : ICampTypeService
	{

		private readonly RastafarContext context;

        public CampTypeService(RastafarContext context)
        {
			this.context = context;
        }

        public async Task AddAsync(CampTypeViewModel model)
		{
			await context.CampTypes.AddAsync(new CampType()
			{
				Name = model.Name,
			});

			await context.SaveChangesAsync();

			return;
		}

		public List<CampTypeViewModel> All()
		{
			return context.CampTypes.Select(ct => new CampTypeViewModel()
			{
				Id = ct.Id,
				Name = ct.Name
			}).ToList();
		}

		public async Task DeleteAsync(Guid Id)
		{
			var campType = await context.CampTypes.FindAsync(Id);

			context.CampTypes.Remove(campType);

			await context.SaveChangesAsync();
			return;
		}

		public async Task EditAsync(Guid Id, CampTypeViewModel model)
		{
			var campType = await context.CampTypes.FindAsync(Id);

			campType.Name = model.Name;

			await context.SaveChangesAsync();
			return;
		}

		public async Task<CampType> GetByIdAsync(Guid Id)
		{
			return await context.CampTypes.FindAsync(Id);
		}
	}
}
