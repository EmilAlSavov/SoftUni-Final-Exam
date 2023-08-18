using HiparAppServices.Admin;
using HiparAppServices.Services.Admin;
using HiparAppServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppTests.UnitTests
{
	public class CountryServiceTests :UnitTestsBase
	{
		private ITravelTypeService countryService;

		[OneTimeSetUp]
		public void OnSetUp()
		{
			this.countryService = new CountryService(context);
		}

		[Test]
		public void AllReturnsCorrectCount()
		{
			var result = countryService.All().Count();

			var expected = context.Countries.Count();

			Assert.AreEqual(expected, result);
		}

		[Test]
		public async Task AddWorksCorrectly()
		{
			var model = new CountryViewModel()
			{
				Name = "test"
			};

			await countryService.AddAsync(model);

			var result = context.Countries.FirstOrDefault(c => c.Name == "test");

			Assert.IsNotNull(result);
		}

		[Test]
		public async Task DeleteWorksCorrectly()
		{
			await countryService.DeleteAsync(bulgaria.Id);

			var result = context.Countries.FirstOrDefault(c => c.Id == bulgaria.Id);

			Assert.That(result, Is.Null);
		}

		[Test]
		public async Task EditWorksCorrectly()
		{
			var model = new CountryViewModel()
			{	Id = greece.Id,
				Name = "test"
			};

			await countryService.EditAsync(greece.Id, model);

			var result = await context.Countries.FindAsync(greece.Id);

			Assert.That(result.Name, Is.EqualTo("test"));
		}

		[Test]
		public async Task GetByIdReturnsCorrectCountry()
		{
			var result = await countryService.GetCountryAsync(greece.Id);

			Assert.That(result.Id, Is.EqualTo(greece.Id));
		}
	}
}
