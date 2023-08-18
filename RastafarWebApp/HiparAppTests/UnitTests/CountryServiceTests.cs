using HiparAppServices.Admin;
using HiparAppServices.Services.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppTests.UnitTests
{
	public class CountryServiceTests :UnitTestsBase
	{
		private ICountryService countryService;

		[OneTimeSetUp]
		public void OnSetUp()
		{
			this.countryService = new CountryService(context);
		}
	}
}
