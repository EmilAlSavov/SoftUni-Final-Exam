using RastafarAppServices;
using RastafarAppServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppTests.UnitTests
{
	public class ProductServiceTests : UnitTestsBase
	{
		private IProductService productService;

		[OneTimeSetUp]
		public void SetUp()
		{
			this.productService = new ProductService(context);
		}

		[Test]
		public void AllReturnsCorrectCount()
		{
			var result = productService.All(null, 0, 1, 8).Products.Count();

			var expect = context.Products.Count();

			Assert.That(result, Is.EqualTo(expect));
		}

		[Test]
		public void DetailsReturnsCorrectProduct()
		{
			var result = productService.Detail(product1.Id);

			Assert.That(result.Id, Is.EqualTo(product1.Id));
		}
	}
}
