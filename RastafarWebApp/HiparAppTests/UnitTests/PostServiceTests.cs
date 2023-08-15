using RastafarAppServices;
using RastafarAppServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiparAppTests.UnitTests
{
	[TestFixture]
	public class PostServiceTests : UnitTestsBase
	{
		private IPostService postServie;
		[OneTimeSetUp]
		public void SetUp()
		{
			this.postServie = new PostService(context);
		}

		[Test]
		public void GetPostByIdShouldReturnCorrectPost()
		{
			var resultPost = postServie.GetPostById(testPost1.Id);

			Assert.That(resultPost, Is.EqualTo(testPost1));
		}
	}
}
