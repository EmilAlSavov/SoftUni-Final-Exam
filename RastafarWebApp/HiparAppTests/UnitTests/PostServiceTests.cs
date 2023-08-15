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
	public class PostServiceTests : UnitTestsBase
	{
		private IPostService postService;
		[OneTimeSetUp]
		public void SetUp()
		{
			this.postService = new PostService(context);
		}

		[Test]
		public void GetAllPostsReturnsAllPosts()
		{

			var result = postService.All(null, null, 0, 1, 8).Posts;
			var posts = context.Posts;

			Assert.That(result.Count(), Is.EqualTo(context.Posts.Count()));
		}

		[Test]
		public void GetPostByIdShouldReturnCorrectPost()
		{
			var resultPost = postService.GetPostById(testPost3.Id);

			Assert.That(resultPost, Is.EqualTo(testPost3));
		}

		[Test]
		public async Task MyPostsReturnsCorrectPosts()
		{
			var result = await postService.MyEventsAsync(null, null, 0, 1, 8, admin.Id);

			var resultPosts = result.Posts;

			Assert.IsTrue(resultPosts.All(p => p.OwnerName == admin.UserName));
		}

		[Test]
		public void AddPostWorksCorrectly()
		{
			var model = new AddPostViewModel()
			{
				Name = "Unit Test",
				Description = "Test Unit Testsjdnasjkdnajkdnajkdnajkdnajkldnadlnadladnasdlnaklnsda",
				Destination = "TestRepo",
				ImgsUrl = "invalidimage",
				campType = new RastafarAppServices.ViewModels.CampTypeViewModel() { Id = camper.Id },
				travelType = new RastafarAppServices.ViewModels.TravelTypeViewModel() { Id = train.Id },
				camp = null,
			};

			postService.Add(model, admin.Id);

			var result = context.Posts.Where(p => p.Name == "Unit Test").FirstOrDefault();

			Assert.That(result, Is.Not.Null);
		}

		[Test]
		public void EditPostWorksCorrectly()
		{
			var model = new AddPostViewModel()
			{
				Name = testPost1.Name + " Edited",
				Description = testPost1.Description,
				Destination = testPost1.Destination,
				ImgsUrl = testPost1.ImgsUrl,
				campType = new RastafarAppServices.ViewModels.CampTypeViewModel() { Id = camper.Id },
				travelType = new RastafarAppServices.ViewModels.TravelTypeViewModel() { Id = train.Id },
				camp = null,
			};

			postService.Edit(model, testPost1.Id, admin.Id);

			var result = context.Posts.Find(testPost1.Id);

			Assert.True(result.Name.Contains("Edited"));
		}

		[Test]
		public void DeletePostWorksCorrectly()
		{
			postService.Delete(testPost2.Id);

			var result = context.Posts.Find(testPost2.Id);

			Assert.That(result, Is.Null);
		}

		[Test]
		public void JoinPostWorksCorrectyl()
		{
			postService.Join(testPost3.Id, admin.Id);

			Assert.True(context.Posts.Find(testPost3.Id).Participants.Any(p => p.ParticipantId == admin.Id));
		}

		[Test]
		public void LeavePostWorksCorrectyl()
		{
			postService.Leave(testPost3.Id, admin.Id);

			var participants = context.Posts.Find(testPost3.Id).Participants;

			Assert.False(context.Posts.Find(testPost3.Id).Participants.Any(p => p.ParticipantId == admin.Id));
		}

		[Test]
		public void DetailPostReturnsCorrectPost()
		{
			var result = postService.Detail(testPost3.Id);

			Assert.That(result.Name, Is.EqualTo(testPost3.Name));
		}

		[Test]
		public async Task JoinedEventsReturnsCorrectEvents()
		{
			postService.Join(testPost3.Id, admin.Id);

			var result = await postService.JoinedEventsAsyc(null, null, 0, 1, 8, admin.Id);

			var resultPosts = result.Posts;

			Assert.True(resultPosts.All(p => p.Participants.Any(pt => pt.UserId == admin.Id)));

		}

		[Test]
		public async Task MyEventsReturnsCorrectEvents()
		{
			var result = await postService.MyEventsAsync(null, null, 0, 1, 8, admin.Id);

			var resultPosts = result.Posts;

			Assert.True(resultPosts.All(p => p.OwnerName == admin.UserName));
		}

		[Test]
		public void GetCampTypesAsViewModelsGetsAll()
		{
			var result = postService.GetCampTypesAsViewModels();

			Assert.That(result.Count(), Is.EqualTo(context.CampTypes.Count()));
		}

		[Test]
		public void GetTravelTypesAsViewModelsGetsAll()
		{
			var result = postService.GetTravelTypesAsViewModels();

			Assert.That(result.Count(), Is.EqualTo(context.TravelTypes.Count()));
		}
	}
}
