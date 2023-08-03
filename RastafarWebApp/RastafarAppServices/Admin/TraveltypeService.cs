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
    public class TraveltypeService : ITraveltypeService
    {
        private readonly RastafarContext context;

        public TraveltypeService(RastafarContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(TravelTypeViewModel model)
        {
            await context.TravelTypes.AddAsync(new TravelType()
            {
                Name = model.Name,
            });

            await context.SaveChangesAsync();

            return;
        }

        public List<TravelTypeViewModel> All()
        {
            return context.TravelTypes.Select(ct => new TravelTypeViewModel()
            {
                Id = ct.Id,
                Name = ct.Name
            }).ToList();
        }

        public async Task DeleteAsync(Guid Id)
        {
            var travelType = await context.TravelTypes.FindAsync(Id);

            context.TravelTypes.Remove(travelType);

            await context.SaveChangesAsync();
            return;
        }

        public async Task EditAsync(Guid Id, TravelTypeViewModel model)
        {
            var travelType = await context.TravelTypes.FindAsync(Id);

            travelType.Name = model.Name;

            await context.SaveChangesAsync();
            return;
        }

        public async Task<TravelType> GetByIdAsync(Guid Id)
        {
            return await context.TravelTypes.FindAsync(Id);
        }
    }
}
