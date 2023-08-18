using RastafarAppServices;
using RastafarAppServices.Services;
using RastafarAppServices.ViewModels.Export;
using RastafarAppServices.ViewModels.Import;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppTests.UnitTests
{
	[TestFixture]
	public class CampServiceTests : UnitTestsBase
	{
		private ICampService campService;

		[OneTimeSetUp]
		public void SetUp()
		{
			this.campService = new CampService(context);
		}

		[Test]
		public void AllReturnsCorrectCount()
		{
			var expect = context.Camps.Count();

			var result = campService.All(null, null, 0, 1, 8).Camps.Count();

			Assert.That(result, Is.EqualTo(expect));
		}

		[Test]
		public void DetailReturnsCorrectCamp()
		{
			var result = campService.Detail(saravari.Id);

			Assert.That(result.Name, Is.EqualTo(saravari.Name));
		}

		[Test]
		public async Task AddWorksCorrectly()
		{
			var model = new AddCampViewModel()
			{
				Name = "Test",
				Image = "testimage",
				CountryId = greece.Id
			};

			await campService.AddAsync(model);

			var result = context.Camps.Where(c => c.Name == "Test").FirstOrDefault();

			Assert.That(result, Is.Not.Null);
		}

		[Test]
		public async Task EditWorksCorrectyl()
		{
			var model = new AddCampViewModel()
			{
				Name = boshkaada.Name + "Edited",
				Image = boshkaada.Image,
				CountryId = boshkaada.CountryId
			};

			await campService.EditAsync(boshkaada.Id, model);

			var result = await context.Camps.FindAsync(boshkaada.Id);

			Assert.True(result.Name.Contains("Edited"));
		}

		[Test]
		public async Task DeleteWorksCorrectly()
		{
			await campService.DeleteAsync(gradina.Id);

			var result = context.Camps.Where(c => c.Id == gradina.Id).FirstOrDefault();

			Assert.That(result, Is.Null);
		}

		[Test]
		public void GetCountriesAsViewModelsReturnsAllCountries()
		{
			var result = campService.GetCountriesTypesAsViewModels().Count();

			var expect = context.Countries.Count();
			
			Assert.That(expect, Is.EqualTo(result));
		}

		[Test]
		public void GetCampsAsViewModelsReturnsAllCamps()
		{
			var result = campService.GetCampsAsViewModels().Count();

			var expect = context.Camps.Count();

			Assert.That(expect, Is.EqualTo(result));
		}

		[Test]
		public void GetCampByIdReturnsCorrectCamp()
		{
			var result = campService.GetCampById(saravari.Id);

			Assert.That(result, Is.EqualTo(saravari));
		}
	}
}
