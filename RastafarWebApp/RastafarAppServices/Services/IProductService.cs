using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.ViewModels.Export;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices.Services
{
	public interface IProductService
	{
		public AllProductQueryModel All(string searchTerm, ProductSort sort, int currentPage, int eventsPerPage);

		public ProductViewModel Detail(Guid id);

		public List<string> GetEnumList<T>();


	}
}
