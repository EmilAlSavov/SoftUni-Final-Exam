using HiparAppServices.Admin;
using HiparAppServices.Services.Admin;
using HiparAppServices.ViewModels;
using RastafarAppServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppTests.UnitTests
{
	internal class TravelTypeServiceTests : UnitTestsBase
	{
		private ITraveltypeService travelTypeService;

		[OneTimeSetUp]
		public void OnSetUp()
		{
			this.travelTypeService = new TraveltypeService(context);
		}

		[Test]
		public void AllReturnsCorrectCount()
		{
			var result = travelTypeService.All().Count();

			var expected = context.TravelTypes.Count();

			Assert.AreEqual(expected, result);
		}

		[Test]
		public async Task AddWorksCorrectly()
		{
			var model = new TravelTypeViewModel()
			{
				Name = "test"
			};

			await travelTypeService.AddAsync(model);

			var result = context.TravelTypes.FirstOrDefault(c => c.Name == "test");

			Assert.IsNotNull(result);
		}

		[Test]
		public async Task DeleteWorksCorrectly()
		{
			await travelTypeService.DeleteAsync(plain.Id);

			var result = context.TravelTypes.FirstOrDefault(c => c.Id == plain.Id);

			Assert.That(result, Is.Null);
		}

		[Test]
		public async Task EditWorksCorrectly()
		{
			var model = new TravelTypeViewModel()
			{
				Id = train.Id,
				Name = "test"
			};

			await travelTypeService.EditAsync(train.Id, model);

			var result = await context.TravelTypes.FindAsync(train.Id);

			Assert.That(result.Name, Is.EqualTo("test"));
		}

		[Test]
		public async Task GetByIdReturnsCorrectCountry()
		{
			var result = await travelTypeService.GetByIdAsync(train.Id);

			Assert.That(result.Id, Is.EqualTo(train.Id));
		}
	}
}
