﻿using HiparAppServices.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using RastafarAppData.Data.Models;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices.ViewModels.Import;
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

			//campQuary = campQuary.Skip(eventsPerPage * (currentPage - 1))
			//	.Take(eventsPerPage);

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
								}).ToList(),
							}).ToList();

			var resultCount = camps.Count();

			camps = camps.Skip(eventsPerPage * (currentPage - 1)).Take(eventsPerPage).ToList();

			return new AllCampQueryModel()
			{
				Camps = camps,
				TotalEventCount = totalCamps,
				CurrentPage = currentPage,
				ResultCount = resultCount
			};
		}

        public CampViewModel Detail(Guid id)
        {
			var test = context.Camps.Find(id);
			var model = context.Camps.Where(c => c.Id == id)
				.Select(c => new CampViewModel()
				{
					Id = c.Id,
					Name = c.Name,
					Country = new CountryViewModel()
					{
						Id = c.CountryId,
						Name = c.Country.Name
					},
					Image = c.Image,
					Posts = c.Posts.Select(p => new PostPreviewViewModel()
					{
						Id = p.Id,
						Name = p.Name,
						Image = p.ImgsUrl,
						ParticipantCount = p.Participants.Count()
					}).ToList()
				}).First();

            return model;
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
				if (country.Id != Guid.Empty)
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

        public Camp GetCampById(Guid id)
        {
			return context.Camps.Find(id);
        }

		public async Task AddAsync(AddCampViewModel model)
		{
			var camp = new Camp()
			{
				Id = Guid.NewGuid(),
				Name = model.Name,
				CountryId = model.CountryId,
				Image = model.Image,
				Posts = new List<Post>()
			};

			await context.Camps.AddAsync(camp);
			await context.SaveChangesAsync();
			return;
		}

        public async Task EditAsync(Guid Id, AddCampViewModel model)
        {
			var camp = GetCampById(Id);

			camp.Name = model.Name;
			camp.Image = model.Image;
			camp.CountryId = model.CountryId;

			await context.SaveChangesAsync();

			return;
        }

        public async Task DeleteAsync(Guid Id)
        {
			var camp = GetCampById(Id);

			context.Camps.Remove(camp);

			await context.SaveChangesAsync();

			return;
        }

	}
}
