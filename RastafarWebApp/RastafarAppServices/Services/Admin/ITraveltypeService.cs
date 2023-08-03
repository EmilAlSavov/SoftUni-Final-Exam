using RastafarAppData.Data.Models;
using RastafarAppServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppServices.Services.Admin
{
    public interface ITraveltypeService
    {
        public List<TravelTypeViewModel> All();

        public Task AddAsync(TravelTypeViewModel model);

        public Task DeleteAsync(Guid Id);

        public Task EditAsync(Guid Id, TravelTypeViewModel model);

        public Task<TravelType> GetByIdAsync(Guid Id);
    }
}
