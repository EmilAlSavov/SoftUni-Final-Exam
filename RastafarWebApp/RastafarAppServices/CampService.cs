using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RastafarAppData.Data.Models;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels;
using RastafarAppServices.ViewModels.Export;
using RastafarWebApp.Data;
using RastafarWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices
{
    public class CampService : ICampService
    {
        private RastafarContext context { get; set; }

        public CampService(RastafarContext context)
        {
            this.context = context;
        }

        public AllCampQueryModel All(CountryViewModel country,string searchTerm, CampSort sort, int currentPage, int eventsPerPage)
        {
			int totalCamps = context.Camps.Count();
			var campQuary = context.Camps.Where(p => true);

			campQuary = FilterCamps(campQuary, country, searchTerm, sort);

			campQuary = campQuary.Skip(eventsPerPage * (currentPage - 1))
				.Take(eventsPerPage);

			var camps = campQuary
							.Select(c => new CampViewModel()
							{
								Id = c.Id,
								Name = c.Name,
								Image = c.Image,
								Country = new CountryViewModel()
								{
									Id = c.CountryId,
									Name = c.Country.Name,
								},
								Posts = c.Posts.Select(p => new PostPreviewViewModel()
								{
									Id = p.Id,
								}).ToList()
							}).ToList();


			return new AllCampQueryModel()
			{
				Camps = camps,
				TotalEventCount = totalCamps,
				CurrentPage = currentPage
			};
		}

        public PostPreviewViewModel Detail(int postId)
        {
            throw new NotImplementedException();
        }

        public AllPostQueryModel Events(CampTypeViewModel campType, string searchTerm, EventSort sort, int currentPage, int eventsPerPage)
        {
            throw new NotImplementedException();
        }

		public List<string> GetEnumList<T>()
		{
			if (typeof(T).Name == "CampType")
			{
				return context.CampTypes.Select(ct => ct.Name).ToList();
			}

			return Enum.GetNames(typeof(T))
				   .Select(s => s).ToList();
		}

        public List<CountryViewModel> GetCountriesTypesAsViewModels()
        {
			return context.Countries.Select(ct => new CountryViewModel()
			{
				Id = ct.Id,
                Name = ct.Name,
			}).ToList();
		}

		public List<CampViewModel> GetCampsAsViewModels()
		{
			return context.Camps.Select(ct => new CampViewModel()
			{
				Id = ct.Id,
				Name = ct.Name,
			}).ToList();
		}

		private IQueryable<Camp> FilterCamps(IQueryable<Camp> campQuary, CountryViewModel country, string searchTerm, CampSort sort)
		{
			if (country != null)
			{
				if (country.Id != 0)
				{
					campQuary = campQuary
					.Where(c => c.CountryId == country.Id);
				}
			}


			if (searchTerm != null)
			{
				campQuary = campQuary.Include(p => p.Country)
				.Where(p => p.Name.ToLower().Contains(searchTerm.ToLower())
				|| p.Country.Name.ToLower().Contains(searchTerm.ToLower()));
			}

			if ((int)sort == 0)
			{
				campQuary = campQuary.Include(p => p.Posts).OrderByDescending(p => p.Posts.Count());
			}else if ((int)sort == 1)
			{
				campQuary = campQuary.OrderBy(p => p.Name);
			}

			return campQuary;
		}
	}
}
