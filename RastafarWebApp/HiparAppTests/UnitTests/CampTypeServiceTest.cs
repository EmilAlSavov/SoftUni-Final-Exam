using HiparAppServices.Admin;
using HiparAppServices.Services.Admin;
using RastafarAppServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppTests.UnitTests
{
	[TestFixture]
	public class CampTypeServiceTest : UnitTestsBase
	{
		private ICampTypeService campTypeService;

		[OneTimeSetUp]
		public void OnSetUp()
		{
			campTypeService = new CampTypeService(context);
		}

		[Test]
		public void AllReturnsCorrectCount()
		{
			var result = campTypeService.All().Count();

			var expected = context.CampTypes.Count();

			Assert.That(result, Is.EqualTo(expected));
		}

		[Test]
		public async Task AddWorksCorrectly()
		{
			var id = Guid.NewGuid();

			var model = new CampTypeViewModel()
			{
				Id = id,
				Name = "test"
			};

			await campTypeService.AddAsync(model);

			var result = context.CampTypes.FirstOrDefault(ct => ct.Name == "test");

			Assert.That(result, Is.Not.Null);
		}

		[Test]
		public async Task DeleteWorksCorrectly()
		{
			await campTypeService.DeleteAsync(camper.Id);

			var result = await context.CampTypes.FindAsync(camper.Id);

			Assert.That(result, Is.Null);
		}

		[Test]
		public async Task EditWorksCorrectly()
		{
			var model = new CampTypeViewModel()
			{
				Id = caravan.Id,
				Name = "test"
			};

			await campTypeService.EditAsync(caravan.Id, model);

			var result = await context.CampTypes.FindAsync(caravan.Id);

			Assert.That(result.Name, Is.EqualTo("test"));
		}

		[Test]
		public async Task FindByIdFindsCorrectCampType()
		{
			var result = await campTypeService.GetByIdAsync(caravan.Id);

			Assert.That(result.Id, Is.EqualTo(caravan.Id));
		}
	}
}
