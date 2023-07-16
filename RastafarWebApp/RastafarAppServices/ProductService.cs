using Microsoft.EntityFrameworkCore;
using RastafarAppData.Data.Models;
using RastafarAppData.Data.Models.Enums;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels.Export;
using RastafarWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastafarAppServices
{
    public class ProductService : IProductService
    {
		private readonly RastafarContext context;

        public ProductService(RastafarContext context)
        {
			this.context = context;
        }
        public AllProductQueryModel All(string searchTerm, ProductSort sort, int currentPage, int eventsPerPage)
        {
			int totalProducts = context.Products.Count();
			var productQuery = context.Products.Where(p => true);

			productQuery = FilterProducts(productQuery, searchTerm, sort);

			productQuery = productQuery.Skip(eventsPerPage * (currentPage - 1))
				.Take(eventsPerPage);

			var camps = productQuery
							.Select(c => new ProductViewModel()
							{
								Id = c.Id,
								Name = c.Name,
								Description = c.Description,
								Image = c.ImgUrl,
								Price = c.Price,
							}).ToList();


			return new AllProductQueryModel()
			{
				Products = camps,
				TotalProductCount = totalProducts,
				CurrentPage = currentPage
			};
		}

		private IQueryable<Product> FilterProducts(IQueryable<Product> productQuery, string searchTerm, ProductSort sort)
		{

			if (searchTerm != null)
			{
				productQuery = productQuery
				.Where(p => p.Name.ToLower().Contains(searchTerm.ToLower()));
			}

			if ((int)sort == 0)
			{
				productQuery = productQuery.OrderByDescending(p => p.CreatedOn);
			}
			else if ((int)sort == 1)
			{
				productQuery = productQuery.OrderBy(p => p.Name);
			}

			return productQuery;
		}

		public List<string> GetEnumList<T>()
		{

			return Enum.GetNames(typeof(T))
				   .Select(s => s).ToList();
		}

        public ProductViewModel Detail(Guid id)
        {
			var realProduct = context.Products.Find(id);

			var model = new ProductViewModel()
			{
				Id = id,
				Image = realProduct.ImgUrl,
				Description = realProduct.Description,
				Name = realProduct.Name,
				Price = realProduct.Price
			};

			return model;
        }
    }
}
