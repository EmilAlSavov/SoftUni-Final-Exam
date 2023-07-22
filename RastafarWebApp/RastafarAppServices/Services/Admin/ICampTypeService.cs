﻿using RastafarAppServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppServices.Services.Admin
{
	public interface ICampTypeService
	{
		public List<CampTypeViewModel> All();

		public Task AddAsync(CampTypeViewModel model);

		public Task DeleteAsync(Guid Id);
	}
}
